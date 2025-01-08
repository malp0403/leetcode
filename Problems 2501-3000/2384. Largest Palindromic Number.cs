using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2301_2350
{
    internal class _2384
    {
        #region 09/26/2023
        public string LargestPalindromic(string num)
        {
            int[] arr= new int[10];
            int singleMax = -1;
            int maxDigit = 0;
            foreach (char ch in num)
            {
                arr[ch - '0']++;
            }
            StringBuilder sb = new StringBuilder();
            for(int i=9;i>=0; i--)
            {
                int total = arr[i];
                int half = total / 2;
                if(total % 2 == 1)
                {
                    singleMax = Math.Max(singleMax, i);
                    maxDigit = Math.Max(maxDigit, i);

                }
                while (half > 0)
                {
                    maxDigit = Math.Max(maxDigit, i);
                    sb.Append(i);
                    half--;
                }
            }

            string s1 = sb.ToString();
            while (s1.Length > 0 && s1[0] == '0')
            {
                s1 = s1.Substring(1);
            }
            if (s1 == "") return maxDigit.ToString();

            char[] a = s1.ToCharArray();
            Array.Reverse(a);
            string s2 = new string(a);

            string s3 = s1 + (singleMax != -1 ? singleMax : "" )+ s2;

    

            return s3;
        }
        #endregion
    }
}
