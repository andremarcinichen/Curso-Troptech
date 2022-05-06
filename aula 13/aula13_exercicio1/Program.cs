using System;

namespace aula13_exercicio1
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
            if(codigo==1){
                Console.WriteLine("Alimento não-perecível");
            }else if(codigo==2||codigo==3||codigo==4){
                Console.WriteLine("Alimento perecível");
            }else if(codigo==5||codigo==6){
                Console.WriteLine("Vestuário");
            }else if(codigo==7){
                Console.WriteLine("Higiene pessoal");
            }else if(codigo==8||codigo==9||codigo==10){
                Console.WriteLine("Utensílios domésticos");
            }else {
                Console.WriteLine("código Inválido");
            }
        }
    }
}
