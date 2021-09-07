using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_table
{
    class RandomArray
    {
        Random rand = new Random();

        public int[] makeArray(int n)
        {
            int[] random_Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                random_Array[i] = rand.Next(100000);
            }
            return random_Array;
        }
    }
}
