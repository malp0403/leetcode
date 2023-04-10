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
using System.Net.Http;
using System.Reflection;
using System.Text;
using static leetcode.Problems_2001_2500._2405;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> seen = new HashSet<int>();
            seen.Contains(0);
            int n = 9;
            int n2 = 1;
            Console.WriteLine(n2%3);
         

            int a = 1;
            long b = 1 * a;
            List<int> list = new List<int>() { 1 };
   
            var list2 = list.Select(x => (long)x).ToList();
            long c = list[0];
            int a1 = 1;
            int b2 = 2;

            List<RentalTime> unloadingTimes = new List<RentalTime>();
            unloadingTimes.Add(new RentalTime(new DateTime(2022,1,1), new DateTime(2022,1,3)) );
            unloadingTimes.Add(new RentalTime(new DateTime(2021,1,2), new DateTime(2021, 1, 3)));
            unloadingTimes.Add(new RentalTime(new DateTime(2023, 1, 1), new DateTime(2023, 1, 3)));
            unloadingTimes.Add(new RentalTime(new DateTime(2020, 1, 1), new DateTime(2020, 1, 3)));

            RentalTime t1 = new RentalTime(new DateTime(2022, 1, 1), new DateTime(2022, 1, 3));
            RentalTime t2 = new RentalTime(new DateTime(2022, 1, 1), new DateTime(2022, 1, 3));

            foreach ( var item in typeof(RentalTime).GetProperties())
            {
                var ttt = item.GetValue(t1);
                Console.WriteLine(ttt);

            }
            var list3 = unloadingTimes.ToList();
            list3.Sort((a,b)=>a.Start.CompareTo(b.Start));

            var s = string.Format("ad{0},{1}", "123", "kkkkkk");

            TreeNode t5 = new TreeNode(5);
            //TreeNode t1 = new TreeNode(1);
            //TreeNode t2 = new TreeNode(2);
            //TreeNode t3 = new TreeNode(3);
            //TreeNode t4 = new TreeNode(4);
            //TreeNode t6 = new TreeNode(6);
            //t5.left = t1;
            //t5.right = t2;
            //t1.left = t3;
            //t2.left = t6;
            //t2.right = t4;

            var obj2 = new _2096() ;
             var obj3 = obj2.testtest();

            var obj = new _0208() { };
            obj.test1();

























            Console.Read();




        }





    }
}
