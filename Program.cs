using leetcode.BinarySearch;
using leetcode.DymanicProgramming;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -921;
            double x1 = 1;
            double x2 = 1 / 2.0;

            var obj = new _0068() { };
            char[][] test = new char[9][] {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
                    };

            ListNode n1 = new ListNode(1);
            n1.next = new ListNode(2);
            n1.next.next = new ListNode(3);
            n1.next.next.next = new ListNode(4);
            n1.next.next.next.next = new ListNode(5);

            var test123= obj.FullJustify(new string[] {"Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"}, 20);

            ListNode n2 = new ListNode(1);
            n2.next = new ListNode(3);
            n2.next.next = new ListNode(4);
            ListNode n3 = new ListNode(2);
            n3.next = new ListNode(6);
































            Console.Read();




        }





    }
}
