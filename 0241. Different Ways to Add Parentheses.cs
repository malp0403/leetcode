using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class _0241
    {
        public IList<int> DiffWaysToCompute(string expression)
        {
            IList<int> ans = new List<int>() { };
            for(int i =0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (expression[i] == '-' || expression[i] == '+' || expression[i] == '*')
                {
                    string s1 = expression.Substring(0, i);
                    string s2 = expression.Substring(i + 1);
                    var l1 = DiffWaysToCompute(s1);
                    var l2 = DiffWaysToCompute(s2);
                    foreach (var num1 in l1)
                    {
                        foreach (var num2 in l2)
                        {
                            if(c == '+')
                            {
                                ans.Add(num1 + num2);
                            }else if(c == '-')
                            {
                                ans.Add(num1 - num2);
                            }else if(c == '*')
                            {
                                ans.Add(num1 * num2);
                            }
                        }
                    }
                }
               
            }
            if (ans.Count == 0) ans.Add(Int16.Parse(expression));
            return ans;
        }
    }
}
