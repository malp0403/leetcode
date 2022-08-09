using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q4_DeleteAndEarn
    {
        #region  Top Down Answer
        //***************TOP down******************
        int max = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public int DeleteAndEarn_TD(int[] nums) 
        {
            int[] arr = Enumerable.Repeat(0, 10001).ToArray();
            foreach (var num in nums)
            {
                arr[num]++;
            }
            return dp(10000, arr);

        }
        public int dp(int i,int[] arr)
        {
            if (i == 0) return 0;
            if (i == 1) return arr[i] * i;
            if (dic.ContainsKey(i)) return dic[i];
            int ans = Math.Max(dp(i - 1, arr), dp(i - 2, arr) + arr[i] * i);
            dic.Add(i, ans);
            return dic[i];
            
        }

        #endregion

        #region Bottom Up Answer
        //***************Bottom up******************
        public int DeleteAndEarn_BU(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, 10001).ToArray();
            foreach (var num in nums)
            {
                arr[num]++;
            }
            int prev = -1;
            int use = 0;
            int avoid = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int m = Math.Max(use, avoid);
                if (arr[i] > 0)
                {
                    if (i == prev + 1)
                    {
                        use = avoid + arr[i] * i;
                        avoid = m;
                    }
                    else
                    {
                        use = m + arr[i] * i;
                        avoid = m;
                    }
                    prev = i;
                }

            }
            return Math.Max(use, avoid);

        }

        #endregion

        #region 06/19/2022 Review
        Dictionary<int, int> dic_r2 = new Dictionary<int, int>() { };
        public int td_r1(int[] nums)
        {
            int[] sorted = Enumerable.Repeat(0, 10001).ToArray();
            foreach (var item in nums)
            {
                sorted[item]++;
            }

            return helper_r2(10000, sorted);

        }
        public int helper_r2(int n,int[] sorted)
        {
            if (dic_r2.ContainsKey(n)) return dic_r2[n];
            int result = 0;
            if (n == 1)
            {
                result = sorted[1];
            }else if (n == 2)
            {
                result = Math.Max(sorted[1], sorted[2] * 2);
            }
            else
            {
                result = Math.Max(helper_r2(n - 1, sorted), helper_r2(n - 2, sorted) + sorted[n] * n);
            }
            dic_r2.Add(n, result);
            return dic_r2[n];
        }

        public int bu_r1(int[] nums)
        {
            int[] sorted = Enumerable.Repeat(0, 10001).ToArray();
            foreach (var item in nums)
            {
                sorted[item]++;
            }

            int[] arr = Enumerable.Repeat(0, 10001).ToArray();

            int prev = -1;
            int use = 0;
            int avoid = 0;
            for(int i =0; i < sorted.Length; i++)
            {
                if(sorted[i] > 0)
                {
                    int m = Math.Max(use, avoid);
                    if(i == prev + 1)
                    {
                        use = avoid + sorted[i] * i;
                        avoid = m;
                    }
                    else
                    {
                        use = m + sorted[i] * i;
                        avoid = m;
                    }
                    prev = i;
                }
            }

            return Math.Max(use, avoid);



            //arr[1] = sorted[1];
            //arr[2] = Math.Max(sorted[1], sorted[2] * 2);

            //for(int i = 3; i <= 10000; i++)
            //{
            //    arr[i] = Math.Max(arr[i - 1], arr[i - 2] + sorted[i] * i);
            //}
            //return arr[10000];


        }

        #endregion

        #region 06/25/2022  Review2
        
        public int bu_r2(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, 100001).ToArray();
            foreach (var item in nums)
            {
                arr[item]++;
            }

            int[] memo = Enumerable.Repeat(0, 10001).ToArray();
            memo[1] = arr[1];
            memo[2] = Math.Max(arr[1],arr[2] * 2);
            for (int i = 3; i <= 10000; i++) {
                memo[i] = Math.Max(memo[i - 1], memo[i - 2] + arr[i] * i);
            }
            return memo[10000];
        }

        public int bu_r2_constant(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, 100001).ToArray();
            foreach (var item in nums)
            {
                arr[item]++;
            }

            int prevIndx = 0;
            int pre = 0;
            int cur = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    int best = Math.Max(cur, pre);
                    if (i == prevIndx + 1)
                    {
                        cur = pre + nums[i] * i;
                        pre = best;
                    }
                    else
                    {
                        cur = best+ nums[i]*i;
                        pre = cur;
                    }
                    prevIndx = i;
                }
            }

            return Math.Max(cur, pre); 
        }
        #endregion

    }
}
