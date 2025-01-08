using System;
using System.Collections.Generic;
using System.Text;

#region Examples
/*
 8. String to Integer (atoi)
Solved
Medium
Topics
Companies
Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:

Read in and ignore any leading whitespace.
Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
Read in next the characters until the next non-digit character or the end of the input is reached. The rest of the string is ignored.
Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
Return the integer as the final result.
Note:

Only the space character ' ' is considered a whitespace character.
Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
 

Example 1:

Input: s = "42"
Output: 42
Explanation: The underlined characters are what is read in, the caret is the current reader position.
Step 1: "42" (no characters read because there is no leading whitespace)
         ^
Step 2: "42" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "42" ("42" is read in)
           ^
The parsed integer is 42.
Since 42 is in the range [-231, 231 - 1], the final result is 42.
Example 2:

Input: s = "   -42"
Output: -42
Explanation:
Step 1: "   -42" (leading whitespace is read and ignored)
            ^
Step 2: "   -42" ('-' is read, so the result should be negative)
             ^
Step 3: "   -42" ("42" is read in)
               ^
The parsed integer is -42.
Since -42 is in the range [-231, 231 - 1], the final result is -42.
Example 3:

Input: s = "4193 with words"
Output: 4193
Explanation:
Step 1: "4193 with words" (no characters read because there is no leading whitespace)
         ^
Step 2: "4193 with words" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "4193 with words" ("4193" is read in; reading stops because the next character is a non-digit)
             ^
The parsed integer is 4193.
Since 4193 is in the range [-231, 231 - 1], the final result is 4193.
 

Constraints:

0 <= s.length <= 200
s consists of English letters (lower-case and upper-case), digits (0-9), ' ', '+', '-', and '.'.
 */
#endregion
#region tESTING
/*
             int a = int.MaxValue; //2147483647
            int b = int.MinValue; //2147483648

            var obj = new _0008();
            
            var test3 = obj.MyAtoi_2024_01_14("-91283472332");

            var test2 = obj.MyAtoi_2024_01_14("words and 987");

            var test =obj.MyAtoi_2024_01_14("   -42");
 */
#endregion
namespace leetcode.Problems
{
    class _0008
    {
        #region answer
        public int MyAtoi(string s)
        {
            int test = Int32.MinValue;
            bool isPositive = true;
            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    continue;
                }else if(!char.IsDigit(s[i])&& s[i] != '-'&& s[i] != '+')
                {
                    return 0;
                }
                if(s[i] == '-' || s[i] == '+')
                {
                    if (i < s.Length - 1&& !char.IsDigit(s[i+1])) return 0;
                    isPositive = s[i] == '+';
                }
                else if(char.IsDigit(s[i]))
                {
                    int result = 0;
                    int j = i;
                    while (j < s.Length && char.IsDigit(s[j]))
                    {
                        int digit = s[j] - '0';
                        if(result > Int32.MaxValue/10 
                            || ( result == Int32.MaxValue/10 && digit > Int32.MaxValue%10))
                        {
                            return isPositive ? Int32.MaxValue : Int32.MinValue;
                        }
                        result = result * 10 + digit;
                        j++;
                    }
                    return isPositive?result:0-result;
                }
            }
            return 0;
        }
        #endregion

        #region 07/11/2022

        public int MyAtoi_R1(string s)
        {
            int sum = 0;
            int indx = 0;
            while(indx < s.Length)
            {
                if (char.IsDigit(s[indx])){
                    bool isNegative = indx - 1 >= 0 && s[indx - 1] == '-';
                    while(indx < s.Length && char.IsDigit(s[indx]))
                    {
                        int num = isNegative ? '0' - s[indx] : s[indx] - '0';
                        if(sum > Int32.MaxValue/10 || (sum == Int32.MaxValue/10 && num > Int32.MaxValue % 10))
                        {
                            sum = Int32.MaxValue;
                            break;
                        }
                        if(sum < Int32.MinValue/10 || (sum == Int32.MinValue/10 && num < Int32.MinValue % 10))
                        {
                            sum = Int32.MinValue;
                            break;
                        }
                        sum = sum * 10 + num;
                        indx++;

                    }
                    break;
                }
                else if(s[indx] == ' ' )
                {
                    indx++;
                }else if (s[indx] == '-' || s[indx] == '+')
                {
                    if(indx +1 <s.Length && char.IsDigit(s[indx+1]))
                    {
                        indx++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return sum;
        }

        #endregion

        #region 01/14/2024
        public int MyAtoi_2024_01_14(string s)
        {
            int rev = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                else if (!char.IsDigit(s[i]) && s[i] != '-' && s[i] != '+')
                {
                    return 0;
                }
                if (s[i] == '-' || s[i] == '+')
                {
                    if (isValid_2024_01_14(i, s))
                    {
                        rev = read_2024_01_14(i + 1, s, s[i] == '+');
                        break;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (char.IsDigit(s[i]))
                {
                    rev = read_2024_01_14(i, s, true);
                    break;
                }
            }
           

            return rev;

        }
        //21474836482
        //2147483647
        public bool isValid_2024_01_14(int index, string s)
        {
            if (index == s.Length - 1) return false;
            if (char.IsDigit(s[index + 1])) return true;
            return false;
        }
        
        public int read_2024_01_14(int index, string s, bool isPositive)
        {
            int rev = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {

                int number = s[index] - '0';
                //2147483647
                if (rev > int.MaxValue/10 || (rev == int.MaxValue/10 && number > 7))
                {
                    return isPositive ? int.MaxValue : int.MinValue;
                }

                rev = rev * 10 + number;
                index++;
            }
            return isPositive?rev:-rev;
        }
        #endregion
    }
}
