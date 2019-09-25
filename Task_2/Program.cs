using System;

// Написать метод подсчета количества цифр числа.
//
// Лузиков Иван

namespace Task_2
{
    class Program
    {
        static int getCountOfDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int a = 159;
            Console.WriteLine($"В числе {a} - {getCountOfDigits(a)} символа");
            
            Console.ReadKey();
        }
    }
}
