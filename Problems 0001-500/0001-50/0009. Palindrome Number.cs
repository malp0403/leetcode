using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0009
    {
        #region answer
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x == 0) return true;
            int num = x;
            int reverse = 0;
            while(num > 0)
            {
                int temp = num % 10;
                reverse = reverse * 10 + temp;
                num = num / 10;
            }
            return reverse == x;

            
        }
        #endregion

        #region 07/11/2022
        public bool IsPalindrome_r2(int x)
        {
            if (x < 0) return false;
            if (x == 0) return true;
            int i = 0;
            string str = x.ToString();
            while(i < str.Length / 2)
            {
                if(str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        #endregion
    }
}
