using System;

namespace BubbleSortHomeWork
{
    internal class BubbleSort
    {
        public static void DoBubbleSort()
        {
            internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("�������� ������ �������");

                int sizeOfArr;

                try
                {
                    string sizeOfArrUser = Console.ReadLine();
                    sizeOfArr = Convert.ToInt32(sizeOfArrUser);
                }
                catch (Exception)
                {
                    Console.WriteLine("�� ����� ������������ �����");
                    throw;
                }

                int[] arr = new int[sizeOfArr];

                Console.WriteLine("������� �������� � ������:");

                //��������������� ���������� ��� ����� � ������ �������������
                int arrElement;

                //���� ������� �� ������������
                for (int i = 0; i < sizeOfArr; i++)
                {
                    try
                    {
                        string temp = Console.ReadLine();
                        arrElement = Convert.ToInt32(temp);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("�� ����� ������������ �������� � ������");
                        throw;
                    }

                    arr[i] = arrElement;
                }



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

                Console.WriteLine("��� ������: ");

                for (int i = 0; i < sizeOfArr; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
}