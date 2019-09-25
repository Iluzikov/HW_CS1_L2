using System;

// С клавиатуры вводятся числа, пока не будет введен 0.
// Подсчитать сумму всех нечетных положительных чисел.
//
// Лузиков Иван

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                    break;
                else if (userInput > 0 && userInput % 2 != 0)
                    sum += userInput;
                else
                    continue;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
