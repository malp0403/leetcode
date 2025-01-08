using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000
{
    internal class _2542
    {
        #region 2024/09/28  sort nums12 based on nums, priority queue on nums1
        public long MaxScore_2024_09_28(int[] nums1, int[] nums2, int k)
        {
            int n = nums2.Length;

            int[][] nums12 = new int[n][];
            for (int i = 0; i < n; i++)
            {
                nums12[i] = new int[2] { nums1[i], nums2[i] };
            }
            PriorityQueue<int,int> queue = new PriorityQueue<int, int>();

            Array.Sort(nums12, (a, b) => b[1] - a[1]);
            long sum = 0;
            long res = 0;

            for(int i =0;i < n; i++)
            {
                sum += nums12[i][0];

                queue.Enqueue(nums12[i][0], nums12[i][0]);
                if(queue.Count > k) {  
                 sum -= queue.Dequeue();
                }
                if(queue.Count == k) {

                    res = Math.Max(res, sum * nums12[i][1]);
                }
            }

            return (long)res;
            
        }
        #endregion
    }
}