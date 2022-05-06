using System;

namespace aula13_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do produto:");
            // 1 - Alimento não-perecível
            // 2, 3 ou 4 - Alimento perecível
            // 5 ou 6 - Vestuário
            // 7 - Higiene pessoal
            // 8, 9, 10 - Utensílios domésticos
            // Qualquer outro código Inválido
            var codigo = Convert.ToInt32(Console.ReadLine());
            switch (codigo)
            {
                case  1:
                    Console.WriteLine("Alimento não-perecível");
                    break;
                case  2:
                case  3:
                case  4:
                    Console.WriteLine("Alimento perecível");
                    break;
                case  5:
                case  6:
                    Console.WriteLine("Vestuário");
                    break;
                case  7:
                    Console.WriteLine("Higiene pessoal");
                    break;
                case  8:
                case  9:
                case  10:
                    Console.WriteLine("Utensílios domésticos");
                    break;
                default:
                    Console.WriteLine("código Inválido");
                break;
            }

            // if(codigo==1){
            //     Console.WriteLine("Alimento não-perecível");
            // }else if(codigo==2||codigo==3||codigo==4){
            //     Console.WriteLine("Alimento perecível");
            // }else if(codigo==5||codigo==6){
            //     Console.WriteLine("Vestuário");
            // }else if(codigo==7){
            //     Console.WriteLine("Higiene pessoal");
            // }else if(codigo==8||codigo==9||codigo==10){
            //     Console.WriteLine("Utensílios domésticos");
            // }else {
            //     Console.WriteLine("código Inválido");
            // }
        }
    }
}
