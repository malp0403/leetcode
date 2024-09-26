using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0852
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            for(int i =0;i< arr.Length; i++)
            {
                if(i+1 < arr.Length && arr[i ] < arr[i+1])
                {
                    return i;
                }
            }
            return arr.Length - 1;
        }
        // **************** binary search**********************
        public int PeakIndexInMountainArray_BinarySearch(int[] arr)
        {
            int lo = 0;
            int high = arr.Length-1;
            while (lo < high)
            {
                int mid = lo + (high - lo) / 2;
                if (arr[mid] < arr[mid +1])
                {

                    lo = mid+1;
                }else{
                    high = mid;
                }
            }
            return lo;
        }

    }
}
