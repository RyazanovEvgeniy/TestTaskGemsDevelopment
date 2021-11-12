using System;
using System.Collections.Generic;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuadraticEquation project");
            Console.WriteLine();

            Calc calc = new Calc();

            List<Equation> equations = InputFile.ReadEquationsFromFile("input.txt");
            Console.WriteLine();

            double[] result;

            foreach (Equation equation in equations)
            {
                Console.WriteLine($"Equation: {equation.a}*x^2 + {equation.b}*x + {equation.c} == 0");
                result = calc.SolveQuadraticEquation(equation.a, equation.b, equation.c);

                if (result != null)
                    Console.WriteLine($"Result: x1 == {result[0]}, x2 == {result[1]}");
                else
                    Console.WriteLine("Equation has no solution ");
            }

            Console.ReadKey();
        }
    }
}
