using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkThreads
{
    internal class UncorrectPeterson
    {
        private static bool[] wantToEnter = new bool[2]; 
        private static int turn; 

        public static void Process(int id)
        {
            for (int i = 0; i < 5; i++) 
            {
                wantToEnter[id] = true; 
                turn = 1 - id;

                while (wantToEnter[1 - id] && turn == 1 - id)
                {

                }

                // Критическая секция
                Console.WriteLine($"Процесс {id} вошел в критическую секцию.");
                Thread.Sleep(10); 
                Console.WriteLine($"Процесс {id} вышел из критической секции.");
                wantToEnter[id] = false;
            }
        }
    }
}
