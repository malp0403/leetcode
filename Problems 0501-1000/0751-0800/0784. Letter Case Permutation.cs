using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given a string s, you can transform every letter individually to be lowercase or uppercase to create another string.

Return a list of all possible strings we could create. Return the output in any order.

 

Example 1:

Input: s = "a1b2"
Output: ["a1b2","a1B2","A1b2","A1B2"]
Example 2:

Input: s = "3z4"
Output: ["3z4","3Z4"]
 */
namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0784
    {
        #region 12/08/2023
        List<string> ans_2023_12_08;
        public IList<string> LetterCasePermutation(string s)
        {
            ans_2023_12_08= new List<string>();
            helper_2023_12_08(0, new StringBuilder(), s);
            return ans_2023_12_08;


        }
        public void helper_2023_12_08(int index1,StringBuilder sb,string s)
        {
            if(index1 == s.Length)
            {
                ans_2023_12_08.Add(sb.ToString());
                return;
            }

            if (char.IsLetter(s[index1])) {
                char c = s[index1];
                sb.Append(c);
                helper_2023_12_08(index1 + 1, sb, s);
                sb.Remove(sb.Length - 1, 1);

                if (char.IsLower(c))
                {
                    sb.Append(c.ToString().ToUpper());

                }
                else
                {
                    sb.Append(c.ToString().ToLower());
                }
                helper_2023_12_08(index1 + 1, sb, s);
                sb.Remove(sb.Length - 1, 1);


            }
            else
            {
                sb.Append(s[index1]);
                helper_2023_12_08(index1 + 1, sb, s);
                sb.Remove(sb.Length - 1, 1);


            }
        }
        #endregion
    }
}
