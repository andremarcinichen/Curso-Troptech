using System;

namespace aula21_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[4, 4];
            int menor_valor = 0, maior_valor = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.WriteLine($"Digite o elemento linha {i + 1} e coluna {j + 1} da matriz 1");
                    matriz1[i, j] = Convert.ToInt16(Console.ReadLine());
                    if (i == 0 && j == 0)
                    {
                        menor_valor = matriz1[i, j];
                        maior_valor = matriz1[i, j];

                    }
                    if (menor_valor > matriz1[i, j])
                    {
                        menor_valor = matriz1[i, j];

                    }
                    if (maior_valor < matriz1[i, j])
                    {
                        maior_valor = matriz1[i, j];

                    }
                }
            }
            Console.WriteLine($"Menor valor: {menor_valor} e o maior valor: {maior_valor} ");
        }
    }
}
