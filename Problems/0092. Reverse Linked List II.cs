using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0092
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode answer = head;
            Stack<ListNode> stack = new Stack<ListNode>() { };
            int count = 1;
            ListNode prev = null;
            ListNode next = null;
            while (answer != null && count <= right)
            {
                if(count < left) { prev = answer; }
                else
                {
                    stack.Push(answer);
                }
                if (count == right)
                {
                    next = answer.next;
                }
                answer = answer.next;
                count++;
            }
            if(left == 1)
            {
                head = stack.Peek();
            }
            while(stack.Count != 0)
            {
                var temp = stack.Pop();
                if (prev == null) {
                    prev = temp;
                }
                else
                {
                    prev.next = temp;
                    prev = prev.next;
                }
                

               
            }
            prev.next = next;
            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
