using System;
using System.Collections.Generic;

namespace Calculadora_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calculadora> lista_calculadora = new List<Calculadora>();
            String op = null;
            double x = 0, y = 0, resultado;
            Console.WriteLine("Calculadora 2.0");
            do
            {
                op = Menu();
                if (op.Equals("4"))
                {
                    Console.Clear();
                    Console.WriteLine("\nSegundo valor não pode ser zero!");
                    do
                    {
                        MenuValores(ref x, ref y);
                    } while (y == 0);
                }
                else if (op.Equals("1") || op.Equals("2") || op.Equals("3"))
                {
                    MenuValores(ref x, ref y);
                }

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        resultado = Calcular.Adicao(x, y);
                        Console.WriteLine($"{x}" + " + " + $"{y}" + " = " + $"{resultado}");
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "+"));
                        break;
                    case "2":
                        Console.Clear();
                        resultado = Calcular.Subtracao(x, y);
                        Console.WriteLine($"{x}" + " - " + $"{y}" + " = " + $"{resultado}");
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "-"));
                        break;
                    case "3":
                        Console.Clear();
                        resultado = Calcular.Multiplicacao(x, y);
                        Console.WriteLine($"{x}" + " * " + $"{y}" + " = " + $"{resultado}");
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "*"));
                        break;
                    case "4":
                        Console.Clear();
                        resultado = Calcular.Divisao(x, y);
                        Console.WriteLine($"{x}" + " / " + $"{y}" + " = " + $"{resultado}");
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "/"));
                        break;
                    case "5":
                        Console.Clear();
                        if (lista_calculadora.Count != 0)
                        {
                            Console.WriteLine("\nRESULTADOS");
                            foreach (Calculadora calc in lista_calculadora)
                            {
                                Console.WriteLine($"{calc.X}" + $" {calc.Operacao} " + $"{calc.Y}" + " = " + $"{calc.Resultado}");
                            }
                        } else
                        {
                            Console.WriteLine("\nERRO: Não possui resultados!\n");
                        }
                            break;
                    case "S":
                        Console.WriteLine("\nFinalizando o sistema....");
                        break;
                    default:
                        Console.WriteLine("\nERRO: Digite uma opção válida.\n");
                        break;
                }
            } while (op != "S");
        }

        public static string Menu()
        {
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas");
            Console.WriteLine("Digite S para sair");

            string op = Console.ReadLine().ToUpper();
            return op;
        }

        public static void MenuValores(ref double x, ref double y)
        {
            try
            {
                Console.WriteLine("Digite o primeiro valor: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO: Os valores são inválidos.");
            }
        }
    }


}
