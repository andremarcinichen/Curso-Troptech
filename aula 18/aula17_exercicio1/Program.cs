using System;

namespace aula17_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor:");
            int tamanhoVetor = Convert.ToInt32(Console.ReadLine()), posicao = 0;
            double[] vetor = new double[tamanhoVetor];
            double maiorValor = 0;
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($"Digite o valor na posição {i + 1} :");
                vetor[i] = Convert.ToDouble(Console.ReadLine());
                if (maiorValor < vetor[i])
                {
                    maiorValor = vetor[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"O maior valor é {maiorValor}");
            Console.WriteLine($"A sua posição é {posicao}");


        }
    }
}
