using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0202
    {
        HashSet<int> set = new HashSet<int>() { };
        public bool IsHappy(int n)
        {
            while(n !=1 && !set.Contains(n))
            {
                n = getNext(n);
                set.Add(n);
            }
            return n == 1;
        }

        public int getNext(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                sum += d * d;
            }
            return sum;
        }

        //----12-24-2021-------------
        public bool IsHappy_R2(int n)
        {
            HashSet<int> set = new HashSet<int>() { };
            while (!set.Contains(n))
            {
                if (n == 1) return true;
                else
                {
                    set.Add(n);
                    n = helper(n);
                }
            }
            return n==1;
        }
        public int helper(int n)
        {
            int sum = 0;
            while(n >0)
            {
                int num = n % 10;
                n = n / 10;
                sum += num * num;
              
            }
            return sum;
        }
    }
}
