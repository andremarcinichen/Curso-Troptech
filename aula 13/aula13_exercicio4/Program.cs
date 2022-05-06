using System;

namespace aula13_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sua idade:");
            var idade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tempo de serviço:");
            var tempo = Convert.ToDouble(Console.ReadLine());
            if(idade>=65 ){
                Console.WriteLine("Pode se aposentar");
            }else if(tempo>=30 ){
                Console.WriteLine("Pode se aposentar");
            }else if(idade>=60 && tempo>=25 ){
                Console.WriteLine("Pode se aposentar");
            }else{
                Console.WriteLine("Não pode se aposentar");
            }
        }
    }
}
