using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace leetcode.Problems
{
    class _125
    {
        public bool IsPalindrome(string s)
        {

            string s2 = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    s2 += c.ToString().ToLower();
                }
            }
            int l = 0;
            int right = s2.Length - 1;
            bool valid = true;
            while (l < right)
            {
                if (s2[l] != s2[right])
                {
                    valid = false;
                    break;
                }
                l++;
                right--;
            }
            return valid;

        }

        public bool IsPalindrome2(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            bool valid = true;
            while (l < r)
            {
                while (!char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    if (l > s.Length) break;
                }
                while (!char.IsLetterOrDigit(s[r]))
                {
                    r--;
                    if (r < 0) break;
                }
                if (l < r) break;
                if (s[l].ToString().ToLower() != s[r].ToString().ToLower())
                {
                    valid = false;
                    break;
                }
                l++;
                r--;
            }
            return valid;
        }
        //-----------12-30-2021---
        public bool IsPalindrome_R3(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l <r && l<s.Length && r>=0) {
                while(l<r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                while(l<r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                
                if (s[l].ToString().ToLower() != s[r].ToString().ToLower()) return false;
                l++;r--;
            }
            return true;
        }
    }
}