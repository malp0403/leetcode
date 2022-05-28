using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class Q10_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list1 == null || list2 == null) return list1 == null ? list2 : list1;
            int p = list1.val;
            int q = list2.val;
            ListNode head;
            if(p <= q)
            {
                head = list1;
                head.next = MergeTwoLists(list1.next, list2);
            }
            else
            {
                head = list2;
                head.next = MergeTwoLists(list1, list2.next);
            }
            return head;
        }
    }
}
