using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0205
    {
        #region 08/14/2023
        public bool IsIsomorphic_20230814(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>() { };
            HashSet<char> set = new HashSet<char>() { };

            for(int i =0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    if (set.Contains(t[i])) return false;

                    dic.Add(s[i], t[i]);
                    set.Add(t[i]);
                }
                else
                {
                    if (dic[s[i]] != t[i] )
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region 08/14/2023  First occurence transformation
        public bool IsIsomorphic_20230814_v2(string s, string t)
        {
            return helper(s) == helper(t);
        }

        public string helper(string str)
        {
            StringBuilder sb = new StringBuilder() { };
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for(int i =0; i < str.Length; i++)
            {
                if (!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], i);
                }
                sb.Append(dic[str[i]]);
                sb.Append('#');

            }

            return sb.ToString();
        }
            #endregion
        }
    }
