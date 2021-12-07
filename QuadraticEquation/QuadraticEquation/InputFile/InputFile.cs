using System;
using System.IO;
using System.Collections.Generic;

namespace Test
{
    // ����������� ����� ��� ������ � �������� ������
    public static class InputFile
    {
        // ����������� ����� ������ ��������� �� �����
        public static bool ReadEquationsFromFile(string filePath, out List<QuadraticEquation> equations)
        {
            // ������� ���� ���������
            equations = new List<QuadraticEquation>();
            // � ��������� ������������, � ������� �������� ����� ������ ����
            TextReader reader;

            // ��������� ������������� �����
            if (File.Exists(filePath))
                // ���� �� ����, ���������
                reader = File.OpenText(filePath);
            // ����� ���������� ���� == ����� ���
            else
                return false;

            // ��������� ������
            string line;

            // ������ ��������� ����
            // ���� reader.ReadLine() �� ������ null
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Line | " + line);

                // ������� ������������� ������ � ���������
                if (ConvertLineToEquation(line, out QuadraticEquation equation))
                    // ���� ���������� ��������� ��������� � ������
                    equations.Add(equation);
            }

            // ���������� �������, ��� ��� ������ ������ �������
            return true;
        }

        // ����� �������������� ������ � ���������
        public static bool ConvertLineToEquation(string line, out QuadraticEquation equation)
        {
            // ������� ����� ���������
            equation = new QuadraticEquation();

            // ��������� ������, � ������� ������� �������, �� ���������
            string[] numbers = line.Split(' ');

            // ��������� ������ ���������� ������ == "0,3 2,3 4,0"
            // ���-�� ���������� ����� = 3 � ���������� ������������ ������ double
            if (numbers.Length == 3
                    && double.TryParse(numbers[0], out double a)
                    && double.TryParse(numbers[1], out double b)
                    && double.TryParse(numbers[2], out double c))
            {
                // ��������� ���������
                equation.a = a;
                equation.b = b;
                equation.c = c;
                // ���������� �������, ��� ��� ��� ������ �������
                return true;
            }
            // ����� ���������� ����
            else
                return false;
        }
    }
}