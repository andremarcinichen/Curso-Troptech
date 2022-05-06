using System;

namespace aula19_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = "";
            frase = Console.ReadLine();

            int i = 0, palavras = 1;
            int asc = 0, validaAscProximaIteracao = 0;
            do
            {
                asc = frase[i];
                if ((i + 1) < frase.Length)
                {
                    validaAscProximaIteracao = frase[i + 1];
                }
                else
                {
                    validaAscProximaIteracao = 0;
                }

                if (asc == 32 && (validaAscProximaIteracao != 0))
                {
                    palavras++;
                }
                i++;
            } while (i < frase.Length);
            Console.WriteLine($"total de palavras:{palavras}");

        }
    }
}
