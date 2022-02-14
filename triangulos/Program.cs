using System;

namespace triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            string opcao = "";
            
            while (opcao != "s")
            {
                Console.WriteLine("Classificação dos Triângulos:");
                Console.WriteLine("___________________________");
                Console.WriteLine("Digite o valor para x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor para y: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor para z: ");
                z = Convert.ToDouble(Console.ReadLine());


                if (x + y < z || x + z < y || y + z < x)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Triângulo iválido ");
                    Console.WriteLine("Erro na condição de existência");
                    Console.WriteLine("Pressione enter para digitar novamente os valores");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                if ( y!=x && y!=z && x!=z)
                {
                    Console.Clear();
                    Console.WriteLine(" x=" + x + " y=" + y + " z=" + z);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("É um triângulo escaleno");
                    Console.ResetColor();

                }
                else if ( x==y && x !=z || y==z && y!= x || z==x && z!=y )
                {
                    Console.Clear();
                    Console.WriteLine(" x=" + x + " y=" + y + " z=" + z);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("É um triângulo Isóceles");
                    Console.ResetColor();
                }
                else if(y==x && y==z && x==z)
                {
                    Console.Clear();
                    Console.WriteLine(" x=" + x + " y=" + y + " z=" + z);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("É um triângulo Equilátero");
                    Console.ResetColor();
                }

                Console.WriteLine("Quer digitar um novo triangulo?");
                Console.WriteLine("digite: 1");
                Console.WriteLine("Quer sair? ");
                Console.WriteLine("Digite: s");
                opcao = Console.ReadLine();


                if (opcao == "1")
                {
                    continue;
                }
                else if (opcao == "s")
                {
                    break;
                }
                else if (opcao != "1" && opcao != "s")
                {
                    do
                    {
                        
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Opção Inválida");
                        Console.WriteLine("digite novamente");
                        Console.ResetColor();
                        Console.WriteLine("Quer digitar um novo triangulo?");
                        Console.WriteLine("digite: 1");
                        Console.WriteLine("Quer sair? ");
                        Console.WriteLine("Digite: s");
                        opcao = Console.ReadLine();
                        Console.Clear();

                    }
                    while (opcao != "1" && opcao != "s");
                }


            }
        }
    }
}
