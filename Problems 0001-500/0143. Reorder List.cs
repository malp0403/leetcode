using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0143
    {
        #region Solution
        public void ReorderList(ListNode head)
        {
            if (head == null) return;
            Stack<ListNode> stack = new Stack<ListNode>() { };
            ListNode curr = head;
            while (curr != null)
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
                if (start != temp)
                {
                    start.next = temp;
                    start = start.next;
                }
                size--;

            }
            start.next = null;
        }
        #endregion

        #region 03/26/2024
        public void ReorderList_2024_03_26(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast !=null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode meetPoint = slow;

            //reverse
            ListNode prev = null;
            while(slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;

                prev = slow;
                slow = next;
            }


            ListNode forward = head;
            ListNode backward = prev;


            while(backward.next != null)
            {

                ListNode temp1 = forward.next;
                ListNode temp2 = backward.next;

                forward.next = backward;
                backward.next = temp1;

                forward = temp1;
                backward = temp2;
            }

        }
        #endregion
    }
}
