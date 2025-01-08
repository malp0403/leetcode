using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0772
    {
        #region 2023/09/12

        //public int Calculate(string s)
        //{
        //    Stack<object> stack = new Stack<object>();
           
        //    for(int i = s.Length - 1; i >= 0; i--)
        //    {
        //        if (s[i] == '(')
        //        {
        //            int sum =helper_20230912(stack);
        //            string temp = sum.ToString();
        //            for(int j=temp.Length - 1;j >= 0; j--)
        //            {
        //                stack.Push(temp[j]);
        //            }
        //            if (sum < 0)
        //            {
        //                stack.Push('0');
        //            }

        //        }
        //        else
        //        {
        //            stack.Push(s[i]);
        //        }
                
        //    }

        //    return helper_20230912(stack);


        //}
        //public int helper_20230912(Stack<object> stack)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    while (stack.Count > 0 && (char)stack.Peek() != ')')
        //    {
        //        sb.Append(stack.Pop());
        //    }
        //    if(stack.Count > 0 && (char)stack.Peek() == ')')   {
        //        stack.Pop();
        //    }

        //    string s = sb.ToString();
        //    //char[] arr = temp.ToCharArray();
        //    //Array.Reverse(arr);
        //    //string s = arr.ToString();

        //    int lastNumber = 0;
        //    int number = 0;
        //    int sum = 0;
        //    char oper = '+';
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (char.IsDigit(s[i]))
        //        {
        //            number = number * 10 + s[i] - '0';
        //        }

        //        if (!char.IsDigit(s[i]) && !char.IsWhiteSpace(s[i]) || i == s.Length - 1)
        //        {
        //            if (oper == '+')
        //            {
        //                sum += lastNumber;
        //                lastNumber = number;
        //            }
        //            else if (oper == '-')
        //            {
        //                sum += lastNumber;
        //                lastNumber = -number;
        //            }
        //            else if (oper == '*')
        //            {
        //                lastNumber *= number;
        //            }
        //            else
        //            {
        //                lastNumber /= number;
        //            }
        //            number = 0;
        //            oper = s[i];
        //        }
        //    }
        //    sum += lastNumber;
        //    return sum;


        //}

        #endregion
    }
}
