using System;

namespace aula15_exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Informe o número de semanas estudadas.");
            int semanas= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Informe o número de dias estudados por semana.");
            int dias= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=semanas; i++)
            {
                Console.WriteLine($"Semana:{i}");
                for (int j = 1; j <=dias; j++)
                {    
                    Console.WriteLine($" Dias: {j}");
                }
            }
            int total  = dias*semanas;
            Console.WriteLine($"Você estudou: {total} dia(s)");
        }
    }
}
