using System;

namespace aula15_exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
            do{
            Console.WriteLine("Vamos treinar a tabuada!");
            for (int i = 1; i < 11; i++)
            {
                Random rnd = new Random();
                int num1 = rnd.Next(1,20);
                int num2 = rnd.Next(1,20);
                int Resposta = num1*num2;
                Console.WriteLine($"Pergunta numero {i} quanto é { num1} x {num2}?");
                int resposta_do_user= Convert.ToInt32(Console.ReadLine());
                if(Resposta==resposta_do_user){
                    contador++;
                    Console.WriteLine($"Acertou! total de respostas corretas:{contador}");
                }else{
                    Console.WriteLine($"Resposta correta seria: {Resposta}");
                }
            }
            if(contador==10){
                Console.WriteLine($"Parabens você acertou todas!");
            }else{
                Console.WriteLine($"Tente novamente!");
            }
            }while(contador!=10);
        }
    }
}
