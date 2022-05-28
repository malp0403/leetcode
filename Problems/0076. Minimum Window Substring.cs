using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0076
    {
        public string MinWindow(string s, string t)
        {
            int[] arr = Enumerable.Repeat(0, 128).ToArray();
            foreach (var c in t)
            {
                arr[c]++;
            }
            int l = 0;
            int r = 0;
            int min = Int16.MaxValue;
            int count = t.Length;
            int minL = 0;
            int minR = -1;
            while (r < s.Length)
            {
                arr[s[r]]--;
                if(arr[s[r]] >= 0)
                {
                    count--;
                }
                while(count == 0)
                {
                    int len = r - l + 1;
                    if(len < min)
                    {
                        minL = l;
                        minR = r;
                        min = len;
                    }
                    arr[s[l]]++;
                    if (arr[s[l]] > 0)
                    {
                        count++;
                    }
                    l++;
                }
                r++;
            }

            return minR - minL + 1==0?"":s.Substring(minL, minR - minL + 1);
        }
        
    }
}
