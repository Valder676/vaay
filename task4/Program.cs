using System;

class NumberPyramid
{
    static void Main()
    {
        Console.Write("Введите количество ступеней: ");
        int levels = int.Parse(Console.ReadLine());

        for (int i = levels - 1; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

