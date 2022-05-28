using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>() { };
            ListNode common = null;
            while(headA != null)
            {
                set.Add(headA);
                headA = headA.next;
            }
            while(headB != null)
            {
                if (set.Contains(headB))
                {
                    common = headB;
                    break;
                }
                headB = headB.next;
            }
            return common;
        }
    
        //-------------------12-27-2021------------------
        public ListNode GetIntersectionNode_R2(ListNode headA, ListNode headB)
        {
            ListNode a = headA;
            ListNode b = headB;
            while(a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }
            return a;
        }
    }
}
