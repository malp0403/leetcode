using leetcode.Problems_2501_3000._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj2 = new _2333();
//obj2.MinSumSquareDiff_solution2(new int[] { 1, 4, 10, 12 }, new int[] { 5, 8, 6, 9 }, 10, 5);
#endregion

namespace leetcode.Problems_2501_3000._2301_2350
{
    internal class _2333
    {
        #region 10/03/2023 TLE

        long mininum = int.MaxValue;
        public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
        {
            helper(nums1, nums2, 0, k1, k2);
            return mininum;
        }

        public void helper(int[] nums1, int[] nums2,int index,int k1,int k2)
        {
            if (index == nums1.Length)
            {

                mininum = Math.Min(mininum, calculate(nums1,nums2));
                return;
            }

            helper(nums1, nums2, index + 1, k1, k2);

            if (nums1[index] > nums2[index])
            {
                if (k1 > 0)
                {
                    nums1[index]--;
                    helper(nums1, nums2, index,k1 - 1, k2);
                    nums1[index]++;
                }
                if (k2 > 0)
                {
                    nums2[index]++;
                    helper(nums1, nums2, index, k1, k2-1);
                    nums2[index]--;
                }
            }else if (nums1[index] < nums2[index]) {

                if (k1 > 0)
                {
                    nums1[index]++;
                    helper(nums1, nums2, index, k1 - 1, k2);
                    nums1[index]--;
                }
                if (k2 > 0)
                {
                    nums2[index]--;
                    helper(nums1, nums2, index, k1, k2 - 1);
                    nums2[index]++;
                }
            }
            
        }

        public long calculate(int[] nums1, int[] nums2)
        {
            long sum = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                sum += (long)Math.Pow(nums1[i] - nums2[i],2);
            }
            return sum;
        }
        #endregion

        #region decrease the highest difference; bucket
        public long MinSumSquareDiff_solution2(int[] nums1, int[] nums2, int k1, int k2)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>() { };
            for(int i =0; i < nums1.Length;i++)
            {
                int dis = Math.Abs(nums1[i] - nums2[i]);
                if (dis == 0) continue;
                if (dic.ContainsKey(dis))
                {
                    dic[dis]++;
                }
                else
                {
                    dic.Add(dis, 1);
                }
            }
            if (dic.Count == 0) return 0;

            int[] arr = Enumerable.Repeat(0,100001).ToArray();
            foreach (var item in dic.Keys)
            {
                arr[item] = dic[item];
            }

            int total = k1 + k2;
           for(int i = arr.Length - 1; i >= 1; i--)
            {
                if (arr[i] > 0)
                {
                    int minus = Math.Min(arr[i], total);
                    arr[i] -= minus;
                    arr[i - 1] += minus;
                    total -= minus;
                }
            }

            long sum = 0;
            for(int i =0; i < arr.Length; i++)
            {
                sum += (long)arr[i] * i * i;
            }
            return sum;


        }
        #endregion
    }
}
