using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0161
    {
        public bool IsOneEditDistance(string s, string t)
        {
            if (s.Length == t.Length)
            {
                int count = 1;
                int i = 0;
                while (i < s.Length)
                {
                    if (s[i] != t[i])
                    {
                        count--;
                    }
                    i++;
                    if (count < 0) break;
                }
                return count == 0;
            }
            else if (s.Length - t.Length == 1 || s.Length - t.Length == -1)
            {
                string longer = s.Length > t.Length ? s : t;
                string shorter = s.Length < t.Length ? s : t;
                if (shorter == "") return true;
                int i = 0;
                int j = 0;
                int count = 0;
                while (i < longer.Length && j < shorter.Length)
                {
                    if (longer[i] != shorter[j])
                    {
                        count++;
                        j--;
                    }
                    i++;
                    j++;
                    if (count == 2) break;
                }
                return i == j || count == 1;
            }
            return false;

        }

        //02/05/2022
        public bool IsOneEditDistance_R2(string s,string t)
        {
           if(s.Length== t.Length)
            {
                int difference = 0;
                int p1 = 0;
                while (p1 < s.Length)
                {
                    if (s[p1] != t[p1]) difference++;
                    if (difference == 2) return false;
                    p1++;
                }
                return difference == 1;
            }
            else if( Math.Abs(s.Length - t.Length) ==1)
            {
                string longer = s.Length > t.Length ? s : t;
                string shorter = s.Length < t.Length ? s : t;
                int p1 = 0;
                int p2 = 0;
                int difference = 0;
                while (p2 < shorter.Length)
                {
                    if(longer[p1] != shorter[p2])
                    {
                        p1++;
                        difference++;
                    }
                    else
                    {
                        p1++; p2++;
                    }
                    if (difference == 2) return false; 
                }
                return true;
            }
            return false;
        }
    }
}
