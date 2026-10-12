using System;

namespace Task1_2
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Константы из задания
            const double a = 2.0;
            const double b = 3.0;
            const double c = 4.0;

            // Поясняющий комментарий: что делает программа
            Console.WriteLine("Программа вычисляет значение функции:");

            Console.WriteLine("y = (a * |x^3 - b|) / sqrt(x^2 + c) + (3/4) * sin^2(x)");

            Console.WriteLine();

            // Вывод исходных констант
            Console.WriteLine("Исходные данные (константы):");
            Console.WriteLine($"  a = {a}");
            Console.WriteLine($"  b = {b}");
            Console.WriteLine($"  c = {c}");
            Console.WriteLine();

            // Ввод x с проверкой через TryParse
            double x = Input("Введите значение x = ");

            // Вычисление результата
            double y = F(Numerator(a, b, x), Denominator(c, x), x);

            // Вывод результата
            Console.WriteLine();
            Console.WriteLine("Результат вычислений:");
            Console.WriteLine($"  x = {x}");
            Console.WriteLine($"  y = {y:F4}");
        }

        /// <summary>
        /// Считывает из консоли введённое число с проверкой через TryParse.
        /// </summary>
        /// <param name="message"> Побуждающая запись. </param>
        /// <returns> Введённое число. </returns>
        static double Input(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                    return value;

                Console.WriteLine("Ошибка: введите корректное число (например, 1 или -1,5).");
            }
        }

        /// <summary>
        /// Рассчитывает значение заданной функции.
        /// </summary>
        /// <param name="numerator"> Числитель. </param>
        /// <param name="denominator"> Знаменатель. </param>
        /// <param name="x"> Аргумент. </param>
        /// <returns> Значение функции. </returns>
        static double F(double numerator, double denominator, double x)
        {
            return numerator / denominator + 0.75 * Math.Sin(x) * Math.Sin(x);
        }

        /// <summary>
        /// Рассчитывает числитель: a * |x^3 - b|.
        /// </summary>
        /// <param name="a"> Константа a. </param>
        /// <param name="b"> Константа b. </param>
        /// <param name="x"> Аргумент. </param>
        /// <returns> Значение числителя. </returns>
        static double Numerator(double a, double b, double x)
        {
            return a * Math.Abs(Math.Pow(x, 3) - b);
        }

        /// <summary>
        /// Рассчитывает знаменатель: sqrt(x^2 + c).
        /// </summary>
        /// <param name="c"> Константа c. </param>
        /// <param name="x"> Аргумент. </param>
        /// <returns> Значение знаменателя. </returns>
        static double Denominator(double c, double x)
        {
            return Math.Sqrt(x * x + c);
        }
    }
}