namespace Task1_1
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 1.0;
            const double c = 3.0;

            double x = Input("Введите x = ");

            double y = F(Numerator(a, b, c, x), Denominator(c, x));

            Console.WriteLine($"x = {x}, y = {y}");
        }

        /// <summary>
        /// Считывает из консоли введенное число.
        /// </summary>
        /// <param name="message"> Побуждающая запись.</param>
        /// <returns> Введенное число. </returns>
        static double Input(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            double x = double.Parse(input);
            return x;
        }

        /// <summary>
        /// Рассчитывает значение заданной функции.
        /// </summary>
        /// <param name="numerator"> Числитель.</param>
        /// <param name="denominator">Знаменатель. </param>
        /// <returns> Значение функции. </returns>
        static double F(double numerator, double denominator)
        {
            return numerator / denominator;
        }

        /// <summary>
        /// Рассчитывает числитель.
        /// </summary>
        /// <param name="a"> Константа a. </param>
        /// <param name="c"> Константа с. </param>
        /// <param name="b"> Константа b. </param>
        /// <param name="x"> Аргумент. </param>
        /// <returns> Значение числителя. </returns>
        static double Numerator(double a, double c, double b, double x)
        {
            return (a * Math.Pow(Math.Abs(x), 3) +
                b * Math.Sqrt(x * x + 1));
        }

        /// <summary>
        /// Рассчитывает знаменатель.
        /// </summary>
        /// <param name="c"> Константа с. </param>
        /// <param name="x"> Аргумент.</param>
        /// <returns> Значение  знаменателя. </returns>
        static double Denominator(double c, double x)
        {
            return c + Math.Sin(x) * Math.Sin(x)
                + Math.Cos(x) * Math.Cos(x);
        }
    }
}