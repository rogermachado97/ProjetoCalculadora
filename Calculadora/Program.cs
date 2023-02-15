using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Digital");
            Console.WriteLine("=================================");
            Console.WriteLine(" ");
            Console.WriteLine("Qual operação será feita ?");
            Console.WriteLine(" ");
            Console.WriteLine("1. Para calcular <<<<Porcentagem>>>>");
            Console.WriteLine("2. Adição ");
            Console.WriteLine("3. Subtração");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Multiplicação");
            Console.WriteLine(" ");

            int operacao = int.Parse(Console.ReadLine());

            //Aqui começa o bloco de comando de porcentagem

            while (operacao == 1)
            {
                long result;

                Console.WriteLine("De qual numero voce quer calcular a porcentagem ?");
                long num1 = long.Parse(Console.ReadLine());


                Console.WriteLine("Quantos % você quer do número que acabou de digitar ?");
                int porcentagem = int.Parse(Console.ReadLine());

                if (porcentagem > 100)
                {

                    Console.WriteLine("Porcentagem inválida");

                    return ;


                }

                result = (num1 * porcentagem) / 100;

                Console.WriteLine(porcentagem + "% de " + num1 + " é: " + result);

                


            }

            //Aqui termina o bloco de comando de porcentagem
            
            //Aqui começa o bloco de comando das 4 operações fundamentais 

            Console.WriteLine("Digite o primeiro valor: ");
            long valor1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            long valor2 = long.Parse(Console.ReadLine());


            long resultado;

            switch (operacao)
            {
                case 2:

                    {

                        resultado = valor1 + valor2;

                        Console.WriteLine("O resultado da adição é: "+ resultado);

                        return;
                    }

                case 3:

                    {
                        resultado = valor1 - valor2;

                        Console.WriteLine("O resultado da subtração é: " + resultado);

                        return;

                    }

                case 4:

                    {
                        resultado = valor1 / valor2;

                        Console.WriteLine("O resultado da divisão é: " + resultado);

                        return;

                    }

                case 5:

                    {
                        resultado = valor1 * valor2;

                        Console.WriteLine("O resultado da multiplacação é: " + resultado);

                        return;

                    }

                //Aqui termina o bloco de comando das 4 operações fundamentais


                



            }

        }
    }
}

/*Esta calculadura ainda tem muito a ser melhorada e aperfeiçoada, trabalharei pra isso. 
* Esta calculadora será o termometro do meu progresso na linguagem C# */
