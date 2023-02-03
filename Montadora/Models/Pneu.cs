namespace Models
{
    public class Pneu
    {

        public int Aro { get; set; }
        public bool TWI { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public string Tipo { get; set; }
        public int PercentualBorracha { get; set; }

        public Pneu( int _aro, string _tipo, string _marca, bool _estepe, int _velocidadeMaxima)
        {
            Aro = _aro;
            Tipo = _tipo;
            Marca = _marca;
            Estepe = _estepe;
            VelocidadeMaxima = _velocidadeMaxima;

            Cor = "Preto";
            Furado = false;
            Estourado = false;
            VelocidadeAtual = 0;
            PercentualBorracha = 100;
            TWI = false;

        }

        public void Girar(int _velocidade)
        {

            if (Estourado)
            {
                Console.WriteLine("O pneu está estourado!");
                return;
            }

            if (Furado == true)
            {
                Console.WriteLine("O pneu está furado!");
                return;
            }

            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha = PercentualBorracha - 3;

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <= 30) 
            {
                EstourarPneu();
            }

        }

        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }

            if (PercentualBorracha < 0)
            {
                PercentualBorracha = 0; 
            }

            if (PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
        }

        private void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Percentual Borracha: " + PercentualBorracha);
            Console.WriteLine("TWI: " + TWI);
            Console.WriteLine("Estepe: " + Estepe);
        }
    }
}