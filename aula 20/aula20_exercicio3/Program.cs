using System;

namespace aula20_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantidade de produtos");
            int iteracoes = Convert.ToInt16(Console.ReadLine());
            string[] nome = new string[iteracoes];
            double[] precoProduto = new double[iteracoes];
            string[] opcao1 = new string[iteracoes];
            string[] opcao2 = new string[iteracoes];
            string[] opcao3 = new string[iteracoes];
            string[] opcao4 = new string[iteracoes];
            string[,] Produtos = new string[iteracoes, 6];
            for (int i = 0; i < iteracoes; i++)
            {
                Console.WriteLine("Informe o nome do produto");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe o valor do produto");
                precoProduto[i] = Convert.ToDouble(Console.ReadLine());
                opcao1[i] = Convert.ToString((double)precoProduto[i] * 0.9);
                opcao2[i] = Convert.ToString((double)precoProduto[i] * 0.95);
                opcao3[i] = Convert.ToString((double)precoProduto[i]);
                opcao4[i] = Convert.ToString((double)precoProduto[i] * 1.1);
                Produtos[i, 0] = nome[i];
                Produtos[i, 1] = Convert.ToString(precoProduto[i]);
                Produtos[i, 2] = opcao1[i];
                Produtos[i, 3] = opcao2[i];
                Produtos[i, 4] = opcao3[i];
                Produtos[i, 5] = opcao4[i];
            }

            Console.WriteLine("Impressão da Lista");
            Console.WriteLine("Nome         preço    opção 1  opção 2  opção 3  opção 4");
            for (int i = 0; i < iteracoes; i++)
            {
                Console.WriteLine($"{Produtos[i, 0]}    {Produtos[i, 1]}    {Produtos[i, 2]}    {Produtos[i, 3]}  {Produtos[i, 4]}  {Produtos[i, 5]} ");
            }
        }
    }
}
