using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0556
    {
        public int NextGreaterElement(int n)
        {
            StringBuilder s = new StringBuilder(n.ToString());
            int i = s.Length - 2;
            while (i>=0 && int.Parse(s[i].ToString()) - int.Parse(s[i+1].ToString())>=0)
            {
                i--;
            }
            if (i < 0) return -1;
            int j = i+1;
            for(; j < s.Length; j++)
            {
                if(int.Parse(s[j].ToString()) - int.Parse(s[i].ToString()) <= 0)
                {
                    break;
                }
            }
            //swap
            char temp = s[i];
            s[i] = s[j-1];
            s[j-1] = temp;
            //reverse
            int l = i + 1;
            int r = s.Length-1;
            while(l<s.Length && l < r)
            {
                var temp2 = s[l];
                s[l] = s[r];
                s[r] = temp2;
                l++;
                r--;
            }
            if (Int64.Parse(s.ToString()) > Int32.MaxValue) return -1;

            return int.Parse(s.ToString());

        }
    }
}
