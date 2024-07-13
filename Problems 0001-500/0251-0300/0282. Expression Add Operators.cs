using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0282
    {
        #region 07/12/2024

        string num_2024_07_12;
        List<string> operation_2024_07_12;
        List<string> buildLists;
        List<string> answer = new List<string>() { };
        public List<string> AddOperators(string num, int target)
        {
            num_2024_07_12 = num;
            operation_2024_07_12 = new List<string>() { "+", "-", "*" };
            buildLists = new List<string>();
        }

        public void Build_2024_07_12(int i, string num, int target, StringBuilder sb)
        {
            sb.Append(num[i]);
            if (i == num.Length-1)
            {
                buildLists.Add(sb.ToString());
                return;
            }
            Build_2024_07_12(i + 1, num, target, sb);
            foreach (var item in operation_2024_07_12)
            {
                sb.Append(item);
                Build_2024_07_12(i + 1, num, target, sb);
                sb.Remove(sb.Length - 1, 1);
            }

        }

        public void Addup_2024_07_12(string s,int target)
        {
            double curNumber = 0;
           
            Stack<double> stack = new Stack<double>();
            char opera = '+';
            int index = 0;

            while(index< s.Length)
            {
                if (char.IsDigit(s[index]))
                {
                    curNumber = curNumber * 10 + s[index] - '0';
                }
                if (!char.IsDigit(s[index]) || index ==  s.Length-1)
                {
                    if (s[index] == '-')
                    {
                        stack.Push(0 - curNumber);
                    }
                    else if (s[index] == '+')
                    {
                        stack.Push(curNumber);
                    }
                    else if (s[index] == '*')
                    {
                        stack.Push(stack.Pop() * curNumber);
                    }else  if (s[index] == '/')
                        {
                            stack.Push(stack.Pop()/curNumber);
                        }

                    opera = s[index];
                    curNumber = 0;
                }
            }
            int sum = 0;
            while(stack.Count > 0)
            {
                sum +=(int)stack.Pop();
            }
            if(sum == target)
            {
                answer.Add(s);
            }

        }
        #endregion
    }
}
