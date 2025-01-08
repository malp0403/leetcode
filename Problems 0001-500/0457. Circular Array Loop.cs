using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_0001_500._0451_0500
{
    class _0457
    {
        #region my attempt
        public bool CircularArrayLoop(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>() { };
            bool ans = false;
            for(int i =0; i< nums.Length; i++)
            {
                if (!seen.Contains(i))
                {
                    HashSet<int> set = new HashSet<int>() { };
                    ans = ans || helper_attempt(i, nums[i] >= 0, set, nums);
                    foreach (var item in set)
                    {
                        seen.Add(item);
                    }
                }

                

            }
            return ans;
        }
        public bool helper_attempt(int index,bool forwards,HashSet<int> set, int[] nums)
        {
            if (set.Contains(index)) return true;

            int reminder = (index + nums[index]) % nums.Length;

            int nextIndex = reminder>=0? reminder: (reminder + nums.Length);
            if ( index == nextIndex) return false;
            if (forwards && nums[nextIndex] < 0) return false;
            if (!forwards && nums[nextIndex] >= 0) return false;

            set.Add(index);
            return helper_attempt(nextIndex, forwards, set, nums);
        }


        #endregion

    }
}
