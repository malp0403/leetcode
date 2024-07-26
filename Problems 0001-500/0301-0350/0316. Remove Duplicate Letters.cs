using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0316
    {
        #region 07/23/2024 Approach 2: Greedy - Solving with Stack
        public string RemoveDuplicateLetters(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = i;
                }
                else
                {
                    dic.Add(s[i], i);
                }
            }
            Stack<char> stack = new Stack<char>();
            HashSet<char> seen = new HashSet<char>();
            int index = 0;
            while (index < s.Length)
            {
                char c = s[index];
                if (!seen.Contains(c))
                {

                    while (stack.Count > 0 && c < stack.Peek() && dic[stack.Peek()] > index)
                    {
                        seen.Remove(stack.Pop());
                    }
                    seen.Add(c);
                    stack.Push(c);

                }
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            string s1 = sb.ToString();
            char[] arr = s1.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        #endregion

    }
}
