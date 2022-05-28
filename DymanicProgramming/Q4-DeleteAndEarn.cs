using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class Q4_DeleteAndEarn
    {
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
            for(int i =0; i < arr.Length; i++)
            {
                int m = Math.Max(use, avoid);
                if (arr[i] > 0)
                {
                    if(i == prev + 1)
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


    }
}
