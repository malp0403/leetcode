using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0680
    {
        #region Solution
        public bool ValidPalindrome_S(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            bool res = true;
            bool deleted = false;
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    deleted = true;
                    break;
                }
            }
            if (deleted)
            {
                int newLeft = left;
                int newRight = right - 1;
                bool newRes1 = true;
                while (newLeft < newRight)
                {
                    if (s[newLeft] == s[newRight])
                    {
                        newLeft++;
                        newRight--;
                    }
                    else
                    {
                        newRes1 = false;
                        break;
                    }
                }

                int newLeft2 = left++;
                int newRight2 = right;
                bool newRes2 = true;
                while (newLeft2 < newRight2)
                {
                    if (s[newLeft2] == s[newRight2])
                    {
                        newLeft2++;
                        newRight2--;
                    }
                    else
                    {
                        newRes2 = false;
                        break;
                    }
                }
                res = newRes2 || newRes1;
            }

            return res;
        }

        #endregion

        #region MyRegion
        //--------------12-30-2021---------------
        int deleted = 1;
        public bool ValidPalindrome_R2(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l < r)
            {
                if (s[l] != s[r])
                {
                    if (deleted == 0) return false;
                    deleted = 0;


                    var temp = r - l + 1 <= s.Length ? ValidPalindrome_R2(s.Substring(l + 1, r - l)) : true;
                    var temp2 = ValidPalindrome_R2(s.Substring(l, r - l));
                    return temp || temp2;
                }
                l++;
                r--;
            }
            return true;
        }
        #endregion

        #region 10/01/2024
        int delete_2024_10_01 = 1;
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (delete_2024_10_01 == 0) return false;
                    delete_2024_10_01 = 0;

                    bool keepLeft = ValidPalindrome(s.Substring(left, right - left));
                    bool keepRight = ValidPalindrome(s.Substring(left + 1, right - left));
                    return keepLeft || keepRight;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
        #endregion

    }
}
