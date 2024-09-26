using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0125
    {
        #region answer
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length-1;
            while (l < r)
            {
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
        #endregion
        #region 08/17/2022
        public bool IsPalindrome_20220817(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while(left < right)
            {
                while (left < s.Length && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while(right>=0 && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                if(left >= right) { return true; }
                if(s[left].ToString().ToLower() != s[right].ToString().ToLower())
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        #endregion

        #region 03/24/2024
        public bool IsPalindrome_2024_03_24(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (right > left && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                string c1 = s[left].ToString().ToLower();
                string c2= s[right].ToString().ToLower();

                if (c1 != c2) return false;
                left++;
                right--;

            }
            return true;
        }

        
        #endregion
    }
}
