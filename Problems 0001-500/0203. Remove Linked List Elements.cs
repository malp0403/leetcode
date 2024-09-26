using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
#region Test
/*
             var obj = new _0203() { };
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(6);
            ListNode n4 = new ListNode(3);
            ListNode n5 = new ListNode(4);
            ListNode n6 = new ListNode(5);
            ListNode n7 = new ListNode(6);
            n1.next = n2; n2.next = n3;n3.next = n4;n4.next = n5;n5.next = n6;n6.next = n7;
            obj.RemoveElements_2024_06_11(n1,6);
 */
#endregion
namespace leetcode.Problems
{
    class _0203
    {
        #region Solution
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = new ListNode();
            ListNode answer = temp;
            while (head != null)
            {
                if (head.val != val)
                {
                    temp.next = head;
                }
                head = head.next;

            }
            return answer.next;
        }

        public ListNode RemoveElements_R2(ListNode head, int val)
        {
            ListNode anser = new ListNode();

            ListNode temp = anser;
            while (head != null)
            {
                if (head.val != val)
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
        #endregion

        #region 06/11/2024

        public ListNode RemoveElements_2024_06_11(ListNode head, int val)
        {
            ListNode prev = new ListNode();
            ListNode answer = prev;

            while (head !=null)
            {
                if(head.val == val)
                {
                    while (head != null && head.val == val)
                    {
                        head = head.next;
                    }
                    prev.next = head;
                    prev = prev.next;
                }
                else
                {
                    prev.next = head;
                    prev = prev.next;

                    head = head.next;
                }

            }
            prev.next = null;

            return answer.next;
        }

        #endregion

    }
}
