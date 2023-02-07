using System.Runtime.ConstrainedExecution;

namespace Models
{
    public class Carro
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int PercentualCombustivel { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public int VelocidadeAtual { get; set; }
        public int VelocidadeMaxima { get; set; }
        public bool Ligado { get; set; }
        public int Odometro { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }


        public Carro(string? _modelo, string? _marca, string _placa, int _ano, int _velocidadeMaxima)
        {
            Modelo = _modelo;
            Marca = _marca;
            Placa = _placa;
            Ano = _ano;
            VelocidadeMaxima = _velocidadeMaxima;

            Ligado = false;
            Odometro = 0;
            PercentualCombustivel = 0;
            VelocidadeAtual = 0;

            PneuDianteiroEsquerdo = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            PneuDianteiroDireito = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            PneuTraseiroEsquerdo = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            PneuTraseiroDireito = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            PneuEstepe = new Pneu(16, "Pneu de Estepe", "Firestone", true, 70);
        }

        public void Ligar()
        {

            if (PercentualCombustivel > 0)
            {
                Ligado = true;
                PercentualCombustivel = PercentualCombustivel - 3;

                if (PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                }
            }
        }

        public void Desligar()
        {
            Ligado = false;
            Parar();
        }

        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {
                Odometro += 18;

                PercentualCombustivel = PercentualCombustivel - 8;
                if (PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                    return;
                }

                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);

                if (PneuDianteiroDireito.Estourado || PneuDianteiroEsquerdo.Estourado || PneuTraseiroDireito.Estourado 
                    || PneuTraseiroEsquerdo.Estourado)
                {
                    Parar();
                }
            }

        }

        private void Parar()
        {
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
        }

        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }

            PneuDianteiroDireito.Frear(_reduzir);
            PneuDianteiroEsquerdo.Frear(_reduzir);
            PneuTraseiroDireito.Frear(_reduzir);
            PneuTraseiroEsquerdo.Frear(_reduzir);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustível que deseja abastercer, caso informe 0 o método irá 
        /// completar o tanque. O valor não pode ser superior a 100.</param>
        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
            {
                _quantidadeCombustivel = 100 - _quantidadeCombustivel;
            }

            if (PercentualCombustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("Quantidade de combustível ultrapassa o limite do tanque!");
                return;
            }

            if (PercentualCombustivel < 100)
            {
                PercentualCombustivel = PercentualCombustivel + _quantidadeCombustivel;
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Percentual de Combustivel: " + PercentualCombustivel);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);

            Console.WriteLine("\nPneu Dianteiro Esquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneu Dianteiro Direito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneu Traseiro Esquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneu Traseiro Direito");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneu Estepe");
            PneuEstepe.Exibir();

        }

    }
}
