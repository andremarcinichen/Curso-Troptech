using System;

namespace aula19_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "";
            Console.WriteLine("Digite sua Senha:");
            senha = Console.ReadLine();
            int tamanhoSenha = senha.Length;
            int contadorLetrasMinusculas = 0, contadorLetrasMaiusculas = 0, contadorNumeros = 0, contadorCaracterEspecial = 0;
            int digito = 0;
            for (int i = 0; i < tamanhoSenha; i++)
            {
                digito = senha[i];
                if (digito <=47)
                {
                    contadorCaracterEspecial++;
                }
                if (digito >= 48 && digito <= 57)
                {
                    contadorNumeros++;
                }
                if (digito >= 58 && digito <= 64)
                {
                    contadorCaracterEspecial++;
                }
                if (digito >= 65 && digito <= 90)
                {
                    contadorLetrasMaiusculas++;
                }
                if (digito >= 91 && digito <= 96)
                {
                    contadorCaracterEspecial++;
                }
                if (digito >= 97 && digito <= 122)
                {
                    contadorLetrasMinusculas++;
                }
                if (digito >= 123 && digito <= 127)
                {
                    contadorCaracterEspecial++;
                }
            }
            Console.WriteLine($"Quantidade de numeros:{contadorNumeros}");
            Console.WriteLine($"Quantidade de caracteres especiais:{contadorCaracterEspecial}");
            Console.WriteLine($"Quantidade de letras maiusculas:{contadorLetrasMaiusculas}");
            Console.WriteLine($"Quantidade de letras minusculas:{contadorLetrasMinusculas}");

        }
    }
}
