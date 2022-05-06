using System;

namespace aula11_exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInteiro = 1; 
            decimal resposta1= decimal.Parse(numeroInteiro);
            decimal numeroDecimal = 2.5m; 
            int resposta2 = Convert.ToInt32(numeroDecimal); 
            string numeroEmString = "7"; 
            int resposta3= Convert.ToInt32(numeroEmString);
            decimal resposta4= decimal.Parse(numeroEmString);
            double numeroDouble = 3.7; 
            decimal resposta5= decimal.Parse(numeroDouble);
        }
    }
}
