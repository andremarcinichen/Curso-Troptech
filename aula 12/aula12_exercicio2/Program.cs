using System;

namespace aula12_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado do triangulo:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            var resultado = ((num1*num1*Math.Pow(3,0.5))/4);
            Console.WriteLine("area:"+resultado);

        }
    }
}
