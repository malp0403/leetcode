using leetcode.Class;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0001_50;
using leetcode.Problems_0001_500._0051_100;
using leetcode.Problems_0001_500._0101_150;
using leetcode.Problems_0001_500._0151_0200;
using leetcode.Problems_0001_500._0201_0250;
using leetcode.Problems_0001_500._0251_0300;
using leetcode.Problems_0001_500._0301_0350;
using leetcode.Problems_0001_500._0351_0400;
using leetcode.Problems_0001_500._0401_0450;
using leetcode.Problems_0001_500._0451_0500;
using leetcode.Problems_0501_1000._0701_0750;
using leetcode.Problems_0501_1000._0751_0800;
using leetcode.Problems_0501_1000._0801_0850;
using leetcode.Problems_1001_1500;
using leetcode.Problems_1001_1500._1451_1500;
using leetcode.Problems_1501_2000;
using leetcode.Problems_1501_2000._1651_1700;
using leetcode.Problems_1501_2000._1701_1750;
using leetcode.Problems_2001_2500._2001_2050;
using leetcode.Problems_2501_3000._2201_2250;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using static leetcode.Problems._0339;

#region Question
/*
 Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.

 

Example 1:

Input: num1 = "11", num2 = "123"
Output: "134"
Example 2:

Input: num1 = "456", num2 = "77"
Output: "533"
Example 3:

Input: num1 = "0", num2 = "0"
Output: "0"
 

Constraints:

1 <= num1.length, num2.length <= 104
num1 and num2 consist of only digits.
num1 and num2 don't have any leading zeros except for the zero itself.
 */
#endregion

#region Test

#endregion

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            int s = int.MinValue; int v = int.MaxValue;
            var obj = new _0452();
            obj.FindMinArrowShots_2024_09_30(new int[][]
   {
                new int[2]{10,16},
                 new int[2]{2,8},
                new int[2]{1,6},
                new int[2]{7,12}
   });
            obj.FindMinArrowShots(new int[][]
            {
                            new int[2]{9,12},
                             new int[2]{1,10},
                            new int[2]{4,11},
                            new int[2]{8,12},
                            new int[2]{3,9},
                            new int[2]{6,9},
                            new int[2]{6,7}
            });


            obj.FindMinArrowShots(new int[][]
            {
                            new int[2]{-2147483646,-2147483645},
                             new int[2]{2147483646,2147483647}
            });
   

        }





    }
}
