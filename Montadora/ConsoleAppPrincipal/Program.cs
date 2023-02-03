using Models;
using System.Reflection.PortableExecutable;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu( 16, "Carro de passeio", "Firestone", false, 150);

            pneu1.Girar(5);
            pneu1.Exibir();

            Console.WriteLine();

            Pneu pneu2 = new Pneu(16, "Pneu de estepe", "Firestone", true, 70);

            pneu2.Girar(5);
            pneu2.Exibir();

        }
    }
}