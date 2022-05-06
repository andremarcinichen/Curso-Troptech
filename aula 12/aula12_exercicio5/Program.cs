using System;

namespace aula12_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            var resultado = num1*2+1;
            Console.WriteLine(resultado);
        }
    }
}
