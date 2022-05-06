using System;

namespace aula10_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            var nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Olá "+nome);
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
