using System;

namespace aula12_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor decimal:");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor decimal:");
            var num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("soma:"+(num1+num2));
            Console.WriteLine("subtração:"+(num1-num2));
            Console.WriteLine("divisao:"+(num1/num2));
            Console.WriteLine("multiplicacao:"+(num1*num2));
        }
    }
}
