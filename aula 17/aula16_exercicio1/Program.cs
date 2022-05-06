using System;

namespace aula16_exercicio1
{
    class Program
    {
        // ajustes horizontais e verticais de espaçamento
        // troquei p por Nota
        // n1 por numeroRandomico1
        // n2 por numeroRandomico2
        // r por resposta 

        static void Main(string[] args)
        {
            var Nota = 0;
            while (Nota < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    var numeroRandomico1 = new Random().Next(1, 10);
                    var numeroRandomico2 = new Random().Next(1, 10);
                    Console.WriteLine(numeroRandomico1 + " x " + numeroRandomico2 + "? ");
                    var resposta = Convert.ToInt32(Console.ReadLine());
                    if (resposta == numeroRandomico1 * numeroRandomico2)
                    {
                        Console.WriteLine("Resposta Correta!");
                        Nota++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorreto!!! A resposta é: {numeroRandomico1 * numeroRandomico2}");
                    }
                }
                Console.WriteLine("Sua pontuação é: " + Nota + "/10");
                if (Nota == 10)
                    Console.WriteLine("Parabéns, você sabe a tabuada decor e salteado!");
                else
                    Console.WriteLine("Você precisa estudar mais! Vamos tentar novamente!");
            }

        }
    }

}

