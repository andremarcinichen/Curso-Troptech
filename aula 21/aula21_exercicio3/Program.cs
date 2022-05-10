using System;

namespace aula21_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matriz_resultado = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite o elemento linha {i + 1} e coluna {j + 1} da matriz 1");
                    matriz1[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite o elemento linha {i + 1} e coluna {j + 1} da matriz 2");
                    matriz2[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz_resultado[i, j]=matriz1[i, j]+matriz2[i, j];
                    Console.Write($"{matriz_resultado[i, j]} ");
                }
                Console.Write($"\n");

            }
        }
    }
}
