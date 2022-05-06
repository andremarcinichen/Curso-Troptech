using System;

namespace aula16_exercicio3
{
    class Program
    {
        //removi espaçamentos
        // juntei os int e double 
        // mSal para maiorSalario
        // s para salario 
        // f para quantidadeDeFilhos
        // qtdF quantidadeToltalDeFilhos
        // sSal somaSalarios
        // qtp quantidadeDePessoas
        //qtdP100 quantidadeDePessoasAte100
        public static void Main()
        {

            int quantidadeDePessoas = 0, quantidadeDePessoasAte100 = 0, quantidadeToltalDeFilhos = 0;
            double maiorSalario = 0, somaSalarios = 0, salario = 0;

            while (salario >= 0)
            {
                Console.Write("Salário: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if (salario >= 0)
                {
                    Console.Write("Quantidade de filhos: ");
                    var quantidadeDeFilhos = Convert.ToInt32(Console.ReadLine());
                    somaSalarios += salario;
                    quantidadeToltalDeFilhos += quantidadeDeFilhos;
                    quantidadeDePessoas++;
                    if (salario > salario)//verifica maior salario
                    {
                        maiorSalario = salario;
                    }
                    if (salario <= 100)//verifica salarios menores que 100
                    {
                        quantidadeDePessoasAte100++;
                    }
                }
            }
            var mediaSalarioPopulacao = somaSalarios / quantidadeDePessoas;
            Console.WriteLine("Média salarial da população: R$" + mediaSalarioPopulacao);
            // faz cast para double para pegar número quebrado na divisão.
            var mediaNumeroFilhos = (double)quantidadeToltalDeFilhos / quantidadeDePessoas;
            Console.WriteLine("Média número de filhos: " + mediaNumeroFilhos);
            Console.WriteLine("Maior salário: " + maiorSalario);
            var percentualPessoasComSalarioAte100 = (quantidadeDePessoasAte100 * 100) / quantidadeDePessoas;
            Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualPessoasComSalarioAte100 + "%");
        }
    }
}

