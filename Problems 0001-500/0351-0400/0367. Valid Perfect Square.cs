using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0367
    {
        //******************** Binary Search********************
        public bool IsPerfectSquare(int num)
        {
            if (num < 2) return true;

            long l = 0; long r = num / 2;
            while (l <= r)
            {
                long mid = l + (r - l) / 2;
                long sum = mid * mid;
                if(sum== num)
                {
                    return true;
                }
                if( sum< num)
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
    }
}
