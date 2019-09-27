using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static bool IsGoodNumber(int num)
        {
            return num % ((num / 10) + (num % 10)) == 0;
        }

        static void Main(string[] args)
        {
            int goodNumberCount = 0;
            var timeStart = DateTime.Now;
            int numStart = 1;
            int numEnd = 1000000000;
            Console.WriteLine("Программа запущена в: "+ timeStart.ToString("hh:mm:ss"));
            Console.WriteLine($"Выполняется поиск \"хороших\" чисел в диапазоне от {numStart}  до {numEnd}");

            for (int i = numStart; i < numEnd; i++)
            {
                if(IsGoodNumber(i))
                    goodNumberCount++;
            }

            var executionTime = DateTime.Now - timeStart;
            Console.WriteLine();
            Console.WriteLine($"Количество \"хороших\" чисел = {goodNumberCount.ToString("### ### ### ###")}");
            Console.WriteLine($"Время выполнения {executionTime.ToString("ss")} сек {executionTime.ToString("ff")} мсек");
            
            Console.ReadKey();
        }
    }
}
