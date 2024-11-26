using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStrings
{
    internal class CapitalizationString
    {
        public static void DoCapitalizationString()
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            string[] result = s.Split(" ");

            for(int i =0; i < result.Length; i++)
            {
                result[i] = char.ToUpper(result[i][0]) + result[i].Substring(1).ToLower();
            }

            string back = String.Join(" ", result);

            Console.WriteLine(back);
        }
    }
}
