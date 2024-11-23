using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    internal class MostLongSubArray
    {
        public static void DoMostLongSubArray()
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

            //повторяющеяся число
            int answer = 0;

            //количество повторяющегося числа
            int counterOfRepeatNumber = 1;

            //вспомогательная переменная для сохранения количества максимальной длины подмассива
            int MaxLengthOfNumber = 1;

            //поиск подмассива
            for (int i = 1; i < sizeOfArr; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    counterOfRepeatNumber += 1;
                }

                if (counterOfRepeatNumber > MaxLengthOfNumber)
                {
                    MaxLengthOfNumber = counterOfRepeatNumber;
                    answer = arr[i];
                }
            }

            Console.WriteLine("Самый длинный подмассив из одинаковых чисел: ");


            //вывод найденного подмассива
            for (int i = 0; i < MaxLengthOfNumber; i++)
            {
                Console.Write(answer + " ");
            }
        }
    }
}
