using leetcode.Recursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0551_0600
{
    internal class _0557
    {
        #region 09/11/2023
        public string ReverseWords(string s)
        {
            char[] arr = s.ToCharArray();
            int start = 0;
            int i = 0;
            for(; i < arr.Length; i++)
            {
                if (char.IsWhiteSpace(arr[i]))
                {
                    reverse(arr,start, i - 1);
                    start = i+1;
                }else if(i == arr.Length - 1)
                {
                    reverse(arr, start, i);
                }
            }

            return new string(arr);



        }

        public void reverse(char[] arry,int start,int end)
        {
            while (start < end)
            {
                char t = arry[start];
                arry[start] = arry[end];
                arry[end] = t;
                start++;
                end--;
            }
        }
        #endregion

    }
}
