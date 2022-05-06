using System;

namespace aula17_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetores:");
            int tamanhoVetores = Convert.ToInt32(Console.ReadLine());
            int[] vetorA = new int[tamanhoVetores];
            int[] vetorB = new int[tamanhoVetores];
            int[] vetorC = new int[tamanhoVetores];
            for (int i = 0; i < tamanhoVetores; i++)
            {
                Console.WriteLine($"Digite o valor do vetor A na posição {i + 1} :");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < tamanhoVetores; i++)
            {
                Console.WriteLine($"Digite o valor do vetor B na posição {i + 1} :");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < tamanhoVetores; i++)
            {
                vetorC[i] = vetorB[i] + vetorA[i];

            }

            Console.WriteLine($"Os numeros do vetor C são:");
            for (int j = 0; j < tamanhoVetores; j++)
            {
                Console.Write($"{vetorC[j]} ");
            }
        }
    }
}
