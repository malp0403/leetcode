using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0345
    {
        #region 08/31/2024
        public string ReverseVowels_2024_08_31(string s)
        {
            HashSet<char> set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u'
            ,'A','E','I','O','U'};
            char[] arr= s.ToCharArray();

            int l = 0;
            int r = arr.Length-1;

            while (l < r)
            {
                while( l <r && !set.Contains(arr[l]))
                {
                    l++;
                }
                if (l >= r) break;
                while( l< r && !s.Contains(arr[r]))
                {
                    r--;
                }
                if (l >= r) break;

                char temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;

                l++;
                r--;
            }
            return new string(arr); 


        }
        #endregion
    }
}
