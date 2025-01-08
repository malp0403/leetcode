using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1554
    {
        public bool DifferByOne(string[] dict)
        {
            HashSet<string> set = new HashSet<string>() { };

            for (int i = 0; i < dict.Length; i++)
            {
                for (int j = 0; j < dict[i].Length; j++)
                {
                    var temp = new StringBuilder(dict[i]);
                    temp[j] = '*';
                    if (set.Contains(temp.ToString()))
                    {
                        return true;
                    }
                    set.Add(temp.ToString());
                }
            }
            return false;
        }

        //01-06-2020
        public bool DifferByOne_R2(string[] dict)
        {
            HashSet<string> set = new HashSet<string>() { };
            for(int i =0; i < dict.Length; i++)
            {
                for(int j=0; j < dict[i].Length; j++)
                {
                    StringBuilder s = new StringBuilder(dict[i]);
                    s[j] = '*';
                    if (set.Contains(s.ToString()))
                    {
                        return true;
                    }
                    set.Add(s.ToString());
                }
            }
            return false;
        }
    }
}
