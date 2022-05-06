using System;

namespace aula14_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor que deseja a tabuada");
            var numero = Convert.ToInt16(Console.ReadLine());
            for(var i=1;i<=10;i++){
                var calc = i*numero;
                Console.WriteLine($"{i} x {numero}= {calc}");
            }
            
        }
    }
}
