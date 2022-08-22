using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        //Метод определяет, является ли одна строка перестановкой другой
        static bool equalChar(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            string news1 = s1[0].ToString();
            string news2 = s2[0].ToString();

            for (int i = 1; i < s1.Length; i++)
                putChar(ref news1, s1[i]);

            for (int i = 1; i < s2.Length; i++)
                putChar(ref news2, s2[i]);

            if (news1.Equals(news2))
                return true;
            else
                return false;
        }

        //Метод вставляет новый символ в строку
        static void putChar(ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            Library.Printer.PrintInfo(5);
            string first = "abcde";
            string second = "edbac";

            Console.WriteLine("Вас приветствует программа проверки является ли одна строка перестановкой другой.");

            Console.WriteLine("Проверим следующие строки: " + first + ", и " + second);

            if (equalChar(first, second) == true)
                Console.WriteLine("Строки являются перестановкой друг друга.");
            else
                Console.WriteLine("Строки состоят из разных символов.");

            Console.ReadKey();
        }
    }
}
