using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0215
    {
        #region Sort Solution
        public int findKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        #endregion

        #region 08/14/2023 Stack, Time limit Exceed
        public int FindKthLargest(int[] nums, int k)
        {
            Stack<int> stack = new Stack<int>() { };

            for (int i = 0; i < nums.Length; i++)
            {
                if (stack.Count < k)
                {
                    if (stack.Count == 0 || stack.Peek() >= nums[i]) stack.Push(nums[i]);
                    else
                    {
                        Stack<int> temp = new Stack<int>() { };
                        while (stack.Count != 0 && stack.Peek() < nums[i])
                        {
                            temp.Push(stack.Pop());
                        }
                        temp.Push(nums[i]);
                        while (temp.Count != 0)
                        {
                            stack.Push(temp.Pop());
                        }
                    }

                }
                else
                {
                    if (stack.Peek() >= nums[i]) continue;
                    else
                    {
                        stack.Pop();

                        Stack<int> temp = new Stack<int>() { };
                        while (stack.Count != 0 && stack.Peek() < nums[i])
                        {
                            temp.Push(stack.Pop());
                        }
                        temp.Push(nums[i]);
                        while (temp.Count != 0)
                        {
                            stack.Push(temp.Pop());
                        }
                    }
                }
            }

            return stack.Peek();
        }
        #endregion

        #region 08/14/2023
        public int FindKthLargest_20230814(int[] nums, int k)
        {
            List<int> l = nums.ToList();
            return helper(l, k);
        }

        public int helper(List<int> list, int k)
        {
            int temp = list[0];
            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();

            for (int i =1; i < list.Count; i++)
            {
                if (list[i] >= temp)
                {
                    bigger.Add(list[i]);
                }
                else
                {
                    smaller.Add(list[i]);
                }
            }

            if (bigger.Count == k - 1) return temp;
            if(bigger.Count > k - 1)
            {
                return helper(bigger, k);
            }
            else
            {
                return helper(smaller, k - bigger.Count - 1);
            }

        }
        #endregion

        #region 08/14/2023 PriorityQueue
        public int FindKthLargest_20230814_sortDic(int[] nums, int k)
        {
            PriorityQueue<int, int> q = new PriorityQueue<int, int>();
            for(int i =0;i < nums.Length; i++)
            {
                if(q.Count <k) { q.Enqueue(nums[i], nums[i]); }
                else {
                    if (q.Peek() > nums[i]) continue;
                    else
                    {
                        q.Dequeue();
                        q.Enqueue(nums[i], nums[i]);
                    }
                }
            }
            return q.Peek();
  
        }
        #endregion

    }
}