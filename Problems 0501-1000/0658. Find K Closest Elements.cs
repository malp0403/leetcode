using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0658
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l < arr.Length && r >= 0)
            {
                if (r - l +1 <= k)
                {
                    break;
                }
                if(Math.Abs(arr[l]-x) <= Math.Abs(arr[r] - x) )
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            IList<int> li = new List<int>() { };
            for (int  i= l; i <=r; i++)
            {
                li.Add(arr[i]);
            }
            return li;

        }
    }
}
