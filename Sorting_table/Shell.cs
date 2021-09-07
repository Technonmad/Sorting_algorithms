using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_table
{
    class Shell
    {
        int tmp, j;
        public void DoSorting(int[] arr)
        {
            for(int step = arr.Length / 2; step > 0; step /= 2)
            {
                for(int i = step; i < arr.Length; i++)
                {
                    tmp = arr[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp < arr[j - step])
                            arr[j] = arr[j - step];
                        else
                            break;
                    }
                    arr[j] = tmp;
                }
            }
        }
    }
}
