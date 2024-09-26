using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0012
    {
        #region hard-coded
        public string IntToRoman(int num)
        {
            string result = "";
            int level = 0;
            while(num > 0)
            {
                int left = num % 10;
                result = helper(level, left) + result;
                num = num / 10;
                level++;
            }
            return result;
        }

        public string helper(int level,int num)
        {
            string a, b, c;
            switch (level)
            {
                case 3: a = "M";b = "";c = ""; break;
                case 2: a = "C";b = "D";c = "M";break;
                case 1: a = "X";b = "L"; c = "C";break;
                case 0: a = "I";b = "V"; c = "X";break;
                default: a = "";b = "";c = "";break;
            }
            switch (num)
            {
                case 1: return a;
                case 2: return a + a;
                case 3: return a + a + a;
                case 4: return a+b;
                case 5: return b;
                case 6:return b + a;
                case 7: return b + a + a;
                case 8: return b + a + a + a;
                case 9:return a + c;
                default: return "";
            }
        }
        #endregion
        #region fix into 

        public string IntToRoman_solution2(int num)
        {
            int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strings = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


            StringBuilder sb = new StringBuilder() { };
            for (int i = 0; i < nums.Length && num > 0; i++)
            {
                while(nums[i] <= num)
                {
                    sb.Append(strings[i]);
                    num = num - nums[i];
                }
            }
            return sb.ToString();
        }
        #endregion

        #region 01/14/2024 Approach 1: Greedy
        public string IntToRoman_2024_01_14(int num) 
        {
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();
            for(int i=0; i < values.Length; i++)
            {
                while (values[i] <= num)
                {
                    num -= values[i];
                    sb.Append(symbols[i]);
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}
