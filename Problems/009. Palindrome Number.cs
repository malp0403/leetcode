using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x == 0) return true;
            string temp = x.ToString();
            bool isPalindrome = true;
            for(int i =0; i < temp.Length / 2; i++)
            {
                if( temp[i] != temp[temp.Length - i-1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }

    }
}
