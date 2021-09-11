using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Eu posso selecionar o valor exato inicial do Enum
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool escolheusair = false;
            while (!escolheusair)
            {

                Console.WriteLine("Seja bem vinda(o) a Calc, Selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Sair:
                        escolheusair = true;
                        break;

                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Sub();
                        break;

                    case Menu.Divisao:
                        Div();
                        break;

                    case Menu.Multiplicacao:
                        Mult();
                        break;

                    case Menu.Potencia:
                        Pot();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                }

                Console.Clear(); // Limpa o Console
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a - b;

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            float resultado = (float)a / (float)b;
            // "cast: Converter um tipo para o outro" Ao adicionar (float) ao lado da variavel int eu converto ela para float

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a * b;

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }

        static void Pot()
        {
            // 2³ = 2*2*2=8
            Console.WriteLine("Potencia de um numeros: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Pow(baseNum, expo);

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {

            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(a); //Square Root (Raiz Quadrada)

            //Forma "Padrao"
            Console.WriteLine("O resultado é: " + resultado + " - Comum");

            //Interpolação
            Console.WriteLine($"O resultado é: {resultado} - Interpolação");

            Console.WriteLine("Aperte enter para volta ao menu");
            Console.ReadLine();
        }
    }
}
