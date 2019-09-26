using System;

// а) Написать программу, которая запрашивает массу и рост человека,
//    вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б)* Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
//
// Лузиков Иван

namespace Task_5
{
    class Program
    {
        static double GetImt(double userWeight, double userHeight)
        {
            return Math.Round(userWeight / (userHeight * userHeight), 2);
        }
        
        static void Main(string[] args)
        {
            var message = "";
            double minImtPoint = 18.5;
            double maxImtPoint = 25;
            int weightCount = 0;

            Console.Write("Введите вес(кг): ");
            var userWeight = double.Parse(Console.ReadLine());
            Console.Write("Введите рост(см): ");
            var userHeight = double.Parse(Console.ReadLine()) / 100.0;

            var userImt = GetImt(userWeight, userHeight);
            var normalImt = userImt;

            if (userImt < minImtPoint)
            {
                while (normalImt < minImtPoint)
                {
                    userWeight += 1;
                    weightCount++;
                    normalImt = GetImt(userWeight, userHeight);
                }
                message = "Вам нужно набрать примерно " + weightCount + " кг для нормализации веса";
            }
            else if (userImt >= minImtPoint && userImt < maxImtPoint)
            {
                message = "Ваш вес в норме.";
            }
            else if (userImt >= maxImtPoint)
            {
                while (normalImt > maxImtPoint)
                {
                    userWeight -= 1;
                    weightCount++;
                    normalImt = GetImt(userWeight, userHeight);
                }
                message = "Вам нужно сбросить примерно " + weightCount + " кг для нормализации веса";
            }

            Console.WriteLine();
            Console.WriteLine($"Ваш индекс масы тела = {userImt}. {message}");

            Console.ReadKey();
        }
    }
}
