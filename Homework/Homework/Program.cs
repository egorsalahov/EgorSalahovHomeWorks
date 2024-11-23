﻿using System.Text.RegularExpressions;
using HomeworkBinarySearch;
using HomeworkBubbleSort;
using HomeworkArrays;
using HomeworkBrackets;
using Homework.Arrays;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch.DoBinarySearch();
            BubbleSort.DoBubbleSort();
            MostLongSubArray.DoMostLongSubArray();
            EnclosureBrackets.DoEnclosureBrackets();
            ReverseArray.DoReverseArray();
        }
    }
}
