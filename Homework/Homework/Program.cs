using System.Text.RegularExpressions;
using HomeworkBinarySearch;
using HomeworkBubbleSort;
using HomeworkArrays;
using HomeworkBrackets;
using HomeworkStrings;
using Homework.OOP;
using Homework.OOP.GeometryShapes;
using Homework.OOP.Hierarchy;
using HomeworkThreads;


namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 21.11
            BinarySearch.DoBinarySearch();
            BubbleSort.DoBubbleSort();
            MostLongSubArray.DoMostLongSubArray();
            EnclosureBrackets.DoEnclosureBrackets();
            ReverseArray.DoReverseArray();
            */

            /* 28.11
            StringIsDigit.DoStringIsDigit();
            CapitalizationString.DoCapitalizationString();
            StringPalindrome.DoStringPalindrome();
            StringAnagram.DoStringAnagram();
            */

            /*2.12
            OwnDescriptionClass EgorImmutable = new OwnDescriptionClass();
            Console.WriteLine($"Name: {EgorImmutable.Name}," +
                $" Surname: {EgorImmutable.Surname}," +
                $" Age: {EgorImmutable.Age}");

            OwnDescriptionStruct EgorChangeable = new OwnDescriptionStruct(2500, System.Drawing.Color.Brown);
            Console.WriteLine($"DotaMMR: {EgorChangeable.DotaMMR}, " +
                $"HairColor: {EgorChangeable.HairColor}");
            */

            /* 16.12 
            Rectangle rectangle = new Rectangle(10, 5);
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();

            Circle circle = new Circle(5);
            circle.CalculateArea();
            circle.CalculatePerimeter();

            Triangle triangle = new Triangle(2, 5, 10, 5);
            triangle.CalculateArea();
            triangle.CalculatePerimeter();



            var b = new B();
            var c = new C();
            ((A)c).PrintMessage(); //A
            ((A)b).PrintMessage(); //B
            c.PrintMessage();
            */


            //2 семестр


            /*28.04
            
            //задача
            ArrayThread arrayThread = new ArrayThread();
            int n = 100000;
            int m = 5;
            arrayThread.RandomArray(n);
            arrayThread.Calculate(m);
            arrayThread.PrintSum();

            //корректный
            Thread process0 = new Thread(() => CorrectPeretson.Process(0));
            Thread process1 = new Thread(() => CorrectPeretson.Process(1));

            process0.Start();
            process1.Start();

            process0.Join();
            process1.Join();


            //некорректный (без volatile)
            Thread process3 = new Thread(() => UncorrectPeterson.Process(0));
            Thread process4 = new Thread(() => UncorrectPeterson.Process(1));

            process3.Start();
            process4.Start();

            process3.Join();
            process4.Join();
            */
            
        }
    }
}
