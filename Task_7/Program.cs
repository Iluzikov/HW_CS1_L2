using System;

// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
//
// Лузиков Иван


namespace Task_7
{
    class Program
    {
        static void PrintNumberLoop(int a, int b)
        {
            Console.WriteLine(a);
            if(a < b) PrintNumberLoop(a + 1, b);
        }

        static int SumLoop(int a, int b)
        {
            int sum = a;
            if (a < b)
                sum += SumLoop(a + 1, b);
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;

            // Задание а)
            Console.WriteLine($"Числа от {a} до {b} ");
            PrintNumberLoop(a, b);
            Console.WriteLine();
            // Задание б)
            Console.WriteLine("Сумма этих чисел = " + SumLoop(a, b));

            Console.ReadKey();
        }
    }
}
