using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0844
    {
        public bool BackspaceCompare(string s, string t)
        {
            return compare(s) == compare(t);
        }
        public string compare(string s)
        {
            string answer = "";
            foreach(var c in s)
            {
                if(c == '#')
                {
                    if(answer.Length != 0)
                    {
                        answer   = answer.Substring(0, answer.Length - 1);
                    }
                }
                else
                {
                    answer += c.ToString();
                }
            }
            return answer;
        }
        //***************** 2 pointers*************************
        public bool BackspaceCompare_V2(string s,string t)
        {
            int l = s.Length - 1; int r = t.Length - 1;
            int skipl = 0; int skipr = 0;
            while (l >= 0 || r >= 0)
            {
                while (l >= 0)
                {
                    if (s[l] == '#')
                    {
                        skipl++; l--;
                    }
                    else if (skipl > 0)
                    {
                        skipl--; l--;
                    }
                    else
                    {
                        break;
                    }
                }
                while (r >= 0)
                {
                    if (t[r] == '#')
                    {
                        skipr++; r--;
                    }
                    else if (skipr > 0)
                    {
                        skipr--; r--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (l >= 0 && r >= 0 && s[l] != t[r]) return false;
                if ((l >= 0) != (r >= 0)) return false;

                l--; r--;
            }
            return true;
        }
        //---------12-28-2021-------------------
        public bool BackspaceCompare_R1(string s, string t)
        {
            string ans1 = "";
            string ans2 = "";
            foreach(var c in s)
            {
                if(c == '#')
                {
                    ans1 = ans1 == string.Empty ? "" : ans1.Substring(0, ans1.Length - 1);
                }
                else
                {
                    ans1 += c;
                }
            }
            foreach(var c in t)
            {
                if(c == '#')
                {
                    ans2 = ans2 == string.Empty ? "" : ans2.Substring(0, ans2.Length - 1);

                }
                else
                {
                    ans2 += c;
                }
            }
            return ans1 == ans2;
        }
    }
}
