using System;

namespace aula17_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetores:");
            int tamanhoVetores = Convert.ToInt32(Console.ReadLine());
            int[] vetorA = new int[tamanhoVetores];
            int total=0;
            int[] vetorB = new int[tamanhoVetores];
            int posicao=0;
            //int[] vetorC = new int[tamanhoVetores];
            for (int i = 0; i < tamanhoVetores; i++)
            {
                Console.WriteLine($"Digite o valor do vetor A na posição {i + 1} :");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
                total+=vetorA[i];

            }
            double media =(double) total/tamanhoVetores;
            for (int i = 0; i < tamanhoVetores; i++)
            {
                if(vetorA[i]<media){
                    vetorB[posicao]=vetorA[i] ;
                    posicao++;
                }

            }

            Console.WriteLine($"A média aritmética é :{media}");
            for (int j = 0; j < posicao; j++)
            {
                Console.Write($"{vetorB[j]} ");
            }
        }
    }
}
