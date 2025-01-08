using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0215
    {
        #region LeetCode Approach 2: Min-Heap(Priority Queue)
        #endregion
        #region LeetCode Approach 3: Quickselect
        #endregion

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

            for (int i = 1; i < list.Count; i++)
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
            if (bigger.Count > k - 1)
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
            for (int i = 0; i < nums.Length; i++)
            {
                if (q.Count < k) { q.Enqueue(nums[i], nums[i]); }
                else
                {
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

        #region 07/07/2024
        public int FindKthLargest_2024_07_07(int[] nums, int k)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (queue.Count < k) queue.Enqueue(nums[i], nums[i]);
                else
                {
                    if (queue.Peek() > nums[i]) continue;
                    else
                    {
                        queue.Dequeue();
                        queue.Enqueue(nums[i], nums[i]);
                    }
                }
            }
            return queue.Peek();
        }
        #endregion

        #region 07/07/2024_quickSelect
        public int FindKthLargest_2024_07_07_quickSelect(int[] nums, int k)
        {
            return helper_2024_07_07(nums.ToList(), k);
        }
        public int helper_2024_07_07(List<int> list, int k)
        {
            int pivot = list[new Random().Next(0, list.Count - 1)];
            List<int> bigger = new List<int>();
            List<int> mid = new List<int>();
            List<int> smaller = new List<int>();
            foreach (int i in list)
            {
                if (i < pivot)
                {
                    smaller.Add(i);
                }
                else if (i > pivot)
                {
                    bigger.Add(i);
                }
                else
                {
                    mid.Add(i);
                }
            }
            if (bigger.Count >= k)
            {
                return helper_2024_07_07(bigger, k);
            }
            if (bigger.Count + mid.Count < k)
            {
                return helper_2024_07_07(smaller, k - bigger.Count - mid.Count);
            }

            return pivot;

        }
        #endregion

        #region 09/28/2024 Quick Select Smaller; mid; bigger
        public int FindKthLargest_2024_09_28_QuickSelect(int[] nums, int k)
        {
            return helper_2024_09_28(nums.ToList(), k);
        }
        public int helper_2024_09_28(List<int> list, int k)
        {
            int pivote = list[new Random().Next(0, list.Count - 1)];
            List<int> bigger = new List<int>();
            List<int> smaller = new List<int>();
            List<int> middle = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < pivote)
                {
                    smaller.Add(list[i]);
                }
                else if (list[i] > pivote)
                {
                    bigger.Add(list[i]);
                }
                else
                {
                    middle.Add(list[i]);
                }
            }

            if (bigger.Count >= k)
            {
                return helper_2024_09_28(bigger, k);
            }
            else if (bigger.Count + middle.Count < k)
            {
                return helper_2024_09_28(smaller, k - bigger.Count - middle.Count);
            }

            return pivote;

        }

        #endregion

        #region 10/02/2024
        public int FindKthLargest_2024_10_02(int[] nums, int k)
        {
            List<int> list = new List<int>();
            return helper_2024_10_02(nums.ToList(), k);

        }
        public int helper_2024_10_02(List<int> list, int k)
        {
            int pivot = list[new Random().Next(0, list.Count)];
            List<int> bigger = new List<int>();
            List<int> mid = new List<int>();
            List<int> smaller = new List<int>();

            foreach (int i in list)
            {
                if (i > pivot)
                {
                    bigger.Add(i);
                }
                else if (i < pivot)
                {
                    smaller.Add(i);
                }
                else { mid.Add(i); }
            }

            if (bigger.Count >= k)
            {
                return helper_2024_10_02(bigger, k);
            }
            else if (bigger.Count + mid.Count < k)
            {
                return helper_2024_10_02(smaller, k - (bigger.Count + mid.Count));
            }
            return pivot;
        }


        #endregion

        #region 10/06/2024 quick select
        public int FindKthLargest_2024_10_06(int[] nums, int k)
        {
            return helper_2024_10_05(nums.ToList(), k);
        }

        public int helper_2024_10_05(List<int> list, int k)
        {
            List<int> mid = new List<int>();
            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();

            int index= new Random().Next(0, list.Count);
            int pivot = list[index];

            foreach (var item in list)
            {
                if(item == pivot)
                {
                    mid.Add(item);
                }else if(item < pivot)
                {
                    smaller.Add(item);
                }
                else { bigger.Add(item); }
            }

            if(bigger.Count >= k)
            {
                return helper_2024_10_05(bigger, k);
            }else if( bigger.Count + mid.Count < k)
            {
                return helper_2024_10_05(smaller, k - bigger.Count - mid.Count);
            }
            return pivot;
        }
        #endregion




    }
}