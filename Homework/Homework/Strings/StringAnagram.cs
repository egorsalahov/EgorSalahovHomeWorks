using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStrings
{
    internal class StringAnagram
    {
        public static void DoStringAnagram()
        {
            Console.WriteLine("Введите первую строку: ");
            string inputFirst = Console.ReadLine();

            Console.WriteLine("Введите вторую строку: ");
            string inputSecond = Console.ReadLine();

            //подчищаем от лишних символов
            inputFirst.Trim();
            inputSecond.Trim();

            //Сортирую. https://stackoverflow.com/questions/6441583/is-there-a-simple-way-that-i-can-sort-characters-in-a-string-in-alphabetical-ord
            string inputFirstSorted = String.Concat(inputFirst.OrderBy(c => c));
            string inputSecondSorted = String.Concat(inputSecond.OrderBy(c => c));

            if (inputFirstSorted == inputSecondSorted)
            {
                Console.WriteLine("Строки являются анаграммами");
            }
            else
            {
                Console.WriteLine("Строки не являются анаграммами");
            }
        }
    }
}
