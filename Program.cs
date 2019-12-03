
using System;
using System.Collections.Generic;

namespace livecoding3
{
    class Program
    {
        static void Main(string[] args)
        {
            



        }
    }

    public List<int> ZipArray(List<int> arrOne, List<int> arrTwo)
    {
        List<int> newArr = new List<int>();
        for (int i = 0; i < arrOne.Count - 1; i++)
        {
            newArr.Add(arrOne[i]);

        }
        return newArr; 
    }


}
