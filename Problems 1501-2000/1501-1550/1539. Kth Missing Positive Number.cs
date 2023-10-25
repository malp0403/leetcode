using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1539
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int arrIndx = 0;
            int count = 0;
            int num = 1;
            while(count != k)
            {
                if((num!= arr[arrIndx] && arrIndx < arr.Length) || arrIndx>= arr.Length)
                {
                    count++;
                }
                else
                {
                    arrIndx++;
                }
                num++;
            }
            return num--;
        }

        public int FindKthPositive2(int[] arr, int k)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] - m - 1 < k)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return l + k;
        }

        //--------------12-23-2021--------------
        public int FindKthPositive_R3(int[] arr, int k) {
            int l = 0;
            int r = arr.Length - 1;
            if (arr[0] - 1 >= k) return k;
            if (arr[arr.Length - 1] - (arr.Length - 1) + 1 < k) return k + arr.Length - 2;
            while (l < r)
            {
                int mid = l + (l - r) / 2;

                if ((arr[mid] - (mid + 1)) < k)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }

            return l + k;
        }
    }
}
