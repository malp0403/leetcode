using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 A valid parentheses string is either empty "", "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.

For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.
A valid parentheses string s is primitive if it is nonempty, and there does not exist a way to split it into s = A + B, with A and B nonempty valid parentheses strings.

Given a valid parentheses string s, consider its primitive decomposition: s = P1 + P2 + ... + Pk, where Pi are primitive valid parentheses strings.

Return s after removing the outermost parentheses of every primitive string in the primitive decomposition of s.

 

Example 1:

Input: s = "(()())(())"
Output: "()()()"
Explanation: 
The input string is "(()())(())", with primitive decomposition "(()())" + "(())".
After removing outer parentheses of each part, this is "()()" + "()" = "()()()".
Example 2:

Input: s = "(()())(())(()(()))"
Output: "()()()()(())"
Explanation: 
The input string is "(()())(())(()(()))", with primitive decomposition "(()())" + "(())" + "(()(()))".
After removing outer parentheses of each part, this is "()()" + "()" + "()(())" = "()()()()(())".
Example 3:

Input: s = "()()"
Output: ""
Explanation: 
The input string is "()()", with primitive decomposition "()" + "()".
After removing outer parentheses of each part, this is "" + "" = "".
 

Constraints:

1 <= s.length <= 105
s[i] is either '(' or ')'.
s is a valid parentheses string.
 */
#endregion

#region MyRegion
/*
             var obj = new _1021();
            obj.RemoveOuterParentheses_20231112("(()())(())");
 */
#endregion

namespace leetcode.Problems_1001_1500._1001_1050
{
    internal class _1021
    {
        #region 11/12/2023  
        public string RemoveOuterParentheses_20231112(string s)
        {
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder(); 

            for(int i=0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (stack.Count > 0)
                    {
                        sb.Append(s[i]);
                    }

                    stack.Push(i);

                }
                else
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        sb.Append(s[i]);
                    }
                }
            }

            return sb.ToString();
        }
        #endregion
    }
}
