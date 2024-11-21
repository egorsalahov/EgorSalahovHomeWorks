using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework._1_задача
{
    public class First
    {
        public void Solution()
        {
            Console.WriteLine("Введите строку");

            string s = Console.ReadLine();

            Console.WriteLine("Ваша строка: ");
            var result = new Regex("[0-9]+").Matches(s);
            foreach (var match in result) Console.WriteLine(match);
        }
    }
}
