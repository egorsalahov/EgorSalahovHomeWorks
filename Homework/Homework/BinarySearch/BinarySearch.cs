using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBinarySearch
{
    internal class BinarySearch
    {
        public static void DoBinarySearch()
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

            //Сортировка массива перед бинарным поиском
            for (int i = 0; i < sizeOfArr; i++)
            {
                for (int j = 0; j < sizeOfArr - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Введите число, которое Вам нужно найти в массиве: ");

            //переменная для ввода
            int numFind;

            //проверка введенного числа
            try
            {
                string temp = Console.ReadLine();
                numFind = Convert.ToInt32(temp);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неккоректное число");
                throw;
            }

            //бинарный поиск

            //границы
            int left = 0;
            int right = sizeOfArr - 1;
            int middle = 0;

            int result = -1;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (arr[middle] == numFind)
                {
                    result = numFind;
                    break;
                }

                if (arr[middle] < numFind)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (result != -1)
            {
                Console.WriteLine("Индекс искомого числа: " + middle);
            }
            else
            {
                Console.WriteLine("В массиве отсутсвует введный элемент");
            }

        }
    }
}
