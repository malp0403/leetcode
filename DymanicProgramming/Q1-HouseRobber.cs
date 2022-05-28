using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.DymanicProgramming
{
    class HouseRobber
    {
        //******************TOP DOWN***********************************
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        public int Rob(int[] nums)
        {
            return dp(nums.Length - 1,nums);
        }
        public int dp(int n,int[] nums)
        {
            if (d.ContainsKey(n)) return d[n];
            if (n == 0) {
                d.Add(0, nums[0]);
                return d[0];
            }
            if (n == 1) {
                d.Add(1, Math.Max(nums[0],nums[1]));
                return d[1];
            }

            d.Add(n, Math.Max(dp(n - 1, nums), dp(n - 2, nums) + nums[n]));
            return d[n];
            
        }
        //******************BUTTOM UP***********************************
        public int Rob_ButtomUP(int[] nums) {
            int[] arr = Enumerable.Repeat(0, nums.Length + 1).ToArray();
            arr[0] = nums[0];
            arr[1] = Math.Max(nums[0], nums[1]);
            for (int i =2; i < arr.Length; i++)
            {
                arr[i] = Math.Max(arr[i], arr[i - 2] + arr[i]);
            }

            return arr[nums.Length-1];
        }

    }
}
