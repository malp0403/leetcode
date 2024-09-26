using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0367
    {
        #region Binary Search
        //******************** Binary Search********************
        public bool IsPerfectSquare(int num)
        {
            if (num < 2) return true;

            long l = 0; long r = num / 2;
            while (l <= r)
            {
                long mid = l + (r - l) / 2;
                long sum = mid * mid;
                if (sum == num)
                {
                    return true;
                }
                if (sum < num)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return false;

        }
        #endregion

        #region Approach 2: Newton's Method 牛顿迭代法（Newton's method）又称为牛顿-拉夫逊（拉弗森）方法（Newton-Raphson method），它是牛顿在17世纪提出的一种在实数域和复数域上近似求解方程的方法。

        #endregion


        #region 09/01/2024
        public bool IsPerfectSquare_2024_09_01(int num)
        {
            if (num == 0 || num == 1) return true;

            long l = 1;
            long r = num / 2;

            while (l <= r)
            {
                long mid = l + (r - l) / 2;
                if (mid * mid == num) return true;
                else if(mid * mid < num)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return false;
        }
        #endregion
    }
}
