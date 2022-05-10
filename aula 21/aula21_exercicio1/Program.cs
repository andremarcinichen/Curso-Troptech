using System;

namespace aula21_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Agenda = new string[10, 3];

            Console.WriteLine("Vamos digitar os contatos da sua agenda.");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Digite o nome");
                Agenda[i, 0] = Console.ReadLine();
                Console.WriteLine("Digite a profissão");
                Agenda[i, 1] = Console.ReadLine();
                Console.WriteLine("Digite o endereço");
                Agenda[i, 2] = Console.ReadLine();


            }

            for (int i = 0; i < 10; i++)
            {

                Console.Write($"O contato de numero {i+1} se chama {Agenda[i, 0]}.");
                Console.WriteLine($"A profissão é {Agenda[i, 1]}, e seu endereço é {Agenda[i, 2]}.");

            }

            Console.ReadLine();
        }
    }
}
