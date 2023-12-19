using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два числа:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Вы ввели числа: {num1} и {num2}");
        Console.WriteLine("Какое действие выполнить?");
        Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Нахождение остатка");

        int action = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        switch (action)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                    return;
                }
                break;
            case 5:
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Неверный выбор действия!");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
