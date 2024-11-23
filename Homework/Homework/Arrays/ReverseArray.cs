using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    internal class ReverseArray
    {
        public static void DoReverseArray()
        {
            Console.WriteLine("Напишите размер массива");

            //размер массива
            int sizeOfArr;

            //проверка введенного числа
            try
            {
                string sizeOfArrUser = Console.ReadLine();
                sizeOfArr = Convert.ToInt32(sizeOfArrUser);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректное число");
                throw;
            }

            int[] arr = new int[sizeOfArr];

            Console.WriteLine("Введите значения в массив:");

            //вспомогательная переменная для ввода в массив пользователем
            int arrElement;

            //ввод массива от пользователя
            for (int i = 0; i < sizeOfArr; i++)
            {
                try
                {
                    string temp = Console.ReadLine();
                    arrElement = Convert.ToInt32(temp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректное значение в массив");
                    throw;
                }

                arr[i] = arrElement;
            }

            //метод переворота массива
            int[] ArrayReverse(int[] array)
            {
                for (int i = 0, j = array.Length - 1; i < j; i++, j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

                return array;
            }

            //вызов метода переворота массива
            ArrayReverse(arr);


            Console.WriteLine("Развернутый массив выглядит так: ");

            //вывод перевернутого массива пользователю
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
