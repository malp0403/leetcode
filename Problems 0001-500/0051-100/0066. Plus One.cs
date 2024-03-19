using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0066
    {
        #region LeetCode  Approach 1: Schoolbook Addition with Carry
        public int[] PlusOne_Approach1(int[] digits)
        {

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;

                    return digits;
                }
            }

            //resize
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }


        #endregion

        #region answer
        public int[] PlusOne(int[] digits)
        {
            int increase = 0;
            int i = digits.Length - 1;
            int d = 0;
            while (i >= 0)
            {
                if(i == digits.Length - 1)
                {
                    d = digits[i] + 1;
                }
                else
                {
                    d = digits[i] + increase;
                }
                if(d == 10)
                {
                    digits[i] = 0;
                    increase = 1;
                }
                else
                {
                    digits[i] = d;
                    increase = 0;
                }
                i--;
            }
            if(digits[0] == 0)
            {
                int[] answer = new int[digits.Length + 1];
                answer[0] = 1;
                for(int j=0; j < digits.Length; j++)
                {
                    answer[j + 1] = digits[j];
                }
                return answer;
            }
            return digits;
        }
        #endregion

        #region 12/30/2021
        public int[] PlusOne_R2(int[] digits)
        {
            int increase = 0;
            int sum;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    sum = digits[i] + increase + 1;
                }
                else
                {
                    sum = digits[i] + increase;
                }
                digits[i] = sum % 10;
                increase = sum / 10;
            }
            if (increase == 0) return digits;
            else
            {
                int[] ans = new int[digits.Length + 1];
                ans[0] = increase;
                for (int i = 0; i < digits.Length; i++)
                {
                    ans[i + 1] = digits[i];
                }
                return ans;
            }
        }
        #endregion

        #region 08/08/2022
        public int[] PlusOne_20220808(int[] digits)
        {
            int incre = 0;
            int initial = 1;
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                int total = digits[i] + incre+ initial;
                initial = 0;
                digits[i] = total % 10;
                incre = total / 10;
            }
            if (incre == 0) return digits;
            else
            {
                int[] answer = new int[digits.Length + 1];
                answer[0] = incre;
                for(int i = 0; i < digits.Length; i++)
                {
                    answer[i + 1] = digits[i];
                }
                return answer;
            }
            
        }
        #endregion

        #region 03/06/2024
        public int[] PlusOne_2024_03_06(int[] digits)
        {
            if (digits.Length == 0) return digits;

            Stack<int> stack = new Stack<int>();

            int incre = 1;
            int index=digits.Length - 1;
            while (index >= 0)
            {
                int number = digits[index];
                stack.Push((number + incre) % 10);

                incre = (number + incre) / 10;
                index--;
            }
            if(incre == 1)
            {
                stack.Push(1);
            }

            List<int> list = new List<int>();
            while (stack.Count != 0)
            {
                list.Add(stack.Pop());
            }

            return list.ToArray();


        }
        #endregion



    }
}
