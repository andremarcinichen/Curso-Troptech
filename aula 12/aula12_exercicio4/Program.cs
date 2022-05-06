using System;

namespace aula12_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            var resultado = num1>=18;
            Console.WriteLine("Marior de idade:"+resultado);
        }
    }
}
