using leetcode.BinarySearch;
using leetcode.DymanicProgramming;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0451_0500;
using leetcode.Problems_1501_2000._1651_1700;
using leetcode.Problems_2001_2500;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            var obj4 = new _1647() { };
            obj4.MinDeletions("abcdefghijklmnopqrstuvwxwz");

            var obj3 = new _2028() { };
            var res3 = obj3.MissingRolls(new int[] { 6, 1, 5, 2 }, 4, 4);
         

            var obj2 = new _2035() { };
            var res2 = obj2.MinimumDifference(new int[] { -36, 36 });



            var obj = new _2246();
            var res = obj.LongestPath(new int[] { -1, 0, 1 }, "aab");

            res = obj.LongestPath(new int[] { -1, 0, 0, 1, 1, 2 }, "abacbe");
























            Console.Read();




        }





    }
}
