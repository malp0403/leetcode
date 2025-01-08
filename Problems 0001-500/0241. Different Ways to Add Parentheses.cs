using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0241
    {
        #region 07/08/2024 Rcursive
        public IList<int> DiffWaysToCompute(string expression)
        {
            List<int> result = new List<int>() { };
            if (isDigit(expression)){
                result.Add(int.Parse(expression));
            }
            else
            {
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == '+' || expression[i] == '*' || expression[i] == '-')
                    {
                        char ch = expression[i];
                        IList<int> left = DiffWaysToCompute(expression.Substring(0, i));
                        IList<int> right = DiffWaysToCompute(expression.Substring(i + 1));
                        foreach (var item in left)
                        {
                            foreach (var item2 in right)
                            {
                                if (ch == '+')
                                {
                                    result.Add(item + item2);
                                }
                                else if (ch == '-')
                                {
                                    result.Add(item - item2);
                                }
                                else
                                {
                                    result.Add(item * item2);
                                }
                            }
                        }
                    }
                }
            }



            return result;


        }

        public bool isDigit(string expression)
        {
            if (expression.Length == 1 && char.IsDigit(expression[0])) return true;
            if (expression.Length == 2 && char.IsDigit(expression[1]) && char.IsDigit(expression[0])) return true;
            return false;
        }
        #endregion
    }
}
