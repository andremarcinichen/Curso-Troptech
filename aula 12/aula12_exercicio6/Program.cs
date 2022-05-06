using System;

namespace aula12_exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            var resultado1 = num1;
             Console.WriteLine(resultado1+=2);
            var resultado2 = num1;
             Console.WriteLine(resultado2-=2);
            var resultado3 = num1;
             Console.WriteLine(resultado3*=2);
            var resultado4 = num1;
            Console.WriteLine(resultado4/=2);
        }
    }
}
