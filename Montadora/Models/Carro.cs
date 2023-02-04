namespace Models
{
    public class Carro
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int PercentualCombustivel { get; set; }
        public string  Placa { get; set; }
        public int Ano { get; set; }
        public int VelocidadeAtual { get; set; }
        public int VelocidadeMaxima  { get; set; }
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

            PneuDianteiroEsquerdo = new Pneu(16,"Carro de passeio", "Firestone", true, 150);
            PneuDianteiroDireito = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
            PneuTraseiroEsquerdo = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
            PneuTraseiroDireito = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
            PneuEstepe = new Pneu(16, "Carro de passeio", "Firestone", true, 70);
        }   

        public void Ligar()
        {
                if(PercentualCombustivel > 0)
                {
                    Ligado = true;
                }
        }

        public void Desligar()
        {
            Ligado = false;
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual= 0;
            PneuDianteiroEsquerdo.VelocidadeAtual= 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
        }

        public void Acelerar()
        {

        }

        public void Frear()
        {

        }

        public void Abastercer()
        {

        }

    }
}
    