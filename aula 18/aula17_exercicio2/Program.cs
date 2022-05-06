using System;

namespace aula17_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor:");
            int tamanhoVetor = Convert.ToInt32(Console.ReadLine()), posicao = 0;
            int[] vetor = new int[tamanhoVetor];
            int[] vetor_par = new int[tamanhoVetor];
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($"Digite o valor na posição {i + 1} :");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                if (vetor[i]%2==0)
                {
                    vetor_par[posicao] = vetor[i];
                    posicao ++;
                }
            }
            Console.WriteLine($"Os numeros pares são:");
            for (int j = 0; j < posicao; j++)
            {
                Console.Write($"{vetor_par[j]} ");
            }
            Console.Write($"\n");
            Console.WriteLine($"A Quantidade é {posicao}");


        }
    }
}
