using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_2001_2500
{
    internal class _2035
    {
        
        #region 10/09/2023 TLE
        int min_20231009 = int.MaxValue;
        public int MinimumDifference_20231009(int[] nums)
        {
            long total = 0;
            foreach (var item in nums)
            {
                total += item;
            }
            Array.Sort(nums);
            greed(nums, nums.Length - 1, 0, total,false,false,0);
            return min_20231009;

        }

        public void greed(int[] nums, int index, long curTotal, long total,bool hasRight,bool hasLeft,int count)
        {
            if (count > (nums.Length / 2)) return;
            if (index < 0)
            {
                if (count == (nums.Length / 2))
                {
                    int prevDif = (int)Math.Abs(total - curTotal -curTotal);
                    min_20231009 = Math.Min(prevDif, min_20231009);
                    Console.WriteLine(min_20231009);
           

                }
                return;
            };

            //take
            greed(nums, index - 1, curTotal + nums[index], total,true,hasLeft,count+1);
            greed(nums, index - 1, curTotal, total,hasRight,true,count);



        }
        #endregion
    }
}
