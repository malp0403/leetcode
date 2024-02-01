using leetcode.Problems;
using leetcode.Problems_0001_500._0001_50;
using leetcode.Problems_0501_1000._0751_0800;
using leetcode.Problems_0501_1000._0801_0850;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;


namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting...");

            int a = int.MaxValue; //2147483647
            int b = int.MinValue; //2147483648

            int[] nums = new int[4] { -1, 2, 1, -4 };
            var obj = new _0016() { };
            var answer = obj.ThreeSumClosest_2024_01_21(nums,2);

            //int[] nums2 = new int[4] { -1, 0, 0, 1 };
            //var obj2 = new _0015() { };
            //var answer2 = obj2.ThreeSum_2024_01_21(nums2);

            Console.Read();
        }





    }
}
