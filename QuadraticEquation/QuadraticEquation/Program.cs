using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuadraticEquation project");
            Console.WriteLine();

            // Объявляем строку с названием входящего файла
            string inputFile = "input.txt";

            // Вызываем метод пытающийся прочитать лист уравнений из файла
            if (InputFile.ReadEquationsFromFile(inputFile, out List<QuadraticEquation> equations))
            {
                Console.WriteLine("_________________________________________________________________\n");

                // Каждое уравнение в листе
                foreach (QuadraticEquation equation in equations)
                {
                    Console.WriteLine($"Equation: {equation.a}*x^2 + {equation.b}*x + {equation.c} == 0");
                    
                    // Пытаемся решить
                    if (equation.Solve(out List<double> result))
                    {
                        // Если получилось выводим ответы
                        Console.WriteLine("Result:");
                        for (int i = 0; i < result.Count; i++)
                            Console.WriteLine($"{i + 1}) {result[i]}");
                    }
                    // Иначе говорим ответов нет
                    else
                        Console.WriteLine("Equation has no solution ");
                }
            }
            // Если не получилось выводим ошибку
            else
                Console.WriteLine($"Error: File {inputFile} not found");

            Console.ReadKey();
        }
    }
}
