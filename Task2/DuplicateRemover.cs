using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DuplicateRemover
    {
        public int[] RemoveDuplicates(int[] array)
        {
            int n = array.Length;

            if (n == 0 || n == 1)
                return array;

            int uniqueCount = 1;
            for (int i = 1; i < n; i++)
            {
                if (array[i] != array[i - 1])
                    uniqueCount++;
            }

            int[] resultArray = new int[uniqueCount];
            resultArray[0] = array[0];
            int index = 1;

            for (int i = 1; i < n; i++)
            {
                if (array[i] != array[i - 1])
                {
                    resultArray[index] = array[i];
                    index++;
                }
            }

            return resultArray;
        }
        
    }
}
