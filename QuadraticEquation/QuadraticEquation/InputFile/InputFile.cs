using System;
using System.IO;
using System.Collections.Generic;

namespace QuadraticEquation
{
    public static class InputFile
    {
        public static bool ReadEquationsFromFile(string filePath, out List<Equation> equations)
        {
            equations = new List<Equation>();
            TextReader reader;

            if (File.Exists(filePath))
                reader = File.OpenText(filePath);
            else
                return false;

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line | " + line);

                if (LineToEquation(line, out Equation equation))
                    equations.Add(equation);
            }

            return true;
        }

        public static bool LineToEquation(string line, out Equation equation)
        {
            equation = new Equation(0.0, 0.0, 0.0);

            string[] numbers = line.Split(' ');

            if (numbers.Length == 3
                    && double.TryParse(numbers[0], out double a)
                    && double.TryParse(numbers[1], out double b)
                    && double.TryParse(numbers[2], out double c))
            {
                equation.a = a;
                equation.b = b;
                equation.c = c;
                return true;
            }

            return false;
        }
    }
}