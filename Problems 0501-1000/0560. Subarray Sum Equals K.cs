using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0560
    {
        #region Solution
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += subArray(nums, i, k);
            }
            return count;
        }
        public int subArray(int[] nums, int start, int k)
        {
            int sum = 0;
            int count = 0;
            while (start < nums.Length)
            {
                sum += nums[start];
                if (sum == k)
                {
                    count++;
                }
                start++;
            }
            return count;
        }
        #endregion

        #region 02/05/2022
        public int SubarraySum2(int[] nums, int k)
        {
            int curSum = 0;
            int count = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            foreach (int n in nums)
            {
                curSum += n;
                if (curSum == k)
                {
                    count++;
                }
                if (dic.ContainsKey(curSum - k))
                {
                    count += dic[curSum - n];
                }
                if (dic.ContainsKey(curSum)) dic[curSum]++;
                else dic[curSum] = 1;
            }
            return count;
        }
        //02/05/2022
        public int SubarraySum2_R2(int[] nums, int k)
        {
            int sum = 0; int count = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            dic.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dic.ContainsKey(sum - k))
                {
                    count += dic[sum - k];
                }
                if (dic.ContainsKey(sum)) dic[sum]++;
                else dic.Add(sum, 1);
            }
            return count;

        }
        #endregion

        #region 09/11/2023
        public int SubarraySum_20230911(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            int c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
        #endregion

        #region 09/12/2023  Dictionary approach

        public int SubarraySum_20230912(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            //smart move
            dic.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dic.ContainsKey(sum - k))
                {
                    count += dic[sum - k];
                }

                if (dic.ContainsKey(sum))
                {
                    dic[sum]++;
                }
                else
                {
                    dic.Add(sum, 1);
                }
            }
            return count;

        }


        #endregion

        #region 10/06/2024 if no adding add(0,1) as default, then need to calculate sum =k scenario
        public int SubarraySum_2024_10_06(int[] nums, int k)
        {
            Dictionary<int,int> dic = new Dictionary<int, int> { };

            int sum = 0;
            int count = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
                if( sum == k)
                {
                    count++;
                }
                if(dic.ContainsKey(sum - k))
                {
                    count += dic[sum - k];
                }

                if (dic.ContainsKey(sum))
                {
                    dic[sum]++;
                }
                else
                {
                    dic.Add(sum, 1);
                }
            }

            return count;

        }
        #endregion 



















































    }
}
