using System;

namespace aula15_exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {    
                    int total = i*j;
                    if(j<10){
                        if(i<10){
                            if(total<10){
                                Console.Write($"{j}*{i}={total}   ");
                            }else{
                                Console.Write($"{j}*{i}={total}  ");
                            }
                        }else{
                            Console.Write($"{j}*{i}={total} ");
                        }
                    }else{
                        Console.WriteLine($"{j}*{i}={total}");
                    }
                }
            }
        }
    }
}
