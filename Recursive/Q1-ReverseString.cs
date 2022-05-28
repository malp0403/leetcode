using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class Q1_ReverseString
    {
        //        Write a function that reverses a string. The input string is given as an array of characters s.

        //You must do this by modifying the input array in-place with O(1) extra memory.



        //Example 1:

        //Input: s = ["h", "e", "l", "l", "o"]
        //Output: ["o","l","l","e","h"]
        //Example 2:

        //Input: s = ["H", "a", "n", "n", "a", "h"]
        //Output: ["h","a","n","n","a","H"]

        public void ReverseString(char[] s)
        {
            helper(0, s.Length - 1, s);
        }
        public void helper(int l , int r ,char[] s)
        {
            if (l >= r) return;
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;
            l++;
            r--;
            helper(l, r,s);
        }
    }
}
