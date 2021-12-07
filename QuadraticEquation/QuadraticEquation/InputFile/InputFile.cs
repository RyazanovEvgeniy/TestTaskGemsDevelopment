using System;
using System.IO;
using System.Collections.Generic;

namespace Test
{
    // Статический класс для работы с входящим файлом
    public static class InputFile
    {
        // Статический метод чтения уравнений из файла
        public static bool ReadEquationsFromFile(string filePath, out List<QuadraticEquation> equations)
        {
            // Создаем лист уравнений
            equations = new List<QuadraticEquation>();
            // И текстовый обозреватель, с помощью которого будем читать файл
            TextReader reader;

            // Проверяем существование файла
            if (File.Exists(filePath))
                // Если он есть, открываем
                reader = File.OpenText(filePath);
            // Иначе возвращаем ноль == файла нет
            else
                return false;

            // Объявляем строку
            string line;

            // Читаем построчно файл
            // Пока reader.ReadLine() не вернет null
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line | " + line);

                // Пробуем преобразовать строку в уравнение
                if (ConvertLineToEquation(line, out QuadraticEquation equation))
                    // Если получилось добавляем уравнение в список
                    equations.Add(equation);
            }

            // Возвращаем единицу, так как чтение прошло успешно
            return true;
        }

        // Метод преобразования строки в уравнение
        public static bool ConvertLineToEquation(string line, out QuadraticEquation equation)
        {
            // Создаем новое уравнение
            equation = new QuadraticEquation();

            // Разделяем строку, с помощью символа пробела, на подстроки
            string[] numbers = line.Split(' ');

            // Ожидаемый формат полученной строки == "0,3 2,3 4,0"
            // Кол-во полученных строк = 3 и получилось расшифровать каждый double
            if (numbers.Length == 3
                    && double.TryParse(numbers[0], out double a)
                    && double.TryParse(numbers[1], out double b)
                    && double.TryParse(numbers[2], out double c))
            {
                // Заполняем уравнение
                equation.a = a;
                equation.b = b;
                equation.c = c;
                // Возвращаем единицу, так как все прошло успешно
                return true;
            }
            // Иначе возвращаем ноль
            else
                return false;
        }
    }
}