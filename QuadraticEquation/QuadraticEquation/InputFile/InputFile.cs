using System;
using System.IO;
using System.Collections.Generic;

namespace QuadraticEquation
{
    public static class InputFile
    {
        public static List<Equation> ReadEquationsFromFile(string filePath)
        {
            TextReader reader;

            if (File.Exists(filePath))
                reader = File.OpenText(filePath);
            else
                return null;

            List<Equation> equations = new List<Equation>();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line | " + line);

                Equation equation = LineToEquation(line);

                if (equation != null)
                    equations.Add(equation);
            }

            return equations;
        }

        public static Equation LineToEquation(string line)
        {
            Equation equation = new Equation();

            string[] numbers = line.Split(' ');

            if (numbers.Length == 3
                    && double.TryParse(numbers[0], out double a)
                    && double.TryParse(numbers[1], out double b)
                    && double.TryParse(numbers[2], out double c))
            {
                equation.a = a;
                equation.b = b;
                equation.c = c;
                return equation;
            }

            return null;
        }
    }
}