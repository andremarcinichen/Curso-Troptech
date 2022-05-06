using System;

namespace aula17_exercicio5
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
                

            }
            
            for (int i = 0; i < tamanhoVetores; i++)
            {
                if(vetorA[i]%2==0){
                    vetorB[posicao]=vetorA[i] ;
                    total+=vetorB[posicao];
                    posicao++;
                }

            }
            double media =(double) total/posicao;

            Console.WriteLine($"A média aritmética é :{media}");
            for (int j = 0; j < posicao; j++)
            {
                Console.Write($"{vetorB[j]} ");
            }
        }
    }
}
