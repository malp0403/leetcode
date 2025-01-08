using System;
using System.Collections.Generic;
using System.Text;

#region Test Case
/*
             var obj = new _0219();
            obj.ContainsNearbyDuplicate_2024_07_07(new int[] { 1, 2, 3, 1, 2, 3 }, 2);

            obj.ContainsNearbyDuplicate_2024_07_07(new int[] { 4, 1, 2, 3, 1, 5 }, 3);


            obj.ContainsNearbyDuplicate_2024_07_07(new int[] { 4, 1, 2, 3, 1, 5 }, 3);
 */
#endregion

namespace leetcode.Problems
{
    class _0219
    {
        #region Solution
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, Stack<int>> dic = new Dictionary<int, Stack<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    var tempStack = new Stack<int>() { };
                    tempStack.Push(i);
                    dic.Add(nums[i], tempStack);
                }
                else
                {
                    var tempStack = dic[nums[i]];
                    if (i - tempStack.Peek() <= k)
                    {
                        return true;
                    }
                    else
                    {
                        tempStack.Push(i);
                    }
                }
            }
            return false;

        }

        //****************** set********************
        public bool ContainsNearbyDuplicate_V2(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;
                set.Add(nums[i]);
                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }
            return false;
        }
        #endregion

        #region 12/30/2021
        //----------12-30-2021---------------
        public bool ContainsNearbyDuplicate_R2(int[] nums, int k)
        {
            Dictionary<int, Stack<int>> d = new Dictionary<int, Stack<int>>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                if (!d.ContainsKey(nums[i]))
                {
                    var temp = new Stack<int>() { };
                    temp.Push(i);
                    d.Add(nums[i], temp);
                }
                else
                {
                    if (i - d[nums[i]].Peek() <= k)
                    {
                        return true;
                    }
                    d[nums[i]].Push(i);
                }
            }
            return false;
        }
        #endregion

        #region 07/07/2024
        public bool ContainsNearbyDuplicate_2024_07_07(int[] nums, int k)
        {
            Dictionary<int, List<int>> seen = new Dictionary<int, List<int>>();
            for(int i =0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(nums[i]))
                {
                    seen[nums[i]].Add(i);
                }
                else
                {
                    seen.Add(nums[i],new List<int> { i});
                }
            }
            foreach(var key in seen.Keys)
            {
                var list = seen[key];
                for(int i =1;i < list.Count; i++)
                {
                    if (list[i] - list[i-1] <= k) {
                        return true;
                    }

                }
            }
            return false;
        }
        #endregion

    }
}
