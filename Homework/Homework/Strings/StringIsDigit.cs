using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStrings
{
    internal class StringIsDigit
    {
        public static void DoStringIsDigit()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            Console.WriteLine("Ваша строка: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
