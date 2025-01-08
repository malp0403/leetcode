using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0739
    {
        #region Solution
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] dp = Enumerable.Repeat(0, temperatures.Length).ToArray();
            for (int i = 0; i < dp.Length; i++)
            {
                int prev = temperatures[i];
                int count = 1;
                int start = i + 1;
                while (start < dp.Length)
                {
                    if (temperatures[start] > prev)
                    {
                        dp[i] = count;
                        break;
                    }
                    start++;
                    count++;
                }
            }
            return dp;
        }

        public int[] DailyTemperatures2(int[] temperatures)
        {

            Stack<int> stack = new Stack<int>() { };
            int[] answer = Enumerable.Repeat(0, temperatures.Length).ToArray();

            for (int i = 0; i < temperatures.Length; i++)
            {

                while (stack.Count != 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int indx = stack.Pop();
                    answer[indx] = i - indx;
                }
                stack.Push(i);
            }
            return answer;

        }
        #endregion

        #region 01/06/2022
        //01-06-2022-----------------------------------------
        public int[] DailyTemperatures_R3(int[] temperatures)
        {
            Stack<(int t, int index)> stack = new Stack<(int t, int index)>() { };

            int[] ans = Enumerable.Repeat(0, temperatures.Length).ToArray();
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (stack.Count != 0 && temperatures[i] > stack.Peek().t)
                {
                    while (stack.Count != 0 && temperatures[i] > stack.Peek().t)
                    {
                        var data = stack.Pop();
                        ans[data.index] = i - data.index;
                    }
                }

                stack.Push((temperatures[i], i));

            }
            return ans;
        }
        //---------------------------------------------------
        #endregion

        #region 09/30/2024
        public int[] DailyTemperatures_2024_09_30(int[] temperatures)
        {
            Stack<(int temp, int index)> stack = new Stack<(int temp, int index)>();

            int[] ans = Enumerable.Repeat(0, temperatures.Length).ToArray();

            for (int i = 0; i < temperatures.Length; i++)
            {

                while (stack.Count > 0 && stack.Peek().temp < temperatures[i])
                {
                    var element = stack.Pop();
                    ans[element.index] = i - element.index;
                }

                stack.Push((temperatures[i], i));


            }
            return ans;
        }
        #endregion


    }
}
