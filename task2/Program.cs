using System;

class MaxMinFinder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пять чисел:");
        string[] inputs = Console.ReadLine().Split(' ');

        // Проверка, что введено ровно пять чисел
        if (inputs.Length != 5)
        {
            Console.WriteLine("Ошибка: необходимо ввести ровно пять чисел!");
            return;
        }

        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;

        foreach (var str in inputs)
        {
            int number;
            if (int.TryParse(str, out number))
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            else
            {
                Console.WriteLine($"Ошибка: '{str}' не является числом!");
                return;
            }
        }

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
    }
}
