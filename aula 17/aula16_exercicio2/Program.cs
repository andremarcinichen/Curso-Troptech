using System;

namespace aula16_exercicio2
{
    class Program
    {

        //Faltou a letra P em public
        // adorei alt+shift +f
        // nao usar in como variavel
        // f para fim in para inicio e t para tabuada
        // Precisar conveter i para iteração? fica o questionamento!
        public static void Main()
        {
            Console.WriteLine("Descubra a tabuada!");
            Console.Write("Qual tabuada você gostaria de consultar (1 a 10): ");
            var tabuada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual é o número de inicio: ");
            var inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual é o número de fim: ");
            var fim = Convert.ToInt32(Console.ReadLine());

            if (tabuada > 10 || tabuada < 1)
            {
                Console.WriteLine("Valor inválido, tente novamente.");
                return;
            }

            for (var i =inicio; i <= fim; i++)
            {
                Console.WriteLine(tabuada + " x " + i + " = " + i * tabuada);
            }
        }
    }
}
