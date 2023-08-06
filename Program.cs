using leetcode.BinarySearch;
using leetcode.Class;
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
            //int[] nums = new int[6] { -1, 0, 1, 2, -1, 4 };
            //var obj = new _0015() { };
            //var answer = obj.ThreeSum_20230718(nums);

            //int[] nums2 = new int[4] { -1, 0,0,1 };
            //var obj2 = new _0015() { };
            //var answer2 = obj2.ThreeSum_20230718(nums2);

            //ListNode n1 = new ListNode(1);
            //ListNode n2 = new ListNode(2);
            //ListNode n3 = new ListNode(3);
            //ListNode n4 = new ListNode(4);
            //ListNode n5 = new ListNode(5);
            //n1.next = n2; n2.next = n3; n3.next = n4; n4.next = n5;

            //var obj = new _0025();
            //obj.ReverseKGroup_20230724(n1, 2);

            var obj = new _0042();
            var answer = obj.Trap_20230725(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            var answer2 = obj.Trap_20230726_stack(new int[] { 4, 2, 0, 3, 2, 5 });























            Console.Read();




        }





    }
}
