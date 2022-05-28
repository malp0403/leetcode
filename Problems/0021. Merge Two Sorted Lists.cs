using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0021
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode();
            var curr = head;
            while(list1 !=null || list2 != null)
            {
                if(list1 == null)
                {
                    curr.next = list2;
                    list2 = list2.next;
                }else if(list2 == null)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val <= list2.val)
                    {
                        curr.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        curr.next = list2;
                        list2 = list2.next;
                    }
                }
                curr = curr.next;
            }
            return head.next;

        }
        public ListNode MergeTwoLists_R2(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode() { };
            while(list1 != null && list2 != null)
            {
                if(list1.val <= list2.val)
                {
                    head.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    head.next = list2;
                    list2 = list2.next;
                }
            }
            head.next = list1 == null ? list2 : list1;
            return head.next;
        }
    }
}
