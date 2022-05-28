using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0009
    {
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
    }
}
