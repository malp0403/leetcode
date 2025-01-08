using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1328
    {
        public string BreakPalindrome(string palindrome)
        {
            if (palindrome == "" || palindrome.Length == 1) return "";
            for (int i = 0; i < palindrome.Length/2; i++)
            {
                if(palindrome[i] != 'a')
                {
                    return  palindrome.Substring(0, i) + "a" + palindrome.Substring(i + 1);
                }   
            }
            return palindrome.Substring(0, palindrome.Length - 1) + "b";

        }
    }
}
