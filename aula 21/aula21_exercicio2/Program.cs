using System;

namespace aula21_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 6];
            int totalsoma = 0, contador = 0, media = 0;
            Console.WriteLine("Vamos digitar os contatos da sua agenda.");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Digite o elemento linha {i + 1} e coluna {j + 1}");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }

            for (int j = 1; j < 6; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    totalsoma += matriz[i, j];

                }

            }
            Console.WriteLine($"a) Resposta {totalsoma}");
            totalsoma = 0;
            for (int j = 1; j < 4; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    contador++;
                    totalsoma += matriz[i, j];

                }

            }
            media = totalsoma / contador;

            Console.WriteLine($"b) Resposta {media}");
            for (int i = 0; i < 3; i += 1)
            {
                for (int j = 0; j < 6; j++)
                {
                    matriz[i, 5] = matriz[i, 0] + matriz[i, 2];
                }

            }
            Console.WriteLine($"c/d) Resposta:");
            for (int i = 0; i < 3; i += 1)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{matriz[i, j]}");

                }
                Console.Write($"\n");

            }







        }
    }
}
