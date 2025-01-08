using System;
using System.Collections.Generic;
using System.Text;
#region Test
/*
       var obj = new _0125();
            obj.IsPalindrome_2024_10_06("race a car");

 */
#endregion
namespace leetcode.Problems
{
    class _0125
    {
        #region Approach 1: Compare with Reverse

        #endregion
        #region Approach 2: Two Pointers

        #endregion
        #region answer
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l < r)
            {
                while (l < r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                while (l < r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                if (s[l].ToString().ToLower() != s[r].ToString().ToLower()) return false;
                l++; r--;
            }
            return true;
        }
        #endregion

        #region 08/17/2022
        public bool IsPalindrome_20220817(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < s.Length && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (right >= 0 && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                if (left >= right) { return true; }
                if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
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

            while (left < right)
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
                string c2 = s[right].ToString().ToLower();

                if (c1 != c2) return false;
                left++;
                right--;

            }
            return true;
        }


        #endregion

<<<<<<< HEAD:Problems 0001-500/0101-150/0125. Valid Palindrome.cs
        #region 01/07/2025  char.ToLower faster than tostring().tolower()
        public bool IsPalindrome_20250107(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while(l < r)
            {
                while(l <r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                while(l<r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                if (char.ToLower(s[l]) == char.ToLower(s[r]))
=======
        #region 10/06/2024  IsLetterOrDigit
        public bool IsPalindrome_2024_10_06(string s)
        {
            int l = 0;
            int r= s.Length - 1;
            while(l < r)
            {
                while ( l < r && !char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }

                while( l<r && !char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }

                if (l >= r) break;
                if (s[l] == s[r] || s[l].ToString().ToLower() == s[r].ToString().ToLower())
>>>>>>> 6d99fc316f77012030d9e02012c6eab5cae03c3c:Problems 0001-500/0125. Valid Palindrome.cs
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }
<<<<<<< HEAD:Problems 0001-500/0101-150/0125. Valid Palindrome.cs
            return true;


=======

            return true;

>>>>>>> 6d99fc316f77012030d9e02012c6eab5cae03c3c:Problems 0001-500/0125. Valid Palindrome.cs
        }
        #endregion
    }
}
