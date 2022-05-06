using System;

namespace aula13_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de pagamento do produto:");
            var valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o condição de pagamento do produto:");
            var codigo = Convert.ToDouble(Console.ReadLine());
            Console.Write("valor:");
            switch (codigo)
            {
                case  1:
                    Console.WriteLine((valor*=0.9));
                    break;
                case  2:
                    Console.WriteLine((valor*=0.95));
                    break;
                case  3:
                    Console.WriteLine(valor);
                    break;
                case  4:
                    Console.WriteLine((valor*=1.1));
                    break;
                default:
                    Console.WriteLine("código Inválido");
                break;
            }
        }
    }
}
