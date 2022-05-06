using System;

namespace aula11_exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fale uma fruta");
            var fruta =Console.ReadLine();
            Console.WriteLine("Sua cor");
            var cor =Console.ReadLine();
            Console.WriteLine("Sua principal caracteristica");
            var caracteristica =Console.ReadLine();
            Console.WriteLine(fruta+ " é uma fruta de cor " + cor + " e " + caracteristica);


        }
    }
}
