using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10];

        // Заполнение массива случайными числами от 1 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        // Подсчет количества элементов в отрезке [20, 90]
        int count = 0;
        foreach (int number in numbers)
        {
            if (number >= 20 && number <= 90)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов в отрезке [20, 90]: {count}");
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 7, 8, 20, 15, 10, 3, 6, 11 }; // Заданный массив из 10 чисел

        int evenCount = 0;

        // Подсчет количества четных чисел в массиве
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }
}

using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 3.14, 2.718, 1.618, 4.669, 2.236 }; // Пример массива из вещественных чисел

        // Нахождение минимального и максимального элементов массива
        double min = numbers[0];
        double max = numbers[0];

        foreach (double number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        // Нахождение разницы между максимальным и минимальным элементами
        double difference = max - min;

        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}