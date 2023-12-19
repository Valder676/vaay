using System;

class FunctionTable
{
    static double CalculateFunction(double x)
    {
        if (x < 1)
            return Math.Pow((x * x - 1), 2);
        else if (x > 1)
            return 1 / Math.Pow((1 + x), 2);
        else
            return 0;
    }

    static void Main()
    {
        Console.Write("Введите начальное значение диапазона (a): ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите конечное значение диапазона (b): ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите шаг (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        for (double x = a; x <= b; x += h)
        {
            double y = CalculateFunction(x);
            Console.WriteLine($"x = {x:F2}, y = {y:F4}");
        }
    }
}
