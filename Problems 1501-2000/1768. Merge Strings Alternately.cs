using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1751_1800
{
    internal class _1768
    {
        #region 09/19/2023 two pointers
        public string MergeAlternately(string word1, string word2)
        {
            int l1 = 0;
            int l2 = 0;
            StringBuilder sb = new StringBuilder();
            while (l1 < word1.Length || l2 < word2.Length)
            {
                if (l1 >= word1.Length)
                {
                    sb.Append(word2.Substring(l2));
                    break;
                }
                else if (l2 >= word2.Length)
                {
                    sb.Append(word1.Substring(l1));
                    break;
                }

                sb.Append(word1[l1]);
                sb.Append(word2[l2]);
                l1++;
                l2++;

            }
            return sb.ToString();
        }
        #endregion

        #region 09/19/2023 one pointer
        public string MergeAlternately_onePointer(string word1, string word2)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }
            return sb.ToString();
        }
        #endregion

        #region 09/23/2023 one pointer
        public string MergeAlternately_20230923(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < word1.Length || index < word2.Length)
            {
                if (index < word1.Length)
                {
                    sb.Append(word1[index]);
                }
                if (index < word2.Length)
                {
                    sb.Append(word2[index]);
                }
                index++;
            }
            return sb.ToString();
        }
        #endregion

        #region 09/16/2024 one pointer
        public string MergeAlternately_2024_09_16(string word1, string word2)
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            while (index < Math.Min(word1.Length, word2.Length))
            {
                sb.Append(word1[index]);
                sb.Append(word2[index]);
                index++;
            }

            if(index < word1.Length)
            {
                sb.Append(word1.Substring(index));
            }
            if(index < word2.Length)
            {
                sb.Append(word2.Substring(index));
            }

            return sb.ToString();
        }
        #endregion
    }
}
