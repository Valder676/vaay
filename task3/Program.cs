using System;

class FunctionCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        string input = Console.ReadLine();

        try
        {
            double x = Convert.ToDouble(input);

            if (2 * x - 1 <= 0)
            {
                Console.WriteLine("Ошибка: выражение под корнем должно быть больше нуля.");
            }
            else
            {
                double y = x / Math.Sqrt(2 * x - 1);
                Console.WriteLine($"Значение функции y = {y}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не числовое значение.");
        }
    }
}
