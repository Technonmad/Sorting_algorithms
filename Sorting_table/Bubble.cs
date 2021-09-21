using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_table
{
    class Bubble
    {

        public delegate void Progress(int x);
        public Progress progress;
        
        public void DoSorting(int[] arr)
        {
            progress(0);
            int tmp, process;
            for (int i = 0; i < arr.Length; i++)
            {
                process = i * 100 / arr.Length;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
                progress(process);
            }
            progress(100);
        }

    }
}
