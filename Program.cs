using leetcode.BinarySearch;
using leetcode.DymanicProgramming;
using leetcode.Problems;
using leetcode.Problems._0101_150;
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

            int[] dif = new int[3] { 2, 3, 4 };
            int[] gas = new int[3] { 3, 4, 3 };

            var rest2 = new _0135() { };
            rest2.Candy_v2(new int[] { 1,2,87,87,87,2,1});























            Console.Read();




        }





    }
}
