using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = new ListNode();
            ListNode answer = temp;
            while(head != null)
            {
                if(head.val != val)
                {
                    temp.next = head;
                }
                head = head.next;

            }
            return answer.next;
        }

        public ListNode RemoveElements_R2(ListNode head,int val)
        {
            ListNode anser = new ListNode();

            ListNode temp = anser;
            while(head != null)
            {
                if(head.val != val)
                {
                    temp.next = head;
                    temp = temp.next;
                }
                else
                {
                    temp.next = null;
                }
                head = head.next;
            }
            return anser.next;
        }
    }
}
