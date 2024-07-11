using leetcode.Class;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0001_50;
using leetcode.Problems_0001_500._0101_150;
using leetcode.Problems_0001_500._0151_0200;
using leetcode.Problems_0001_500._0201_0250;
using leetcode.Problems_0001_500._0251_0300;
using leetcode.Problems_0501_1000._0751_0800;
using leetcode.Problems_0501_1000._0801_0850;
using leetcode.Problems_1501_2000._1651_1700;
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


namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new _0270();
            TreeNode n4 = new TreeNode(4);
            TreeNode n2 = new TreeNode(2);
            TreeNode n5 = new TreeNode(5);
            TreeNode n1 = new TreeNode(1);
            TreeNode n3 = new TreeNode(3);
            n4.left = n2; n4.right = n5;
            n2.left = n1;n2.right = n3;

            obj.ClosestValue_2024_07_11(n4,3.7);

            TreeNode n1_ = new TreeNode(1);
            TreeNode n2_ = new TreeNode(3);
            n1_.right = n2_;
            obj.ClosestValue_2024_07_11(n1_,3.4);



            Console.Write("123");
        }





    }
}
