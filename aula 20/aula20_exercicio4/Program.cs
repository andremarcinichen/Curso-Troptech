using System;

namespace aula20_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 1, i=0;
            int[] valor = new int[tamanho];
            while (true)
            {
                if (i==tamanho)
                {
                    tamanho*=2;
                    int[] teste = new int[tamanho];
                    for (int j = 0; j < i; j++)
                    {
                        teste[j]=valor[j];
                    }
                    valor=teste;
                }

                Console.WriteLine("escreva um valor");
                valor[i] = Convert.ToInt16(Console.ReadLine());

                Console.Write("vetor:");
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(valor[j]+" ");
                }
                Console.WriteLine(" ");
                i++;
                
            }
        }
    }
}
