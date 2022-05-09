using System;

namespace aula20_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantidade de trabalhadores");
            int iteracoes = Convert.ToInt16(Console.ReadLine());
            string[] nome = new string[iteracoes];
            string[] idade = new string[iteracoes];
            string[] tempoDeTrabalho = new string[iteracoes];
            string[] situacao = new string[iteracoes];
            string[,] trabalhadores = new string[iteracoes, 4];
            for (int i = 0; i < iteracoes; i++)
            {
                Console.WriteLine("Informe o nome do trabalhador");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe a idade do trabalhador");
                idade[i] = Console.ReadLine();
                Console.WriteLine("Informe quantidade de tempo de trabalho");
                tempoDeTrabalho[i] = Console.ReadLine();
                if (Convert.ToInt16(idade[i]) > 65 || Convert.ToInt16(tempoDeTrabalho[i]) > 30 || (Convert.ToInt16(idade[i]) > 60 && Convert.ToInt16(tempoDeTrabalho[i]) > 25))
                {
                    situacao[i] = "Sim";
                }else{
                    situacao[i] = "Não";
                }

                trabalhadores[i, 0] = nome[i];
                trabalhadores[i, 1] = idade[i];
                trabalhadores[i, 2] = tempoDeTrabalho[i];
                trabalhadores[i, 3] = situacao[i];
            }

            Console.WriteLine("Impressão da Lista");
            Console.WriteLine("Nome         idade   tempo  situação");
            for(int i = 0; i < iteracoes; i++){
                Console.WriteLine($"{trabalhadores[i, 0]}    {trabalhadores[i, 1]}    {trabalhadores[i, 2]}    {trabalhadores[i, 3]} ");
            }



        }
    }
}
