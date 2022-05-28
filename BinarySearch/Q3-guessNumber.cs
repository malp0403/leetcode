using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class Q3_guessNumber
    {
        public int guessNumber(int n)
        {
            int l = 1;
            int r = n;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                int res = guess(mid);
                if (res == 0) return mid;
                else if (res < 0)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
            //int l = 1;
            //int r = n;
            //while (l <= r)
            //{
            //    int mid = (l + r) / 2;
            //    int res = guess(mid);
            //    if (res == 0) return mid;
            //    if (res < 0) r = mid - 1;
            //    else l = mid + 1;
            //}
            //return -1;
        }
       
        public int guess(int num)
        {
            if (num == 6) return 0;
            if (num < 6) return -1;
            else return 1;
        }
    }
}
