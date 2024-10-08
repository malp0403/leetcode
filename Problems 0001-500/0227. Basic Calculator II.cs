﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using leetcode.Problems;
using System.ComponentModel;

#region TestData
//var obj = new _0227() { };

//var res = obj.Calculate_20230814("3+2*2");
//var res2 = obj.Calculate_20230814(" 3/2 ");
//var res3 = obj.Calculate_20230814(" 3+5 / 2 ");
#endregion

namespace leetcode.Problems
{
    class _0227
    {

        #region Solution
        public int Calculate(string s)
        {
            Stack<string> stack = new Stack<string>() { };
            s = new string((from c in s
                            where !char.IsWhiteSpace(c)
                            select c
                ).ToArray());
            int len = 0;
            while (len < s.Length)
            {
                if (char.IsWhiteSpace(s[len])) len++;
                else
                {
                    var temp = "";

                    //get the whole digits before running others
                    while (len < s.Length && char.IsDigit(s[len]))
                    {
                        temp += s[len].ToString();
                        len++;
                    }
                    if (temp != "")
                    {
                        stack.Push(temp);
                    }
                    if (len >= s.Length) break;
                    if (s[len] == '+' || s[len] == '-')
                    {
                        stack.Push(s[len].ToString());
                        len++;
                    }
                    else if (s[len] == '*' || s[len] == '/')
                    {
                        var temp2 = "";
                        //get the next whole digits before running others
                        var ismultiple = s[len] == '*';
                        len++;
                        while (len < s.Length && char.IsDigit(s[len]))
                        {
                            temp2 += s[len].ToString();
                            len++;
                        }
                        if (ismultiple)
                        {
                            var res = int.Parse(temp2) * int.Parse(stack.Pop());
                            stack.Push(res.ToString());
                        }
                        else
                        {
                            var res = int.Parse(stack.Pop()) / int.Parse(temp2);
                            stack.Push(res.ToString());
                        }
                    }
                }

            }
            int sum = 0;
            while (stack.Count > 0)
            {
                var val = stack.Pop();
                bool isNegative = stack.Count() > 0 && stack.Pop() == "-";
                sum += isNegative ? (0 - int.Parse(val)) : (int.Parse(val));
            }
            return sum;
        }
        #endregion

        #region 08/14/2023
        public int Calculate_20230814(string s)
        {
            int lastNumber = 0;
            int sum = 0;
            int currenNumber = 0;
            char operation = '+';
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c))
                {
                    currenNumber = currenNumber * 10 + c - '0';
                }
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c) || i == s.Length - 1)
                {
                    if (operation == '+' || operation == '-')
                    {
                        sum += lastNumber;
                        lastNumber = operation == '+' ? currenNumber : -currenNumber;
                    }
                    else if (operation == '*')
                    {
                        lastNumber = currenNumber * lastNumber;
                    }
                    else if (operation == '/')
                    {
                        lastNumber = lastNumber / currenNumber;
                    }
                    operation = c;
                    currenNumber = 0;
                }

            }
            sum += lastNumber;

            return sum;

        }
        #endregion

        #region 09/04/2023
        public int Calculate_20230904(string s)
        {
            int lastNumber = 0;
            int sum = 0;
            int number = 0;
            int oper = '+';
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    number = number * 10 + s[i] - '0';
                }

                if (!char.IsDigit(s[i]) && !char.IsWhiteSpace(s[i]) || i == s.Length - 1)
                {



                    if (oper == '*')
                    {
                        lastNumber = lastNumber * number;
                    }
                    else if (oper == '/')
                    {
                        lastNumber = lastNumber / number;

                    }
                    else if (oper == '+')
                    {
                        sum += lastNumber;
                        lastNumber = number;
                    }
                    else
                    {
                        sum += lastNumber;
                        lastNumber = -number;
                    }

                    number = 0;
                    oper = s[i];


                }
            }
            sum += lastNumber;
            return sum;
        }
        #endregion

        #region 09/12/2023
        public int Calculate_20230912(string s)
        {

            int number = 0;
            int lastNumber = 0;
            char operation = '+';
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    number = number * 10 + s[i] - '0';
                }
                if (!char.IsDigit(s[i]) && !char.IsWhiteSpace(s[i]) || i == s.Length - 1)
                {
                    if (operation == '+')
                    {
                        sum += lastNumber;
                        lastNumber = number;
                    }
                    else if (operation == '-')
                    {
                        sum += lastNumber;
                        lastNumber = -number;
                    }
                    else if (operation == '*')
                    {
                        lastNumber *= number;
                    }
                    else
                    {
                        lastNumber /= number;
                    }

                    number = 0;
                    operation = s[i];
                }
            }
            sum += lastNumber;
            return sum;
        }
        #endregion

        #region 07/07/2024
        public int Calculate_2024_07_07(string s)
        {
            int sum = 0;
            int curNumber = 0;
            int n = 0;
            char oper = '+';
            int lastNumber = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    curNumber = curNumber * 10 + s[i] - '0';
                }
                if (!char.IsDigit(s[i]) && !char.IsWhiteSpace(s[i]) || i == s.Length - 1)
                {
                    if (oper == '*')
                    {
                        lastNumber = lastNumber * curNumber;
                    }
                    else if (oper == '/')
                    {
                        lastNumber = lastNumber / curNumber;
                    }
                    else if (oper == '+')
                    {

                        sum += lastNumber;
                        lastNumber = curNumber;
                    }
                    else if (oper == '-')
                    {
                        sum += lastNumber;
                        lastNumber = -curNumber;
                    }

                    oper = s[i];
                    curNumber = 0;
                }
            }
            sum += lastNumber;

            return sum;
        }
        #endregion

        #region 10/02/2024
        public int Calculate_2024_10_02(string s)
        {
            int sum = 0;
            int cur = 0;
            char oper = '+';
            int lastNumber = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    cur = cur * 10 + s[i] - '0';
                }
                if (!char.IsWhiteSpace(s[i]) && !char.IsDigit((char)s[i]) || i == s.Length - 1)
                {
                    if (oper == '*')
                    {
                        lastNumber *= cur;
                    }
                    else if (oper == '/')
                    {
                        lastNumber /= cur;
                    }
                    else if (oper == '+')
                    {
                        sum += lastNumber;
                        lastNumber = cur;
                    }
                    else
                    {
                        sum += lastNumber;
                        lastNumber = -cur;
                    }
                    oper = s[i];
                    cur = 0;
                }
            }
            sum += lastNumber;
            return sum;
        }
        #endregion

        #region 10/05/2024
        public int Calculate_2024_10_05(string s)
        {
            int sum = 0;
            int lastNumber = 0;
            int curNumber = 0;
            char oper = '+';

            for(int i =0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {

                    curNumber = curNumber * 10 + s[i] - '0';
                }
                if ((!char.IsWhiteSpace(s[i]) && !char.IsDigit((char)s[i])) || i == s.Length - 1) 
                {
                    if (oper == '*')
                    {
                        lastNumber  *= curNumber;
                    }else if(oper == '/')
                    {
                        lastNumber /= curNumber;
                    }else if(oper == '+')
                    {
                        sum += lastNumber;
                        lastNumber = curNumber;
                    }
                    else
                    {
                        sum += lastNumber;
                        lastNumber = -curNumber;
                    }

                    curNumber = 0;
                    oper = s[i];
                }

            }

            sum += lastNumber;
            return sum;
        }
        #endregion


    }
}
