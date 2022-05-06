using System;

namespace aula11_exercicio04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha um caractere");
            char caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("      "+caracter);//1
            Console.WriteLine("     "+caracter+caracter+caracter);//3
            Console.WriteLine("    "+caracter+caracter+caracter+caracter+caracter);//5
            Console.WriteLine("   "+caracter+caracter+caracter+caracter+caracter+caracter+caracter);//7
            Console.WriteLine("  "+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter);//9
            Console.WriteLine(" "+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter);//11
            Console.WriteLine(""+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter+caracter);//13
        }
    }
}
