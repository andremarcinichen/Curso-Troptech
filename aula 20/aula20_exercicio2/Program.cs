using System;

namespace aula20_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantidade de produtos");
            int iteracoes = Convert.ToInt16(Console.ReadLine());
            string[] nome = new string[iteracoes];
            int[] codigo = new int[iteracoes];
            string[] classificacao = new string[iteracoes];
            string[,] Produtos = new string[iteracoes, 2];
            for (int i = 0; i < iteracoes; i++)
            {
                Console.WriteLine("Informe o nome do Produto");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe o codigo do produto");
                codigo[i] = Convert.ToInt16(Console.ReadLine());
                switch (codigo[i])
                {
                    case 1: 
                        classificacao[i] = "Alimento não perecivel";
                        break;
                    case 2:
                        classificacao[i] = "Alimento perecivel";
                        break;
                    case 3:
                        classificacao[i] = "Alimento perecivel";
                        break;
                    case 4:
                        classificacao[i] = "Alimento perecivel";
                        break;
                    case 5:
                        classificacao[i] = "vestuario";
                        break;
                    case 6:
                        classificacao[i] = "vestuario";
                        break;
                    case 7:
                        classificacao[i] = "higiene pessoal";
                        break;
                    case 8:
                        classificacao[i] = "utensilio domestico";
                        break;
                    case 9:
                        classificacao[i] = "utensilio domestico";
                        break;
                    case 10:
                        classificacao[i] = "utensilio domestico";
                        break;
                    default:
                        classificacao[i] = "codigo invalido";
                        break;
                }
                Produtos[i, 0] = nome[i];
                Produtos[i, 1] = classificacao[i];
            }

            Console.WriteLine("Impressão da Lista");
            Console.WriteLine("Nome do produto         Classificacao");
            for (int i = 0; i < iteracoes; i++)
            {
                Console.WriteLine($"{Produtos[i, 0]}    {Produtos[i, 1]} ");
            }
        }
    }
}
