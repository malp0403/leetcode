using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;
            int l = 1;
            int r = num / 2;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (mid == num / mid) return true;
                if (mid < num / mid) l = mid + 1;
                else r = mid - 1;
            }
            return false;
        }
    }
}
