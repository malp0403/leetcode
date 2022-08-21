using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0678
    {
        public bool CheckValidString(string s)
        {
            List<char> list = new List<char>() { };
            int i = 0;

            while (i<s.Length)
            {
                if(s[i] == ')')
                {
                    if (list.Count == 0) {
                        return false;
                    } 
                    else
                    {
                        int indx = list.FindLastIndex(x => x == '(');
                        if(indx >= 0)
                        {
                            list.RemoveAt(indx);
                        }
                        else
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
                else
                {
                    list.Add(s[i]);
                }
                i++;
            }
            int startCount = 0;
            for(int j = list.Count - 1; j >= 0; j--)
            {
                if(list[j] == '*')
                {
                    startCount++;
                }
                else
                {
                    startCount--;
                }
                if (startCount < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
