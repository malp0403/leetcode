using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2301_2350
{
    internal class _2309
    {
        #region 10/03/2023

        public string GreatestLetter(string s)
        {
            int[] arr1 = Enumerable.Repeat(0, 26).ToArray();
            int[] arr2 = Enumerable.Repeat(0, 26).ToArray();

            foreach (var ch in s)
            {
                if(ch-'a' >=0)
                {
                    arr1[ch - 'a']++;
                    if (arr1[ch-'a'] == 0)
                    {
                        arr1[ch - 'a']++;
                    }
                }
                else
                {
                    arr2[ch - 'A']++;
                    if (arr2[ch - 'A'] == 0)
                    {
                        arr2[ch - 'A']++;
                    }
                }
            }

            for(int i = arr1.Length-1; i >= 0; i--)
            {
                if (arr1[i] >0 && arr2[i] > 0)
                {
                    char res = (char)(i + (int)'A');
                    return res.ToString();
                }
            }
            return "";

        }

        #endregion
    }
}
