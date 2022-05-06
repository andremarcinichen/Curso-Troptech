using System;

namespace aula14_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_total = 0;
            int populacao_total = 0;
            double salario_maior=0;
            int iteracao =0;
            double salario =0;
            int pessoas_com_menor_de_cem =0;
            do{
                Console.WriteLine("Informe o salario");
                salario = Convert.ToDouble(Console.ReadLine());
                if(salario>=0){
                    salario_total += salario;
                    Console.WriteLine("Informe o numero de filhos");
                    int populacao = Convert.ToInt32(Console.ReadLine());
                    populacao_total += populacao;
                    if(salario_maior==0){
                        salario_maior=salario;
                    }
                    if(salario_maior<salario){
                        salario_maior=salario;
                    }
                    if(salario<=100){
                        pessoas_com_menor_de_cem++;
                    }
                    iteracao++;
                }
            // Console.Write($"iteracao: {iteracao}. ");//a
            // Console.Write($"pessoas_com_menor_de_cem: {pessoas_com_menor_de_cem}. ");//a
            }while(salario>=0);
            double media_salario = salario_total/iteracao;
            double media_filhos = populacao_total/iteracao;
            double percentual=0;
            if(pessoas_com_menor_de_cem>0){
                double calc_parte1 = (iteracao - pessoas_com_menor_de_cem );
                double calc_parte2 =  ( calc_parte1 / iteracao);
                // Console.Write($"teste1: {calc_parte1}.teste2: {calc_parte2}. ");//a
                percentual = (calc_parte2-1)*(-100);
            }else{
                percentual=0;
            }
            Console.Write($"A média do salario da pop foi: {media_salario}. ");//a
            Console.Write($"A média de filhos da pop foi: {media_filhos}. ");//b
            Console.Write($"O maior salario  da pop foi: {salario_maior}. ");//c
            Console.Write($"O percentual de pessoas com salario de até 100 foi : {percentual}%. ");//d
        }
    }
}
