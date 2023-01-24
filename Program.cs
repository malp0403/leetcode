using leetcode.BinarySearch;
using leetcode.DymanicProgramming;
using leetcode.Problems;
using leetcode.Problems._0101_150;
using leetcode.Problems_0001_500._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj3= new _0457(){ };
            obj3.CircularArrayLoop(new int[] { -2,1,-1,-2,-2 });

            obj3.CircularArrayLoop(new int[] { 2, -1, 1, 2, 2});

            var obj2 = new _0443() { };
            obj2.Compress_20221230(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });

            var obj1 = new _0146(2) { };
            int a = 0;
            obj1.Put(1, 1);
            obj1.Put(2, 2);
            a= obj1.Get(1);
            obj1.Put(3, 3);
            a = obj1.Get(2);
            obj1.Put(4, 4);
            a = obj1.Get(1);
            a =obj1.Get(3);
            a =obj1.Get(4);


            //var obj1 = new _0138() { };
            //_0138.Node n7 =new _0138.Node(7);
            //_0138.Node n13 = new _0138.Node(13);
            //_0138.Node n11 = new _0138.Node(11);
            //_0138.Node n10 = new _0138.Node(10);
            //_0138.Node n1 = new _0138.Node(1);

            //n7.next = n13;
            //n13.next = n11;
            //n11.next = n10;
            //n10.next = n1;
            //n7.random = null;
            //n13.random = n7;
            //n11.random = n1;
            //n10.random = n11;
            //n1.random = n7;

            //var res1 = obj1.CopyRandomList_20220818(n7);

            char[][] board = new char[3][];
            board[0] = new char[3] { 'X', 'X', 'X' };
            board[1] = new char[3] { 'X', 'O', 'X' };
            board[2] = new char[3] { 'X', 'X', 'X' };

            //var rest1 = new _0130() { };
            //rest1.Solve(board);

























            Console.Read();




        }





    }
}
