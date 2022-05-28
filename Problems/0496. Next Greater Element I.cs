using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            Stack<int> stack = new Stack<int>() { };
            for (int i = 0; i < nums2.Length; i++)
            {
                var n = nums2[i];
                if (stack.Count != 0 && nums2[i] > stack.Peek())
                {
                    while (stack.Count != 0 && nums2[i] > stack.Peek())
                    {
                        dic.Add(stack.Pop(), nums2[i]);
                    }
                }
                stack.Push(nums2[i]);
            }
            while (stack.Count != 0)
            {
                dic.Add(stack.Pop(), -1);
            }
            List<int> list = new List<int>() { };
            for(int i =0; i < nums1.Length; i++)
            {
                list.Add(dic[nums1[i]]);
            }

            return list.ToArray();
            

        }
    }

}
