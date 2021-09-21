using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_table
{
    class Shell
    {
        int tmp, j, process;
        public delegate void Progress(int x);
        public Progress progress;
        public void DoSorting(int[] arr)
        {
            progress(0);
            for (int step = arr.Length / 2; step > 0; step /= 2)
            {
                process = step * 100 / arr.Length;
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
                progress(process);
            }
            progress(100);
        }
    }
}
