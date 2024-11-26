using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStrings
{
    internal class StringPalindrome
    {
        public static void DoStringPalindrome()
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            input = input.Trim(); // убираем лишние знаки

            StringBuilder inputReverseBuilder = new StringBuilder(input.Length);
            for(int i = input.Length - 1; i >=0; i--)
            {
                inputReverseBuilder.Append(input[i]);
            }

            string inputReverse = inputReverseBuilder.ToString();

            if(input == inputReverse)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
    }
}
