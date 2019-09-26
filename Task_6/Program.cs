using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int goodNumCount = 0;

            for (int i = 1; i < 10000000; i++)
            {
                int a = i;
                int b = a / 10;
                int c = a % 10;
                int x = b + c;
                int z = a / x;
                if(a % x == 0)
                {
                    goodNumCount++;
                    //Console.WriteLine($"{a} -> {b} + {c} = {x} | {a} / {x} = {z}");
                    
                }

            }

            Console.WriteLine($"Количество Хороших чисел = {goodNumCount.ToString("### ### ### ###")}");
            
            Console.ReadKey();
        }
    }
}
