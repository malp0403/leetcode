using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0278
    {
        public int FirstBadVersion(int n)
        {
            int l = 1;
            int r = n;
            int mid = l + (r - l) / 2;
            while (l < r)
            {
                
                if (IsBadVersion(mid))
                {
                    r = mid;
                }
                else
                {
                    l = mid+1;
                }
                mid = (r + l) / 2;
            }
            return l;
        }
        public bool IsBadVersion(int v)
        {
            return true;
        }

        //-------------12-30-2021-----------------
        public int FirstBadVersion_R2(int n)
        {
            int l = 1;
            int r = n;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
                {
                    r = mid;
                }
                else
                {
                    l = mid +1;
                }

            }
            return l;
        }
    }
}
