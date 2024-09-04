using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
#region Examples
/*
 Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

The test cases are generated so that the length of the output will never exceed 105.

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
 

Constraints:

1 <= s.length <= 30
s consists of lowercase English letters, digits, and square brackets '[]'.
s is guaranteed to be a valid input.
All the integers in s are in the range [1, 300].
 */
#endregion
namespace leetcode.Problems
{
    class _0394
    {
        #region 11/24/2023
        public string DecodeString(string s)
        {
            Stack<object> stack = new Stack<object>();

            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    string temp = "";
                    while (stack.Count>0&&!(stack.Peek() is char && (char)stack.Peek() =='['))
                    {
                        temp = stack.Pop() + temp;
                    }
                    stack.Pop();
                    string number = "";
                    while(stack.Count>0 && stack.Peek() is char && char.IsNumber((char)stack.Peek()))
                    {
                        number = (char)stack.Pop() + number;
                    }
                    int num = number ==""?1:int.Parse(number);
                    string ans = "";
                    while (num > 0)
                    {
                        ans += temp;
                        num--;
                    }
                    stack.Push(ans);

                }
                else
                {
                    stack.Push(s[i]);
                }


            }

            string answer = "";
            while (stack.Count > 0)
            {
                answer = stack.Pop() + answer;
            }
            return answer;
        }
        #endregion

        #region 09/01/2024
        public string DecodeString(string s)
        {
            Stack<string> stack = new Stack<string>();

            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    string temp = "";
                    while(stack.Count >0 && stack.Peek() != "[")
                    {
                        temp = stack.Pop() + temp;
                    }
                    stack.Pop();

                    string number = "";
                    while(stack.Count >0 && char.IsDigit(stack.Peek().ToCharArray()[0]))
                    {
                        number = stack.Pop() + number;
                    }
                    int count = number ==""?1:int.Parse(number);
                    string ans = "";
                    while (count > 0)
                    {
                        count--;
                        ans += temp;
                    }
                    stack.Push(ans);

                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }

            string answer = "";
            while (stack.Count > 0)
            {
                answer = stack.Pop() + answer;
            }

            return answer;

        }
            #endregion

        }
    }
