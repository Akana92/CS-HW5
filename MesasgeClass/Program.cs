using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesasgeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Printer.PrintInfo(5);

            Console.WriteLine("Вас приветствует программа демонстрации возможностей статического класса Message.");

            Console.WriteLine("\nИмеется следующий текст: \n" + Message.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'я': ");
            Message.DeleteWordByEndChar('я');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

            Console.WriteLine("\nПроизведём частотный анализ текста: ");
            string[] arr = { "шел", "его", "тело", "жив", "он" };
            Message.FrequencyAnalysis(arr, Message.text);

            Console.ReadKey();
        }
    }
}
