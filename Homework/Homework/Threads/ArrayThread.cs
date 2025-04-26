using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkThreads
{
    internal class ArrayThread
    {
        private int[] array;
        private int sum;
        //List<Thread> threads = new List<Thread>();
        private object lockObject = new object();

        public void RandomArray(int n)
        {
            array = new int[n];

            int[] timeArr = new int[n];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }

        public void Calculate(int m)
        {
            int part = array.Length / m;
            Task[] threads = new Task[m];

            for (int i = 0; i < m; i++)
            {
                int start = i * part;
                int end = (i == m - 1) ? array.Length : start + part;

                threads[i] = Task.Run(() =>
                {
                    int partSum = 0;
                    for (int j = start; j < end; j++)
                    {
                        sum += array[j];
                    }

                   
                    lock (lockObject)
                    {
                        sum += partSum;
                    }
                });
            }
            Task.WaitAll(threads);
        }

        public void PrintSum()
        {
            Console.WriteLine(sum);
        }
    }
}
