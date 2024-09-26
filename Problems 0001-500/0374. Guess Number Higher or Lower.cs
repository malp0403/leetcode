using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0374
    {
        #region Approach 1: Brute Force 09/01/2024
        public int guessNumber_app1(int n)
        {
            for (int i = 1; i < n; i++)
                if (guess(i) == 0)
                    return i;
            return n;
        }
        #endregion

        #region Approach 2: Using Binary Search
        public int guessNumber_app2(int n)
        {
            int l = 1;
            int r = n;
            while(l<= r)
            {
                int mid = l + (r - l) / 2;
                if(guess(mid) == 0)
                {
                    return mid;
                }else if(guess(mid) == 1)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
            
        }
        #endregion


        #region Approach 3: Ternary Search; note: ternary search is faster in general but slower in the worst case
        public int guessNumber_app3(int n)
        {
            int l = 1;
            int r = n;
            while (l <= r)
            {
                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;
                int res1 = guess(mid1);
                int res2 = guess(mid2);
                if (res1 == 0) return mid1;
                if (res2 == 0) return mid2;
                if(res1 < 0)
                {
                    r = mid1 - 1;
                }else if (res2 > 0)
                {
                    l = mid2 + 1;
                }
                else
                {
                    r = mid1 + 1;
                    l = mid2 - 1;
                }
              
            }
            return -1;

        }
        #endregion  

        //mock api
        public int guess(int n)
        {
            return 0;
        }
    }
}
