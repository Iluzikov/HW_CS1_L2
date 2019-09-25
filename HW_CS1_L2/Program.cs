using System;

// Написать метод, возвращающий минимальное из трёх чисел.
//
// Лузиков Иван

namespace HW_CS1_L2
{
    class Program
    {
        static int MinFromThree(int a, int b, int c)
        {
            int min = 0;
            if (a < b) min = a;
            else min = b;
            if (c < min) min = c;
            return min;

            // Вариант в одну строку,
            // вроде работает, но есть сомнения в правильности применения.
            //return a < (b < c ? b : c) ? a : (b < c ? b : c);
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            Console.Write($"Наименьшее число из {a}, {b} и {c}, это - {MinFromThree(a, b, c)}");
            Console.ReadKey();
        }
    }
}
