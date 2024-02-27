using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.

Return any possible rearrangement of s or return "" if not possible.

 

Example 1:

Input: s = "aab"
Output: "aba"
Example 2:

Input: s = "aaab"
Output: ""
 

Constraints:

1 <= s.length <= 500
s consists of lowercase English letters.
 */
#endregion

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0767
    {
        #region 12/08/2023 Count + PriorityQueue
        public string ReorganizeString(string s)
        {
            if (s == "") return "";
            int total = 0;
            int highestcount = 0;
            int[] arr = Enumerable.Repeat(0, 26).ToArray();
            foreach (int i in s)
            {
                arr[i - 'a']++;
                total++;
            }
            PriorityQueue<(char c, int count), int> q = new PriorityQueue<(char c, int count), int>();
            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i] > 0) {
                    highestcount = Math.Max(highestcount, arr[i]);
                    q.Enqueue(((char)(i + 'a'), arr[i]), -arr[i]);
                }
            }
            if(highestcount *2 - 1 > total) {
                return "";
            }
    


            StringBuilder sb = new StringBuilder();

            while (q.Count > 0)
            {
                var temp1 = q.Dequeue();
                if (q.Count > 0)
                {
                    var temp2 = q.Dequeue();
                    sb.Append(temp1.c);
                    sb.Append(temp2.c);
                    temp1.count--;
                    temp2.count--;
                    if(temp1.count > 0)
                    {
                        q.Enqueue(temp1, -temp1.count);
                    }
                    if (temp2.count > 0)
                    {
                        q.Enqueue(temp2, -temp2.count);
                    }

                }
                else
                {
                    sb.Append(temp1.c);
                    break;
                }


            }
           
            return sb.ToString();
            
        }
        #endregion
    }
}
