using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2051_2100
{
    internal class _2098
    {
        #region 10/09/2023 TLE
        long max = long.MinValue;
        public long LargestEvenSum(int[] nums,int k)
        {
            Array.Sort(nums);
            PriorityQueue<int,int> q = new PriorityQueue<int, int> ();
            foreach (var item in nums)
            {
                q.Enqueue(item, -item);
            }

            helper(nums.Length - 1, 0, k, nums);
            return max != long.MinValue ? max : -1;
        }
        public void helper(int index, long curSum,int remaining,int[] nums)
        {
            if(remaining == 0)
            {
                if(curSum %2 == 0)
                {
                    max = Math.Max(curSum, max);
                }
                return;
            }
            if (index == -1) return;

            helper(index - 1, curSum + nums[index], remaining - 1, nums);
            helper(index - 1, curSum, remaining, nums);

        }
        #endregion
         
        #region solution2  Divide into two array
        public long LargestEvenSum_solution2(int[] nums,int k)
        {
            List<int> odds = new List<int> ();
            List<int> even = new List<int>();
            Array.Sort(nums);
            foreach (var item in nums)
            {
                if (item % 2 == 0) even.Add(item);
                else odds.Add(item);
            }

            long[] oddArray = Enumerable.Repeat((long)0,odds.Count+1).ToArray();
            for(int i =1;i <oddArray.Length; i++)
            {
              oddArray[i] = oddArray[i-1] + odds[odds.Count-i];          
            }
            long[] evenArray = Enumerable.Repeat((long)0, even.Count + 1).ToArray();
            for (int i = 1; i < evenArray.Length; i++)
            {
                evenArray[i] = evenArray[i - 1] + even[even.Count - i];      
            }


            long answer = long.MinValue;
            for(int i =0; i < oddArray.Length;)
            {
                if( k-i < evenArray.Length && k-i >=0)
                {
                    answer = Math.Max(oddArray[i] + evenArray[k - i], answer);
                }

                i += 2;
            }


            return answer != long.MinValue?answer:-1;

           
         }
        #endregion
    }
}
