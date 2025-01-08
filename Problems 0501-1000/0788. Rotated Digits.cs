using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0788
    {
        public int RotatedDigits(int n)
        {
            int total = 0;
            for(int i=1; i <= n; i++)
            {
                total += helper_R2(i)?1:0;
            }
            return total;

        }

        public bool isGoodNumber(int n)
        {
            string s = ((int)Math.Abs(n)).ToString();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '3' || i == '4' || i == '7')
                {
                    return false;
                }
                else if (s[i] == '6' || s[i] == '9' || s[i] == '2' || s[i] == '5')
                {
                    count++;
                }
            }
            return count > 0;
        }

        //01-15-2022
        public bool helper_R2(int n)
        {
            int count = 0;
            while(n!= 0)
            {
                int a = n % 10;
                switch (a)
                {
                    case 2: break;
                    case 5:
                    case 6:
                    case 9: count++;break;
                    case 3:
                    case 4:
                    case 7: return false;
                    default: break;
                }
                n = n / 10;
            }
            return count > 0;
        }
    }
}
