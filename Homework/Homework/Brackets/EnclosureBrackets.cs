using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBrackets
{
    internal class EnclosureBrackets
    {
        public static void DoEnclosureBrackets()
        {
            //переменная для проверки равенства количества открывающих и закрывающих скобок
            int brace = 0;

            //количество вложенностей скобок
            int count = 0;

            //результат
            int result = 0;

            Console.WriteLine("Введите строку из символов '(' и ')'");
            string s = Console.ReadLine(); //строка от пользователя

            for (int i = 0; i < s.Length; i++) //пробегаем по всей строке
            {
                if (s[i] == '(')
                {
                    brace++;
                }
                else if (s[i] == ')')
                {
                    if (i != s.Length - 1 && s[i + 1] == ')') //если это конец строки и следующая закрывающая
                    {
                        count++;
                    }

                    brace--; //выполняется в любом случае, независимо от if-а
                }

                if (brace < 0) //если число открывающих-закрывающих скобок неравно
                {
                    break;
                }
                if (brace == 0) //если число открывающих-закрывающих скобок равно
                {
                    result = count;
                }
            }

            if (brace == 0)
            {
                Console.WriteLine("Строка является корректным скобочным выражением");
                Console.WriteLine("Максимальная глубина вложенности: " + (result + 1));
            }
            else
            {
                Console.WriteLine("Строка неверная");
            }
        }
    }
}
