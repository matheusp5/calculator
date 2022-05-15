using System;
using System.Globalization;

namespace Calc
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("SEJA BEM VINDO A CALCULADORA DO MX");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Digite seu primeiro numero: ");
            double int1_rd = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Selecione o que quer fazer: ");
            Console.WriteLine("1; Mais ");
            Console.WriteLine("2; Menos");
            Console.WriteLine("3; Multiplicação ");
            Console.WriteLine("4; Divisão ");
            Console.WriteLine("5; Resto da divisão ");
            Console.WriteLine("6; Potenciação ");
            Console.WriteLine("7; Raiz Quadrada ");
            int arit_rd = int.Parse(Console.ReadLine());

            if (arit_rd != 6)
            {
                if(arit_rd != 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Digite seu segundo numero: ");
                    double int2_rd = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Calculator.Calc(arit_rd, int1_rd, int2_rd);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Calculator.CalcSqrt(int1_rd);
                }
            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Calculator.CalcPow(int1_rd);
            }

            /*
            double int2_rd = double.Parse(Console.ReadLine());
            string arit_rd = Console.ReadLine();
            // 1 = +
            // 2 = -
            // 3 = *
            // 4 = /
            // 5 = %
            // 6 = Math.Pow (Potenciacao)
            // 7 = Math.Sqrt (Raiz Quadrada)
            */
        }
        private static void Calc(int arit_rd, double int1_rd, double int2_rd)
        {
            if (arit_rd <= 5)
            {
                if (arit_rd == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    double result = int1_rd + int2_rd;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("RESULTADO: ");
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                if (arit_rd == 2)
                {
                    double result = int1_rd - int2_rd;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("RESULTADO: ");
                    Console.WriteLine(result);
                }
                if (arit_rd == 3)
                {double result = int1_rd * int2_rd;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("RESULTADO: ");
                    Console.WriteLine(result);
                }
                if (arit_rd == 4)
                {
                    double result = int1_rd / int2_rd;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("RESULTADO: ");
                    Console.WriteLine(result);
                }
                if (arit_rd == 5)
                {
                    double result = int1_rd % int2_rd;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("RESULTADO: ");
                    Console.WriteLine(result);
                }
            } else {
                throw new Exception("Ou viado");
            }
        }

        private static double CalcSqrt(double Raiz)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("RESULTADO: ");
            Console.WriteLine(Math.Sqrt(Raiz));
            return Math.Sqrt(Raiz);
        }

        private static double CalcPow(double Base)
        {
            Console.WriteLine("Qual vai ser o expoente?");
                double exp_rd = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            Console.WriteLine("RESULTADO: ");
            Console.WriteLine(Math.Pow(Base, exp_rd));
                return Math.Pow(Base, exp_rd);
        }
    }
}
 