using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0141
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>() { };
            while (head != null)
            {
                if (set.Contains(head))
                {
                    return true;
                }
                set.Add(head);
                head = head.next;
            }
            return false;
        }

        //*********************O(1)**************

        public bool HasCycle_V2(ListNode head)
        {
            if (head == null || head.next ==null) return false;
            ListNode slow = head.next;
            ListNode fast = head.next.next;
            while(fast != null && fast.next !=null)
            {
                if (slow == fast) return true;
                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }
    }
}
