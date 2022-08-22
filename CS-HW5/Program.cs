//Здание 1 домашнего задания 5.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Library;

namespace CS_HW5
{   

    internal class Program
    {
        //Метод проверки на соответствие логина требованиям
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        //Метод проверки на соответствие логина требованиям через регулярные выражения
        static bool CheckLoginReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }

        //Метод проверяет, что символ - латинская буква
        private static bool IsLatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Printer.PrintInfo(5);
            Console.WriteLine("Вас приветствует программа проверки корректности логина.");
            int AmountOfTries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLogin(login) && CheckLoginReg(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой."
                        + Environment.NewLine + "У Вас осталось " + AmountOfTries + "попытка(ок)");
                }

            } while (AmountOfTries > 0);

            Console.WriteLine("Логин корректен!");

            Console.ReadKey();
        }
    }
}
