using System;

namespace Task1_3
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Константы из задания
            const double a = 3.0;
            const double b = 2.0;
            const double c = 1.0;

            // Поясняющий комментарий: что делает программа
            Console.WriteLine("Программа вычисляет значение функции:");  
            Console.WriteLine("y = (5/2)*a*sqrt(|x|) + b*ln(|x^2 - 1| + 1) + c*cos(x)");
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
            double y = F(a, b, c, x);

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

                Console.WriteLine("Ошибка: введите корректное число (например, 2 или -1,5).");
            }
        }

        /// <summary>
        /// Рассчитывает значение заданной функции.
        /// </summary>
        /// <param name="a"> Константа a. </param>
        /// <param name="b"> Константа b. </param>
        /// <param name="c"> Константа c. </param>
        /// <param name="x"> Аргумент. </param>
        /// <returns> Значение функции. </returns>
        static double F(double a, double b, double c, double x)
        {
            return FirstTerm(a, x) + SecondTerm(b, x) + ThirdTerm(c, x);
        }

        /// <summary>
        /// Первое слагаемое: (5/2) * a * sqrt(|x|).
        /// </summary>
        static double FirstTerm(double a, double x)
        {
            return 2.5 * a * Math.Sqrt(Math.Abs(x));
        }

        /// <summary>
        /// Второе слагаемое: b * ln(|x^2 - 1| + 1).
        /// </summary>
        static double SecondTerm(double b, double x)
        {
            return b * Math.Log(Math.Abs(x * x - 1) + 1);
        }

        /// <summary>
        /// Третье слагаемое: c * cos(x).
        /// </summary>
        static double ThirdTerm(double c, double x)
        {
            return c * Math.Cos(x);
        }
    }
}