using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class HouseRobber
    {
        #region Top Down Answer
        //******************TOP DOWN***********************************
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        public int Rob(int[] nums)
        {
            return dp(nums.Length - 1, nums);
        }
        public int dp(int n, int[] nums)
        {
            if (d.ContainsKey(n)) return d[n];
            if (n == 0)
            {
                d.Add(0, nums[0]);
                return d[0];
            }
            if (n == 1)
            {
                d.Add(1, Math.Max(nums[0], nums[1]));
                return d[1];
            }

            d.Add(n, Math.Max(dp(n - 1, nums), dp(n - 2, nums) + nums[n]));
            return d[n];

        }
        #endregion

        #region Bottom Up Answer

        //******************BUTTOM UP***********************************
        public int Rob_ButtomUP(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, nums.Length + 1).ToArray();
            arr[0] = nums[0];
            arr[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = Math.Max(arr[i], arr[i - 2] + arr[i]);
            }

            return arr[nums.Length - 1];
        }
        #endregion

        #region 06/25/2022 Review

        Dictionary<int, int> dic_r1 = new Dictionary<int, int>() { };
        public int td_r1(int[] nums)
        {
            return helper_r1(nums.Length-1, nums);
        }
        public int helper_r1(int i,int[] nums)
        {
            if (dic_r1.ContainsKey(i)) return dic_r1[i];
            if(i == 0)
            {
                dic_r1.Add(0, nums[0]);
            }else if(i == 1)
            {
                dic_r1.Add(1, Math.Max(nums[0], nums[1]));
            }
            else
            {
                dic_r1.Add(i, Math.Max(helper_r1(i - 1, nums), helper_r1(i - 2,nums) + nums[i]));
            }
            return dic_r1[i];
        }

        public int bu_r1(int[] nums)
        {
            int[] arr = Enumerable.Repeat(0, nums.Length).ToArray();
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
            arr[0] = nums[0];
            arr[1] = Math.Max(nums[0], nums[1]);
            for(int i =2;i < nums.Length; i++)
            {
                arr[i] = Math.Max(arr[i - 1], arr[i - 2] + nums[i]);
            }
            return arr[nums.Length - 1];
        }

        public int bu_r1_constant(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int avoid = nums[0];
            int m = nums[1];

            for (int i = 2; i < nums.Length; i++)
            {
                int temp = Math.Max(avoid, m);
                m = avoid + nums[i];
                avoid = temp;
            }
            return Math.Max(m,avoid);
        }
        #endregion
    }
}
