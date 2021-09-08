using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_table
{
    class QuickSort
    {
        int partition(int[] array, int start, int end)
        {
            int marker = start;
            int ved = array[(start + end) / 2];
            int left = start;
            int right = end;
            while(left < right)
            {

                while (left < right && array[left] < ved)
                    left++;
                while (right > left && array[right] > ved)
                    right--;
                if(left <= right)
                {
                    int tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;

                    left++;
                    right--;
                }
            }
            return left;
        }

       public void DoSorting(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            DoSorting(array, start, pivot - 1);
            DoSorting(array, pivot + 1, end);
        }
    }
}
