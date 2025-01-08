using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0409
    {
        #region 09/05/2024
        public int LongestPalindrome(string s)
        {
            int count = 0;
            bool isOdd = false;
            Dictionary<char,int> dic = new Dictionary<char, int>();

            foreach (char c in s)
            {

                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            foreach (char  c in dic.Keys) {

                if (dic[c] %2==0)
                {
                    count += dic[c];
                }
                else
                {
                    count += dic[c] - 1;
                    isOdd = true;
                }
            }

            return isOdd ? count + 1 : count;
        }
        #endregion
    }
}
