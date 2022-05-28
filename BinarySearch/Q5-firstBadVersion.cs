using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q5_firstBadVersion
    {
        public int FirstBadVersion(int n)
        {
            int l = 1;
            int r = n;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                bool isbad = IsBadVersion(mid);
                if (isbad && (mid == 1 || !IsBadVersion(mid-1))) return mid;
                if (isbad) r = mid;
                else l = mid + 1;
            }
            return r;




            //int l = 1;
            //int r = n;
            //while (l < r)
            //{
            //    int mid = l + (r - l) / 2;
            //    bool isBad = IsBadVersion(mid);
            //    if (isBad) r = mid;
            //    else l = mid + 1;
            //}
            //return r;
        }
        public bool IsBadVersion(int n)
        {
            return true;
        }
    }
}
