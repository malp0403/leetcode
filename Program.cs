using leetcode.Class;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0001_50;
using leetcode.Problems_0001_500._0101_150;
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

            var obj = new _0143() { };
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3= new ListNode(3);
            ListNode n4 = new ListNode(4);
            n1.next = n2;n2.next = n3;n3.next = n4;
            obj.ReorderList_2024_03_26(n1);

           

            //var res = obj.Divide_2024_02_01_approach2(10, 3);


            Console.Write("123");
        }





    }
}
