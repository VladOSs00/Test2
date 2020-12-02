﻿using System;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(string.Format("Введите название функции: sin,cos,ln,sqrt,formula"));
                string fx = Console.ReadLine();

                Console.WriteLine("Введите стартовое значение");
                double init = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите шаг функции");
                double step = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите конечное значение");
                double end = Convert.ToDouble(Console.ReadLine());

                var stream = new FileStream(AppContext.BaseDirectory + $"\\{fx}Result.csv", FileMode.Create,
                        FileAccess.ReadWrite);
                using var writer = new StreamWriter(stream, Encoding.Unicode);
                writer.WriteLine("sep=;");
                using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" });

                for (double val = init; val <= end; val += step)
                {
                    double result;

                    switch (fx)
                    {
                        case "sin":
                            result = mathfunctions.Sin(val);
                            break;
                        case "cos":
                            result = mathfunctions.Cos(val);
                            break;
                        case "ln":
                            result = mathfunctions.Ln(val);
                            break;
                        case "sqrt":
                            result = mathfunctions.Sqrt(val);
                            break;
                        case "formula":
                            result = functionlb2.function(val);
                            break;

                        default:
                            result = 0;
                            break;
                    }

                    csv.WriteRecord(new { X = val, Result = result });
                    csv.NextRecord();
                }

                Console.WriteLine($"Результаты вычисления функции сохранены в {fx}Result.csv");
            }

        }
    }
}

