using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Test
/*
      var obj = new _1249();
            obj.MinRemoveToMakeValid_2024_10_01("))((");

            obj.MinRemoveToMakeValid_2024_10_01("lee(t(c)o)de)");
 */
#endregion

namespace leetcode.Problems
{
    class _1249
    {
        #region  Approach 1: Using a Stack and String Builder; store to be removed Index

        #endregion

        #region Solution
        public string MinRemoveToMakeValid_s(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            List<char> li = new List<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(s[i]);
                    li.Add(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count != 0)
                    {
                        li.Add(s[i]);
                        stack.Pop();
                    }
                }
                else
                {
                    li.Add(s[i]);
                }
            }
            while (stack.Count > 0)
            {
                var indx = li.FindLastIndex(x => x == '(');
                li.RemoveAt(indx);
                stack.Pop();
            }
            return String.Join("", li.ToArray());
        }

        #endregion

        #region 01/07/2022
        //01-07-2022------------------------------
        public string MinRemoveToMakeValid_R2(string s)
        {
            StringBuilder ans = new StringBuilder { };
            Stack<char> stack = new Stack<char>() { };
            foreach (var c in s)
            {
                if (c == '(')
                {
                    stack.Push('(');
                }
                else if (c == ')')
                {
                    if (stack.Count == 0) continue;
                    stack.Pop();
                }
                ans.Append(c);
            }
            int count = stack.Count;
            string temp = ans.ToString();
            while (count != 0)
            {
                count--;

                var indx = temp.LastIndexOf('(');
                temp = temp.Substring(0, indx) + temp.Substring(indx + 1);
            }
            return temp;
        }
        //----------------------------------------
        #endregion

        #region 10/01/2024
        public string MinRemoveToMakeValid_2024_10_01(string s)
        {
            
            List<string> list = Enumerable.Repeat("", s.Length).ToList();

            int left = 0;
            for(int i =0; i < s.Length; i++)
            {
                string str = s[i].ToString();
                if (str == "(")
                {
                    left++;
                    list[i] = str;
                }else if (str == ")")
                {
                    if (left == 0) continue;
                    else
                    {
                        left--;
                        list[i] = str;
                    }
                }
                else
                {
                    list[i] = str;
                }
            }

            int j= list.Count - 1;
            while (j >=0 && left>0)
            {
                if (list[j] == "(")
                {
                    left--;
                    list[j] = "";
                }
                j--;
            }

            return string.Join("", list);

 
        }
        #endregion

    }
}
