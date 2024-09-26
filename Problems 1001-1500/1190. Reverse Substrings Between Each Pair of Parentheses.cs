using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You are given a string s that consists of lower case English letters and brackets.

Reverse the strings in each pair of matching parentheses, starting from the innermost one.

Your result should not contain any brackets.

 

Example 1:

Input: s = "(abcd)"
Output: "dcba"
Example 2:

Input: s = "(u(love)i)"
Output: "iloveu"
Explanation: The substring "love" is reversed first, then the whole string is reversed.
Example 3:

Input: s = "(ed(et(oc))el)"
Output: "leetcode"
Explanation: First, we reverse the substring "oc", then "etco", and finally, the whole string.
 

Constraints:

1 <= s.length <= 2000
s only contains lower case English characters and parentheses.
It is guaranteed that all parentheses are balanced.
 */
#endregion

namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1190
    {
        #region 11/05/2023
        public string ReverseParentheses(string s)
        {
            Stack<object> stack = new Stack<object>();
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == ')')
                {
                    StringBuilder sb = new StringBuilder();
                    while (!(stack.Peek() is char && (char)stack.Peek() == '('))
                    {
                        if (stack.Peek() is char)
                        {
                            sb.Append(stack.Pop());

                        }
                        else
                        {
                            string temp = (string)stack.Pop();
                            char[] chars = temp.ToCharArray();
                            Array.Reverse(chars);
                            sb.Append(new string(chars));
                        }

                    }
                    stack.Pop();
                    stack.Push(sb.ToString());
                }
                else
                {
                    stack.Push(s[i]);

                }

            }

            string answer = "";
            while (stack.Count > 0)
            {
                answer = (stack.Pop() + answer);
            }


            return answer;

        }
        #endregion
    }
}
