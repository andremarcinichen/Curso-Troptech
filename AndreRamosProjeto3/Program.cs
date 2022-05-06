using System;

namespace AndreRamosProjeto3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Sair = false, Acesso = false, Menu_soma = false, Menu_sub = false, Menu_div = false, Menu_mult = false, Operacao = false;
            string Login = "aluno", Senha = "123456";
            int Tentativa_de_login = 0;

            //inicialização da calculadora
            Console.Clear();
            Console.WriteLine("Seja bem vindo a Calculadora interativa!");
            Console.WriteLine("Vamos começar fazer o login!");
            do
            {
                //intro Login
                for (int i = 0; i < 14; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Login ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("-");
                }
                Console.Write("\n");

                //incialização do Login
                Console.WriteLine("Digite seu Login:");
                string Login_digitado = Console.ReadLine();
                Console.WriteLine("Digite sua Senha:");
                string Senha_digitada = Console.ReadLine();

                //Validação do Login
                if (Login_digitado == Login && Senha_digitada == Senha)
                {
                    Console.Clear();
                    Acesso = true;
                    Console.WriteLine("Acesso Liberado!");
                }
                else if (Login_digitado != Login && Senha_digitada == Senha)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Login incorreto");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tentativa_de_login++;
                    if (Tentativa_de_login != 3)
                    {
                        Console.WriteLine("Tente Novamente!");
                    }
                }
                else if (Login_digitado == Login && Senha_digitada != Senha)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Senha incorreta");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tentativa_de_login++;
                    if (Tentativa_de_login != 3)
                    {
                        Console.WriteLine("Tente Novamente!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Login e Senha incorretos");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tentativa_de_login++;
                    if (Tentativa_de_login != 3)
                    {
                        Console.WriteLine("Tente Novamente!");
                    }
                }
                if (Tentativa_de_login == 3)
                {
                    Sair = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero de tentativas excedido. Calculadora finalizada");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                //Acesso ao Menu principal da calculadora
                if (Acesso == true)
                {
                    Console.WriteLine("Seja bem vindo ao menu principal! ");
                    do
                    {
                        for (int i = 0; i < 34; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("\n");
                        Console.WriteLine($"Usuário: {Login} ");
                        for (int i = 0; i < 14; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write(" MENU ");
                        for (int i = 0; i < 14; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("\n");
                        Console.WriteLine("Escolha algumas das opções abaixo: ");
                        Console.WriteLine("[1] + SOMA");
                        Console.WriteLine("[2] - SUBTRAÇÃO ");
                        Console.WriteLine("[3] / DIVISÃO ");
                        Console.WriteLine("[4] x MULTIPLICAÇÃO");
                        Console.WriteLine("[5] - Sair");

                        //Leitura do comando digitado
                        int Comando_Menu = Convert.ToInt32(Console.ReadLine());
                        switch (Comando_Menu)
                        {
                            case 1:
                                Menu_soma = true;
                                break;
                            case 2:
                                Menu_sub = true;
                                break;
                            case 3:
                                Menu_div = true;
                                break;
                            case 4:
                                Menu_mult = true;
                                break;
                            case 5:
                                Sair = true;
                                break;
                            default:
                                for (int i = 0; i < 7; i++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                    System.Threading.Thread.Sleep(100);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                    System.Threading.Thread.Sleep(100);
                                    Console.Clear();
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }

                        //Entrada dos sub menus

                        //Sub menu soma
                        if (Menu_soma == true)
                        {
                            do
                            {
                                Console.Clear();
                                for (int i = 0; i < 34; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine($"Usuário: {Login} ");
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write(" OPERAÇÃO: + ");
                                for (int i = 0; i < 11; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine("Escolha algumas das opções abaixo: ");
                                Console.WriteLine("[1] - REALIZAR OPERAÇÃO  ");
                                Console.WriteLine("[2] - VOLTAR AO MENU PRINCIPAL ");

                                //Leitura do comando de operação digitado
                                int Comando_menu_operacao = Convert.ToInt32(Console.ReadLine());
                                switch (Comando_menu_operacao)
                                {
                                    case 1:
                                        Operacao = true;
                                        break;
                                    case 2:
                                        Menu_soma = false;
                                        Console.Clear();
                                        break;
                                    default:
                                        for (int i = 0; i < 7; i++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                }

                                //inicio do calculo    
                                if (Operacao == true)
                                {
                                    Console.Clear();
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine($"Usuário: {Login} ");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write(" OPERAÇÃO: + ");
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Digite o primeiro numero: ");
                                    double num1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero: ");
                                    double num2 = Convert.ToDouble(Console.ReadLine());
                                    double total = num1 + num2;
                                    Console.WriteLine($"RESULTADO: {num1} + {num2} = {total} ");
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Pressione ENTER para prosseguir ");
                                    Operacao = false;
                                    Console.ReadLine();
                                }
                            } while (Menu_soma == true);
                        }

                        //Sub menu subtração
                        if (Menu_sub == true)
                        {
                            do
                            {
                                Console.Clear();
                                for (int i = 0; i < 34; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine($"Usuário: {Login} ");
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write(" OPERAÇÃO: - ");
                                for (int i = 0; i < 11; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine("Escolha algumas das opções abaixo: ");
                                Console.WriteLine("[1] - REALIZAR OPERAÇÃO  ");
                                Console.WriteLine("[2] - VOLTAR AO MENU PRINCIPAL ");

                                //Leitura do comando de operação digitado
                                int Comando_menu_operacao = Convert.ToInt32(Console.ReadLine());
                                switch (Comando_menu_operacao)
                                {
                                    case 1:
                                        Operacao = true;
                                        break;
                                    case 2:
                                        Menu_sub = false;
                                        Console.Clear();
                                        break;
                                    default:
                                        for (int i = 0; i < 7; i++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                }

                                //inicio do calculo    
                                if (Operacao == true)
                                {
                                    Console.Clear();
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine($"Usuário: {Login} ");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write(" OPERAÇÃO: - ");
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Digite o primeiro numero: ");
                                    double num1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero: ");
                                    double num2 = Convert.ToDouble(Console.ReadLine());
                                    double total = num1 - num2;
                                    Console.WriteLine($"RESULTADO: {num1} - {num2} = {total} ");
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Pressione ENTER para prosseguir ");
                                    Operacao = false;
                                    Console.ReadLine();
                                }
                            } while (Menu_sub == true);
                        }


                        //Sub menu divisao
                        if (Menu_div == true)
                        {
                            do
                            {
                                Console.Clear();
                                for (int i = 0; i < 34; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine($"Usuário: {Login} ");
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write(" OPERAÇÃO: / ");
                                for (int i = 0; i < 11; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine("Escolha algumas das opções abaixo: ");
                                Console.WriteLine("[1] - REALIZAR OPERAÇÃO  ");
                                Console.WriteLine("[2] - VOLTAR AO MENU PRINCIPAL ");

                                //Leitura do comando de operação digitado
                                int Comando_menu_operacao = Convert.ToInt32(Console.ReadLine());
                                switch (Comando_menu_operacao)
                                {
                                    case 1:
                                        Operacao = true;
                                        break;
                                    case 2:
                                        Menu_div = false;
                                        Console.Clear();
                                        break;
                                    default:
                                        for (int i = 0; i < 7; i++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                }

                                //inicio do calculo    
                                if (Operacao == true)
                                {
                                    Console.Clear();
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine($"Usuário: {Login} ");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write(" OPERAÇÃO: + ");
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Digite o primeiro numero: ");
                                    double num1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero: ");
                                    double num2 = Convert.ToDouble(Console.ReadLine());
                                    if (num2 != 0)
                                    {
                                        double total = num1 / num2;
                                        Console.WriteLine($"RESULTADO: {num1} / {num2} = {total} ");

                                    }
                                    else
                                    {
                                        Console.WriteLine("O segundo valor não pode ser zero ");
                                    }
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Pressione ENTER para prosseguir ");
                                    Operacao = false;
                                    Console.ReadLine();

                                }
                            } while (Menu_div == true);
                        }


                        //Sub menu multiplicacao
                        if (Menu_mult == true)
                        {
                            do
                            {
                                Console.Clear();
                                for (int i = 0; i < 34; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine($"Usuário: {Login} ");
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write(" OPERAÇÃO: x ");
                                for (int i = 0; i < 11; i++)
                                {
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.WriteLine("Escolha algumas das opções abaixo: ");
                                Console.WriteLine("[1] - REALIZAR OPERAÇÃO  ");
                                Console.WriteLine("[2] - VOLTAR AO MENU PRINCIPAL ");

                                //Leitura do comando de operação digitado
                                int Comando_menu_operacao = Convert.ToInt32(Console.ReadLine());
                                switch (Comando_menu_operacao)
                                {
                                    case 1:
                                        Operacao = true;
                                        break;
                                    case 2:
                                        Menu_mult = false;
                                        Console.Clear();
                                        break;
                                    default:
                                        for (int i = 0; i < 7; i++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("ATENÇÃO: Digite um valor válido!");
                                            System.Threading.Thread.Sleep(100);
                                            Console.Clear();
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                }

                                //inicio do calculo    
                                if (Operacao == true)
                                {
                                    Console.Clear();
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine($"Usuário: {Login} ");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write(" OPERAÇÃO: x ");
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Digite o primeiro numero: ");
                                    double num1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero: ");
                                    double num2 = Convert.ToDouble(Console.ReadLine());
                                    double total = num1 * num2;
                                    Console.WriteLine($"RESULTADO: {num1} x {num2} = {total} ");
                                    for (int i = 0; i < 34; i++)
                                    {
                                        Console.Write("-");
                                    }
                                    Console.Write("\n");
                                    Console.WriteLine("Pressione ENTER para prosseguir ");
                                    Operacao = false;
                                    Console.ReadLine();
                                }
                            } while (Menu_mult == true);
                        }
                    } while (Sair == false);
                }
            } while (Sair == false);

        }
    }
}
