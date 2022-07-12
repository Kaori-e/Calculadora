// Calculadora 

using System;
using System.Collections.Generic;
using System.Text;


namespace calculadora
{
    class Program
    {
        static void Main()
        {
            var num = "0";
            int n1, n2, n3, n4;
            int soma, sub, div, mut;


            do
            {

                Console.WriteLine("Olá, seja bem vindo ao programa de cálculo rápido!");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Agora escolha qual operação você deseja fazer?");
                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");


                num = Console.ReadLine();
                Console.WriteLine(num);

                switch (num)
                {
                    case "0":

                        Console.WriteLine("Você está saindo do programa");
                        Console.ReadLine();

                        break;
                    case "1":
                        Console.WriteLine("Digite o primeiro número: ");
                        int.TryParse(Console.ReadLine(), out n1);

                        Console.WriteLine("Digite o segundo número:");
                        int.TryParse(Console.ReadLine(), out n2);

                        Console.WriteLine("Digite o terceiro número: ");
                        int.TryParse(Console.ReadLine(), out n3);

                        Console.WriteLine("Digite o quarto número: ");
                        int.TryParse(Console.ReadLine(), out n4);

                        soma = n1 + n2 + n3 + n4;

                        Console.WriteLine("A soma dos números é: {0}", soma);
                        Console.ReadLine();

                        break;

                    case "2":
                        Console.WriteLine("Digite o primeiro número: ");
                        int.TryParse(Console.ReadLine(), out n1);

                        Console.WriteLine("Digite o segundo número:");
                        int.TryParse(Console.ReadLine(), out n2);

                        Console.WriteLine("Digite o terceiro número: ");
                        int.TryParse(Console.ReadLine(), out n3);

                        Console.WriteLine("Digite o quarto número: ");
                        int.TryParse(Console.ReadLine(), out n4);

                        sub = (n1) - (n2) - (n3) - (n4);

                        Console.WriteLine("A subtração dos números é: {0}", sub);
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.WriteLine("Digite o primeiro número: ");
                        int.TryParse(Console.ReadLine(), out n1);

                        Console.WriteLine("Digite o segundo número:");
                        int.TryParse(Console.ReadLine(), out n2);

                        div = (n1) / (n2);

                        Console.WriteLine("A divisão dos números é: {0}", div);
                        Console.ReadLine();

                        break;

                    case "4":
                        Console.WriteLine("Digite o primeiro número: ");
                        int.TryParse(Console.ReadLine(), out n1);

                        Console.WriteLine("Digite o segundo número:");
                        int.TryParse(Console.ReadLine(), out n2);

                        Console.WriteLine("Digite o terceiro número: ");
                        int.TryParse(Console.ReadLine(), out n3);

                        Console.WriteLine("Digite o quarto número: ");
                        int.TryParse(Console.ReadLine(), out n4);

                        mut = (n1) * (n2) * (n3) * (n4);

                        Console.WriteLine("A multiplicação dos números é: {0}", mut);
                        Console.ReadLine();

                        break;

                    default:

                        Console.WriteLine("Digite um número válido!");
                        Console.ReadLine();


                        break;

                }





            }
            while (num != "0");
            
        }

    

    }


}