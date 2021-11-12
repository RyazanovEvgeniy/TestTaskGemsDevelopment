using System;
using System.IO;

namespace QuadraticEquation
{
    struct Equation
    {
        public double a;
        public double b;
        public double c;
    }

    static class InputFile
    {
        public static Equation[] ReadEquations(string filePath)
        {
            TextReader reader;

            if (File.Exists(filePath))
                reader = File.OpenText(filePath);
            else
                return null;

            Equation[] equations = new Equation[File.ReadAllLines(filePath).Length];
            Console.WriteLine("File.ReadAllLines(filePath).Length == " + File.ReadAllLines(filePath).Length);

            string line;
            int counter = 0;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line#" + counter + " == " + line);

                string[] numbers = line.Split(' ');

                if (numbers.Length <= 3
                    && double.TryParse(numbers[0], out double a)
                    && double.TryParse(numbers[1], out double b)
                    && double.TryParse(numbers[2], out double c))
                {
                    equations[counter].a = a;
                    equations[counter].b = b;
                    equations[counter].c = c;
                }
                else
                    Console.WriteLine("Incorrect line format");

                counter++;
            }

            return equations;
        }

    }
}