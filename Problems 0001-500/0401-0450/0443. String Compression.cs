using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0443
    {
        public int Compress(char[] chars)
        {
            if (chars.Length == 0) return 0;
            List<string> l = new List<string>() { };
            char? pre = null;
            int indx = 0;
            while (indx < chars.Length)
            {
                
                if (chars[indx] == pre)
                {
                    int count = 1;
                    while (indx < chars.Length && chars[indx] == pre)
                    {
                        count++;
                        indx++;
                    }
                    l.Add(pre.ToString());
                    l.Add(count.ToString());

                }
                else
                {
                    pre = chars[indx];
                    if(indx == chars.Length-1 || (indx < chars.Length-1 && chars[indx+1] != pre)) {
                        l.Add(chars[indx].ToString());
                    }
                    indx++;
                }
            }

            string result = String.Join("", l.ToArray());
            for(int i=0; i < result.Length; i++)
            {
                chars[i] = result[i];
            }
            return result.Length;
        }
    }
}
