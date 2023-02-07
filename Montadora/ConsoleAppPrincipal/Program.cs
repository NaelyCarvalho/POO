using Models;
using System.Reflection.PortableExecutable;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pneu pneu1 = new Pneu( 16, "Carro de passeio", "Firestone", false, 150);

            // Pneu pneu2 = new Pneu(16, "Pneu de estepe", "Firestone", true, 70);

            Console.WriteLine();

            Carro BMW = new Carro("BMW", "BMW I3", "ABC1J23", 2014, 120);


            BMW.Abastecer(80);
            BMW.Ligar();
            BMW.Acelerar(15);
            BMW.Acelerar(5);
            BMW.Acelerar(22);
            BMW.Frear(8);
            BMW.Acelerar(3);
            BMW.Frear(4);
            BMW.Desligar();
            BMW.PneuDianteiroEsquerdo = BMW.PneuEstepe;
            BMW.Ligar();
            BMW.Acelerar(15);
            BMW.Acelerar(5);
            BMW.Acelerar(22);
            BMW.Frear(8);
            BMW.Acelerar(3);
            BMW.Acelerar(3);
            BMW.Acelerar(3);
            BMW.Acelerar(3);
            BMW.Frear(4);
            BMW.Abastecer(80);
            BMW.Ligar();
            BMW.Acelerar(40);
            BMW.Acelerar(29);
            BMW.Acelerar(1);
            BMW.Acelerar(1);
            BMW.Exibir();
        }
    }
}