using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0143
    {
        public void ReorderList(ListNode head)
        {
            if (head == null) return;
            Stack<ListNode> stack = new Stack<ListNode>() { };
            ListNode curr = head;
            while(curr != null)
            {
                stack.Push(curr);
                curr = curr.next;
            }

            int size = stack.Count / 2;
            ListNode start = head;
            while (size > 0 && start != null)
            {
                var temp = start.next;
                start.next = stack.Pop();
                start = start.next;
                if(start != temp)
                {
                    start.next = temp;
                    start = start.next;
                }
                size--;
              
            }
            start.next = null;
        }
    }
}
