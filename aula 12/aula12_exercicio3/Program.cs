using System;

namespace aula12_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1 do triangulo:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o lado 2 do triangulo:");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o lado 3 do triangulo:");
            float num3 = Convert.ToSingle(Console.ReadLine());
            var resultado1 = num1==num2 && num1==num3;
            var resultado2 = num1!=num2 && num1!=num3;
            var resultado3 = num1==num2 || num1==num3;

            Console.WriteLine("Equilatero:"+resultado1);
            Console.WriteLine("Escaleno:"+resultado2);
            Console.WriteLine("Isoceles:"+resultado3);
        }
    }
}
