using System;

namespace aula16_exercicio4
{
    class Program
    {   
        //removi espaçamentos
        // bt para baseTriangulo
        // at para alturaTriangulo
        // s para area
        //ajuste na respota final
        static void Main(string[] args)
        {
            Console.Write("Digite a medida em cm da base do triângulo: ");
            var baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a medida em cm da altura do triângulo: ");
            var alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            var area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("A área do triângulo é: " + area);
        }
    }
}

