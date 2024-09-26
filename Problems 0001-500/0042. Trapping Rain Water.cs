using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems
{
    class _0042  // 3 SOLUTIONS: left-right array, stack , two pointers
    {
       
        #region LeetCode Approach 2: Dynamic Programming
        public int Trap_DP(int[] height)
        {
            int[] left = Enumerable.Repeat(0, height.Length).ToArray();
            int[] right = Enumerable.Repeat(0, height.Length).ToArray();
            left[0] = height[0];
            for(int i =1; i < height.Length; i++)
            {
                left[i] = Math.Max(height[i], left[i - 1]);
            }
            right[height.Length - 1] = height[height.Length - 1];
            for(int i = height.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Max(height[i], right[i + 1]);
            }
            int ans = 0;
            for(int i =0; i < height.Length; i++)
            {
                ans += Math.Min(left[i], right[i]) - height[i];
            }
            return ans;
        }

        #endregion

        #region LeetCode Approach 3: Using stacks

        #endregion

        #region LeetCode Approach 4: Using 2 pointers

        #endregion

        #region My Attempt: 1. find the highest, loop from 0->highest, then loop from end -> highest
        public int Trap(int[] height)
        {
            int maxIndex = 0; ;
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                    maxIndex = i;
                }
            }

            //left part
            int area = 0;
            int cur = height[0];
            int startIndx = 0;
            for (int i = 0; i <= maxIndex; i++)
            {
                if (height[i] < cur)
                {
                    continue;
                }
                else
                {
                    area += helper(startIndx, i, height);
                    cur = height[i];
                    startIndx = i;
                }
            }
            cur = height[height.Length - 1];
            startIndx = height.Length - 1;
            for (int i = height.Length - 1; i >= maxIndex; i--)
            {
                if (height[i] < cur)
                {
                    continue;
                }
                else
                {
                    area += helper(i, startIndx, height);
                    cur = height[i];
                    startIndx = i;
                }
            }
            return area;


        }
        public int helper(int start, int end, int[] height)
        {
            int sum = 0;
            int wall = Math.Min(height[start], height[end]);
            if (wall == 0) return 0;
            for (int i = start + 1; i < end; i++)
            {
                sum += wall - height[i];
            }
            return sum;
        }
        #endregion

        #region 12/28/2022
        public int Trap_20221228(int[] height)
        {
            //find the peek
            int peek = 0;
            int peekIndex = -1;
            for(int i =0; i < height.Length; i++)
            {
                if(height[i] > peek)
                {
                    peek = height[i];
                    peekIndex = i;
                }
            }
            if (peekIndex == -1) return 0;
            int sum = 0;
            //for left to peek;
            int startIndex = 0;
            for(int i =0; i <= peekIndex; i++)
            {
                if(height[i] < height[startIndex] || startIndex == i)
                {
                    continue;
                }
                else
                {
                    sum += helper_20221228(startIndex, i, height);
                    startIndex = i;
                }
            }
            int startIndex2 = height.Length-1;
            for(int j = height.Length-1;j >= peekIndex; j--)
            {
                if (height[j] < height[startIndex2] || startIndex2 == j)
                {
                    continue;
                }else
                {
                    sum += helper_20221228(j, startIndex2, height);
                    startIndex2 = j;
                }
            }
            return sum;
        }
        public int helper_20221228(int start, int end, int[] height)
        {
            if (height[start] == 0 || height[end] == 0) return 0;
            int wall = Math.Min(height[start], height[end]);
            int sum = 0;
            for(int i = start+1; i < end; i++)
            {
                sum += (wall - height[i]);
            }
            return sum;

        }
        #endregion

        #region 07/25/2023 DP
        public int Trap_20230725(int[] height)
        {
            int[] left = Enumerable.Repeat(0, height.Length).ToArray();
            int[] right = Enumerable.Repeat(0, height.Length).ToArray();

            for(int i =0; i < height.Length;i++)
            {
                if (i == 0) { left[i] = height[i]; }
                else
                {
                    left[i] = Math.Max(left[i - 1],height[i]);
                }
            }

            for (int i = height.Length-1; i >=0; i--)
            {
                if (i == height.Length-1) { right[i] = height[i]; }
                else
                {
                    right[i] = Math.Max(right[i +1], height[i]);
                }
            }
            int max = 0;
            for(int i =0; i < height.Length;i++)
            {
                max += (Math.Min(left[i], right[i])>0?Math.Min(left[i], right[i]) - height[i] : 0);
            }
            return max;
        }



        #endregion

        #region 07/26/2023
        public int Trap_20230726_stack(int[] height)
        {
            int ans = 0; int current = 0;
            Stack<int> stack = new Stack<int>();
            while (current < height.Length)
            {
                while (stack.Count > 0 && height[current] > height[stack.Peek()])
                {
                    int top = stack.Peek();
                    stack.Pop();
                    if (stack.Count == 0) { break; }
                    int dis = current - stack.Peek() - 1;
                    int bounded = Math.Min(height[current], height[stack.Peek()]) - height[top];
                    ans += dis * bounded;
                }
                stack.Push(current++);
            }
            return ans;
        }
        #endregion

        #region 07/26/2023 two pointers
        public int Trap_20230726_twoPointers(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int ans = 0;

            int left_max = 0;
            int right_max = 0;


            while (left < right) {
                if (height[left] <= height[right])
                {
                    if (height[left]> left_max)
                    {
                        left_max = height[left];
                    }
                    else
                    {
                        ans += (left_max - height[left]);
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= right_max)
                    {
                        right_max = height[right];
                    }
                    else
                    {
                        ans += right_max - height[right]; 
                    }
                    right--;
                }
            }
            return ans;
        }

        #endregion

        #region 08/06/2023
        public int Trap_20230806_leftRightArray(int[] height)
        {
            int[] left = Enumerable.Repeat(0, height.Length).ToArray();
            int[] right = Enumerable.Repeat(0, height.Length).ToArray();

            for(int i =0;i  < height.Length; i++)
            {
                if (i == 0) left[i] = height[i];
                else
                {
                    left[i] = Math.Max(left[i - 1], height[i]);
                }
            }

            for (int i = height.Length-1; i >=0; i--)
            {
                if (i ==height.Length-1) right[i] = height[i];
                else
                {
                    right[i] = Math.Max(right[i + 1], height[i]);
                }
            }
            int sum = 0;
            for(int i =0; i <  height.Length; i++)
            {
                sum += (Math.Min(left[i], right[i]) - height[i]);
            }
            return sum;
        }

        #endregion

        #region 08/06/2023 stack
        public int Trap_20230806_stack(int[] height)
        {
            Stack<int> stack = new Stack<int>() { };

            int index = 0;
            int sum = 0;
            while(index < height.Length)
            {
                while(stack.Count!=0 && height[index] > height[stack.Peek()])
                {
                    int bottom = stack.Peek();
                    stack.Pop();
                    if (stack.Count == 0) break;
                    int d = index - stack.Peek() - 1;
                    int bounded = Math.Min(height[index], height[stack.Peek()])-bottom;
                    sum += d * bounded;
                }

                stack.Push(index++);
              
            }
            return sum;
        }
        #endregion

        #region 08/06/2023 two pointers

        public int Trap_20230806_twopointers(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int leftMax = 0;
            int rightmax = 0;

            int sum = 0;
            while(left < right)
            {
                if (height[left]< height[right])
                {
                    if(height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        sum += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightmax)
                    {
                        rightmax = height[right];
                    }
                    else
                    {
                        sum += rightmax - height[right];
                    }
                    right--;
                }
            }
            return sum;
        }
        #endregion

        #region 02/19/2024
        public int Trap_2024_02_19(int[] height)
        {
            int[] left = Enumerable.Repeat(0,height.Length).ToArray();
            int[] right= Enumerable.Repeat(0, height.Length).ToArray();

            for (int i =1;i <height.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], height[i-1]);
            }

            for (int i = height.Length-2; i >=0; i--)
            {
                right[i] = Math.Max(right[i + 1], height[i + 1]);
            }
            int sum = 0;
            for(int i =0; i <height.Length; i++)
            {
                int max = Math.Min(right[i], left[i]);
                sum += max > height[i] ? max - height[i] : 0;
            }
            return sum;
        }
        #endregion
    }
}
