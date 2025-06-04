using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.AsyncAwait
{
    internal class DeadLockResultClass
    {
        public static void DefalutMethod()
        {
            int result = AnotherMethodAsync().Result;
        }

        public static async Task<int> AnotherMethodAsync()
        {
            Console.WriteLine("Я в async методе");
            await Task.Delay(1000); //deadlock

            return 0;
        }
    }
}
