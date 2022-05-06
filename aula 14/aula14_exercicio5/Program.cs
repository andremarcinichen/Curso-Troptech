using System;

namespace aula14_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int Arvore_de_natal=5;
            for(var i=0;i<=Arvore_de_natal;i++){
                for(var j=(Arvore_de_natal-i);j>=0;j--){
                    Console.Write(" ");
                }
                for(var j=0;j<=(2*i+1);j++){
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
