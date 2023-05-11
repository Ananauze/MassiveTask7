using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string phrase = "Сегодня четверг, а хочется лето.";
            string[] words = phrase.Split(' ');

            Console.WriteLine("\nВыводим фразу для проверки: \n");
            Console.WriteLine(phrase);

            Console.WriteLine("\nТеперь разделим по словам: \n");
            
            foreach (string word in words) 
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(word);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();
        }
    }
}
