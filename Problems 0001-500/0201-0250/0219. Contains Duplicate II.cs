using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, Stack<int>> dic = new Dictionary<int, Stack<int>>() { };
            for(int i =0; i < nums.Length; i++)
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
                    if( i - tempStack.Peek() <= k)
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
        public bool ContainsNearbyDuplicate_V2(int[] nums,int k)
        {
            HashSet<int> set = new HashSet<int>() { };
            for(int i=0; i < nums.Length; i++)
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
        //----------12-30-2021---------------
        public bool ContainsNearbyDuplicate_R2(int[] nums,int k)
        {
            Dictionary<int, Stack<int>> d = new Dictionary<int, Stack<int>>() { };
            for(int i=0; i < nums.Length ; i++)
            {
                if (!d.ContainsKey(nums[i]))
                {
                    var temp = new Stack<int>() { };
                    temp.Push(i);
                    d.Add(nums[i], temp);
                }
                else
                {
                    if(i-d[nums[i]].Peek() <= k)
                    {
                        return true;
                    }
                    d[nums[i]].Push(i);
                }
            }
            return false;
        }
    }
}
