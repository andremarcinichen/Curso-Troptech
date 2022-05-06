using System;

namespace aula14_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor que deseja a tabuada");
            var numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe o valor de inicio");
            var inicio = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe o valor de fim");
            var fim = Convert.ToInt16(Console.ReadLine());
            for(var i=inicio;i<=fim;i++){
                var calc = i*numero;
                Console.WriteLine($"{i} x {numero}= {calc}");
            }
            
        }
    }
}
