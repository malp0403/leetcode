using leetcode.BinarySearch;
using leetcode.Class;
using leetcode.DymanicProgramming;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0151_0200;
using leetcode.Problems_0001_500._0201_0250;
using leetcode.Problems_0001_500._0251_0300;
using leetcode.Problems_0001_500._0301_0350;
using leetcode.Problems_0001_500._0451_0500;
using leetcode.Problems_0501_1000._0501_0550;
using leetcode.Problems_0501_1000._0551_0600;
using leetcode.Problems_0501_1000._0701_0750;
using leetcode.Problems_0501_1000._0751_0800;
using leetcode.Problems_0501_1000._0801_0850;
using leetcode.Problems_1001_1500._1001_1050;
using leetcode.Problems_1001_1500._1051_1100;


using leetcode.Problems_1001_1500._1351_1400;

using leetcode.Problems_1001_1500._1151_1200;
using leetcode.Problems_1001_1500._1251_1300;
using leetcode.Problems_1001_1500._1301_1350;

using leetcode.Problems_1001_1500._1401_1450;
using leetcode.Problems_1001_1500._1451_1500;
using leetcode.Problems_1501_2000._1501_1550;
using leetcode.Problems_1501_2000._1551_1600;
using leetcode.Problems_1501_2000._1601_1650;
using leetcode.Problems_1501_2000._1651_1700;
using leetcode.Problems_1501_2000._1701_1750;
using leetcode.Problems_1501_2000._1751_1800;
using leetcode.Problems_1501_2000._1801_1850;
using leetcode.Problems_1501_2000._1851_1900;
using leetcode.Problems_1501_2000._1901_1950;
using leetcode.Problems_1501_2000._1951_2000;
using leetcode.Problems_2001_2500;
using leetcode.Problems_2001_2500._2001_2050;
using leetcode.Problems_2501_3000._2051_2100;
using leetcode.Problems_2501_3000._2101_2150;
using leetcode.Problems_2501_3000._2151_2200;
using leetcode.Problems_2501_3000._2201_2250;
using leetcode.Problems_2501_3000._2301_2350;
using leetcode.Problems_2501_3000._2351_2400;
using leetcode.Problems_2501_3000._2451_2500;
using leetcode.Problems_2501_3000._2601_2650;
using leetcode.Problems_2501_3000._2651_2700;
using leetcode.Problems_2501_3000._2801_2850;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using static leetcode.Problems_2001_2500._2405;
using leetcode.Problems_0501_1000._0951_1000;
using leetcode.Problems_0001_500._0351_0400;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting...");

            int s = int.MinValue; int v = int.MaxValue;
            var obj = new _0452();
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
            obj.FindMinArrowShots(new int[][]
            {
                new int[2]{10,16},
                 new int[2]{2,8},
                new int[2]{1,6},
                new int[2]{7,12}
            });




            Console.Read();




        }





    }
}
