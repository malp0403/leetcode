using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0023
    {
        #region 07/19/2022
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 1) return lists[0];
            ListNode d = null;
            for(int i =0; i < lists.Length; i++)
            {
                d = helper(d, lists[i]);
            }
            return d;
        }
        public ListNode helper(ListNode p1, ListNode p2)
        {
            ListNode dummy = new ListNode();
            ListNode res = dummy;
            while (p1 != null || p2 != null)
            {
                if (p1 == null)
                {
                    dummy.next = p2;
                    p2 = null;
                }
                else if (p2 == null)
                {
                    dummy.next = p1;
                    p1 = null;
                }
                else if (p1.val < p2.val)
                {
                    dummy.next = p1;
                    dummy = dummy.next;
                    p1 = p1.next;
                }
                else
                {
                    dummy.next = p2;
                    dummy = dummy.next;
                    p2 = p2.next;
                }
            }
            return res.next;
        }
        #endregion
    }
}
