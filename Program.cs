
using System;
using System.Collections.Generic;

namespace livecoding3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> myArr = ZipArray({ 1, 3, 5}, { 2, 4, 6});


        }

        public static List<int> ZipArray(List<int> arrOne, List<int> arrTwo)
        {
            List<int> newArr = new List<int>();
            for (int i = 0; i < arrOne.Count - 1; i++)
            {
                newArr.Add(arrOne[i]);
                newArr.Add(arrTwo[i]);
            }
            return newArr;
        }
    }




}
