using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 You are given a string text. You can swap two of the characters in the text.

Return the length of the longest substring with repeated characters.

 

Example 1:

Input: text = "ababa"
Output: 3
Explanation: We can swap the first 'b' with the last 'a', or the last 'b' with the first 'a'. Then, the longest repeated character substring is "aaa" with length 3.
Example 2:

Input: text = "aaabaaa"
Output: 6
Explanation: Swap 'b' with the last 'a' (or the first 'a'), and we get longest repeated character substring "aaaaaa" with length 6.
Example 3:

Input: text = "aaaaa"
Output: 5
Explanation: No need to swap, longest repeated character substring is "aaaaa" with length is 5.
 

Constraints:

1 <= text.length <= 2 * 104
text consist of lowercase English characters only.
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1156
    {
        #region 11/07/2023
        public int MaxRepOpt1(string text)
        {
            char[] chars = text.ToCharArray();
            Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();
            for (int i = 0; i < text.Length; i++)
            {
                if (dic.ContainsKey(text[i]))
                {
                    dic[text[i]].Add(i);
                }
                else
                {
                    dic.Add(text[i], new List<int>() { i });
                }
            }
            int start = 0;
            int max = 1;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != chars[i - 1])
                {
                    List<int> list = dic[chars[i - 1]];
                    int lastIndex = list[list.Count - 1];
                    if (lastIndex > i)
                    {
                        //swap
                        char temp = chars[i];
                        chars[lastIndex] = temp;
                        chars[i] = chars[i - 1];

                        int index = start;
                        int count = 0;
                        while (index < lastIndex)
                        {
                            if (chars[index] != chars[i - 1]) break;
                            count++;
                            index++;
                        }
                        max = Math.Max(max, count);

                        //revert
                        chars[lastIndex] = chars[i - 1];
                        chars[i] = temp;
                    }


                    start = i;
                }
                else
                {
                    max = Math.Max(max, i - start + 1);
                }
            }

            start = chars.Length - 1;
            for (int i = chars.Length - 2; i >= 0; i--)
            {
                if (chars[i] != chars[i + 1])
                {
                    List<int> list = dic[chars[i+1]];
                    int firstIndex = list[0];
                    if (firstIndex < i)
                    {
                        //swap
                        char temp = chars[i];
                        chars[firstIndex] = temp;
                        chars[i] = chars[i + 1];

                        int index = start;
                        int count = 0;
                        while (index > firstIndex)
                        {
                            if (chars[index] != chars[i + 1]) break;
                            count++;
                            index--;
                        }
                        max = Math.Max(max, count);

                        //revert
                        chars[firstIndex] = chars[i+1];
                        chars[i] = temp;
                    }
                    start = i;
                }
                else
                {
                    max = Math.Max(max, i - start + 1);
                }
            }


            return max;

        }
        #endregion
    }
}
