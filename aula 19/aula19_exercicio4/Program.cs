using System;
using System.Text.RegularExpressions;

namespace aula19_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = "";
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra:");
            string palavra1 = "";
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite outra palavra:");
            string palavra2 = "";
            palavra2 = Console.ReadLine();
            Console.WriteLine("Digite a terceira e ultima palavra:");
            string palavra3 = "";
            palavra3 = Console.ReadLine();
            string[] palavras = { palavra1, palavra2, palavra3 };
            string[] palavrasDaFrase = new string[10];
            int i = 0, divisorPalavra = 0, totalDePalavras = 0, digitoComEspaco = 0;
            int asc = 0;
            string palavraRecebida = "";
            frase = frase.Replace(",","");
            while (i < frase.Length)
            {
                asc = frase[i];
                //em cada espaçamento ele vai adicionar uma palavra ao vetor palavras da frase
                if (asc == 32 || i == frase.Length - 1)
                {
                    palavraRecebida = "";
                    if (i == frase.Length - 1)
                    {
                        i++;
                    }

                    for (int j = digitoComEspaco; j < i; j++)
                    {
                        palavraRecebida += frase[j];
                    }
                    palavrasDaFrase[divisorPalavra] = palavraRecebida;
                    divisorPalavra++;
                    digitoComEspaco = i + 1;
                }
                i++;
            }

            // aqui verificamos vetor palavrasDaFrase se vai ser igual as palavras escolhidas.
            foreach (var item in palavrasDaFrase)
            {
                if (item == palavra1 || item == palavra2 || item == palavra3)
                {
                    totalDePalavras++;
                }
            }
            //Console.WriteLine($"{frase}");
            Console.WriteLine($"{totalDePalavras}");
        }
    }
}
