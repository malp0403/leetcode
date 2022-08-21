using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0206
    {
        public ListNode ReverseList(ListNode head)
        {
            Dictionary<ListNode, ListNode> ParentDic = new Dictionary<ListNode, ListNode>() { };

            while (head != null && head.next != null)
            {
                var tempChild = head.next;
                head.next = null;
                if (ParentDic.ContainsKey(head))
                {
                    head.next = ParentDic[head];
                }
                ParentDic.Add(tempChild, head);
                head = tempChild;
            }

            if (head != null && ParentDic.ContainsKey(head))
            {
                head.next = ParentDic[head];
            }
            return head;
        }

        public ListNode ReverseList_v2(ListNode head)
        {
            ListNode pre = null;
            ListNode curr = head;
            while (curr != null)
            {
                var temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }
            return pre;
        }


        //**********12/15/2021 iterative***************
        public ListNode ReverseList_R2(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while(cur != null)
            {
                var temp = head.next;

                cur.next = pre;
                pre = cur;

                cur = temp;
            }
            return pre;

        }

        //**********12/15/2021 recursive***************
        public ListNode ReverseList_R2_recursive(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = ReverseList_R2_recursive(head.next);
            head.next.next = head;
            head.next = null;
            return p;

        }
    }
}
