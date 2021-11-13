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

            string inputFile = "input.txt";

            if (InputFile.ReadEquationsFromFile(inputFile, out List<Equation> equations))
            {
                Console.WriteLine("_________________________________________________________________\n");

                Calc calc = new Calc();

                foreach (Equation equation in equations)
                {
                    Console.WriteLine($"Equation: {equation.a}*x^2 + {equation.b}*x + {equation.c} == 0");

                    if (calc.SolveQuadraticEquation(equation.a, equation.b, equation.c, out double[] result))
                        Console.WriteLine($"Result: x1 == {result[0]}, x2 == {result[1]}");
                    else
                        Console.WriteLine("Equation has no solution ");
                }
            }
            else
                Console.WriteLine($"File {inputFile} not found");

            Console.ReadKey();
        }
    }
}
