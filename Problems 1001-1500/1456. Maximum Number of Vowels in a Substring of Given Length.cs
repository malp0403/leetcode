using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1451_1500
{
    internal class _1456
    {
        #region Approach: Sliding Window 09/16/2024 
        public int MaxVowels_app1(string s, int k)
        {
            HashSet<char> vowels = new HashSet<char>()
            {
                'a','e','i','o','u'
            };
            int max = 0;
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                count += (vowels.Contains(s[i]) ? 1 : 0);
            }
            max = Math.Max(max, count);

            for (int i = k;i< s.Length; i++)
            {
                count += (vowels.Contains(s[i]) ? 1 : 0);
                count -= (vowels.Contains(s[i-k]) ? 1 : 0);
                max= Math.Max(max, count);

            }
            return max;
        }
        #endregion

        #region 09/16/2024 Sliding Window
        public int MaxVowels_2024_09_16(string s, int k)
        {
            HashSet<char> vowels = new HashSet<char>()
            {
                'a','e','i','o','u'
            };

            int start = 0;
            int i = 0;
            int max = 0;
            int cur = 0;
            while (i < s.Length)
            {
                if (vowels.Contains(s[i]))
                {
                    cur++;
                }

                if (i - start >= k)
                {
                    if (vowels.Contains(s[start]))
                    {
                        cur--;
                    }
                    start++;
                }

                max = Math.Max(max, cur);
                i++;

            }
            return max;
        }
        #endregion
    }
}
