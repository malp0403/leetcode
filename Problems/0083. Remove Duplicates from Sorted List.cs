using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0083
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            HashSet<int> seen = new HashSet<int>() { };
            ListNode temp = new ListNode();
            ListNode answer = temp;
            while(head != null)
            {
                if (!seen.Contains(head.val))
                {
                    temp = new ListNode(head.val);
                    temp = temp.next;
                    seen.Add(head.val);
                }
                head = head.next;
            }
            return answer;
        }
        public ListNode DeleteDuplicates_v2(ListNode head)
        {
            ListNode curr = head;
            while(curr != null && curr.next != null)
            {
                if(curr.next.val == curr.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return head;
        }

        //-------------12-27-2021---------------
        public ListNode DeleteDuplicates_R3(ListNode head)
        {
            ListNode pre = null;
            ListNode ans = new ListNode();
            ListNode temp = ans;
            while(head != null)
            {
                if(pre ==null || head.val != pre.val)
                {
                    temp.next = head;
                    temp = temp.next;
                    pre = head;
                }
                else
                {
                    temp.next = null;
                }
                head = head.next;
            }
            return ans.next;
        }
        public ListNode DeleteDuplicates_R3_v2(ListNode head)
        {

            ListNode ans = head;
            while (head != null && head.next !=null)
            {
                if(head.val != head.next.val)
                {
                    head = head.next;
                }
                else
                {
                    head.next = head.next.next;
                }
            }
            return ans;
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
