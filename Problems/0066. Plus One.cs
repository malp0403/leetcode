using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0066
    {
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

        //-----12-30-2021-------------
        public int[] PlusOne_R2(int[] digits)
        {
            int increase = 0;
            int sum;
            for(int i=digits.Length-1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    sum = digits[i] + increase+1;
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
                for(int i=0;i < digits.Length; i++)
                {
                    ans[i + 1] = digits[i];
                }
                return ans;
            }
        }
    }
}
