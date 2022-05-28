using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q2_Sqrtx
    {
        //        Given a non-negative integer x, compute and return the square root of x.

        //Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

        //Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.

        //Example 1:

        //Input: x = 4
        //Output: 2
        //Example 2:

        //Input: x = 8
        //Output: 2
        //Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            int l = 1;
            int r = x -1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (mid == x / mid) return mid;
                if (mid < x / mid && mid + 1 > x / (mid + 1)) return mid;
                if (mid < x / mid) l = mid;
                else r = mid;
            }
            return l;



















            //if (x == 0 || x == 1) return x;

            //int l = 1;
            //int r = x / 2;
            //int ans = 0;
            //while (l <= r)
            //{
            //    int mid = (r + l) / 2;
            //    if (mid == x / mid) return mid;

            //    if (mid < x / mid)
            //    {
            //        ans = mid;
            //        l = mid + 1;
            //    }
            //    else r = mid - 1;
            //}
            //return ans;
        }

        public int MySqrt_R2(int x)
        {
            int l = 1;
            int r = x / 2;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                long total = mid * mid;
                if (total < x) l = mid;
                else r = mid-1;
            }
            return l;
        }
    }
}
