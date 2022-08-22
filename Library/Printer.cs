using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Printer
    {
        public static void PrintInfo(int homeworkNumber)
        {
                // Вывод информации на экран
                Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
                Console.WriteLine($"Студент: Ыбыраев Канат");
                Console.WriteLine("=====================================================================");
                Console.WriteLine();
            }
        
    }
}
