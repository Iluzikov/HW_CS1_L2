using System;

// Реализовать метод проверки логина и пароля.
// На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию,
// и ложь, если не прошел (Логин: root, Password: GeekBrains).
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
// программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.
//
// Лузиков Иван

namespace Task_4
{
    class Program
    {
        static bool checkAuth(string log, string pass)
        {
            string correctLogin = "root";
            string correctPassword = "GeekBrains";

            if (log == correctLogin && pass == correctPassword)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int tryCount = 3;
            do
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                if (checkAuth(login, password))
                {
                    Console.WriteLine("Доступ разрешен.");
                    break;
                }
                else
                {
                    tryCount--;
                    Console.WriteLine($"Нет доступа! Осталось {tryCount} попытки(ка)");
                }
                    
            } while (tryCount > 0);

            Console.ReadKey();
        }
    }
}
