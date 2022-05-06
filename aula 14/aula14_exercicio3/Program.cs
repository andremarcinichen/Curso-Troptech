using System;

namespace aula14_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var maior = 0;
            var menor = 0;
            for(var i=0;i<50;i++){
                Console.WriteLine("Informe o valor que deseja");
                var numero = Convert.ToInt16(Console.ReadLine());
                if(i==0){
                    maior=numero;
                    menor=numero;
                }
                if(maior<numero){
                    maior=numero;
                }
                if(menor>numero){
                    menor=numero;
                }
            }
            Console.WriteLine($"o maior foi:{maior} e o menor foi:{menor}");
        }
    }
}