using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

#region Warning
// 特别注意 head = [1] n =1， 结果为 []  的特殊情况 
#endregion
namespace leetcode.Problems
{
    class _0019
    {
        #region solution_1
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode cur = head;
            int count = 0;
            while (cur != null)
            {
                count++;
                cur = cur.next;
            }
            int target = count - n;
            if (target == count) return head.next;
            int indx = 0;

            cur = head;
            ListNode prev = new ListNode();
            while(cur != null)
            {
                if (indx != target)
                {
                    prev.next = cur;
                    prev = prev.next;
                }
                cur = cur.next;

                indx++;
            }
            prev.next = null;
            return head;
        }

        public ListNode RemoveNthFromEnd_2(ListNode head, int n)
        {
            ListNode cur = head;
            int count = 0;
            while (cur != null)
            {
                count++;
                cur = cur.next;
            }
            int target = count - n;

            ListNode dummy = new ListNode();
            ListNode first = dummy;
            dummy.next = head;
            while (target > 0)
            {
                target--;
                first = first.next;

            }
            first.next = first.next.next;
            return dummy.next;
        }
        public ListNode RemoveNthFromEnd_3(ListNode head, int n)
        {
            ListNode dummy = new ListNode() { };
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for(int i =1; i <= n + 1; i++)
            {
                first = first.next;
            }
            while(first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy;
        }
        #endregion

        #region 07/18/2023

        public ListNode removeNthFromEnd_20230718(ListNode head,int n)
        {
            // count the total

            int total = 0;
            ListNode head_copy = head;
            while(head_copy != null)
            {
                total++;
                head_copy = head_copy.next;
            }
            if (total == n) return head.next;

            //the node before removed node
            int target_number = total - n-1;
            

            ListNode head_copy2 = head;
            while(true)
            {
                if(target_number == 0)
                {
                    head_copy2.next = head_copy2.next.next;
                    break;
                }
                head_copy2 = head_copy2.next;
                target_number--;
            }
            return head;
        }
        public ListNode removeNthFromEnd_20230718_onePass(ListNode head, int n)
        {
            ListNode n1 = head;
            ListNode n2 = head;

            int remain = n;
            while(remain != 0)
            {
                n1 = n1.next;
                remain--;
            }

            if (n1 == null) return n2.next;

            while(n1.next != null)
            {
                n1 = n1.next;
                n2 = n2.next;
            }

            n2.next = n2.next.next;
            return head;

        }

        #endregion

        #region 07/22/2023  One way pass.
        public ListNode RemoveNthFromEnd_20230722(ListNode head, int n)
        {
            ListNode n1 = new ListNode();
            ListNode n2 = n1;
            n1.next = head;

            while(n >=0)
            {
                n2 = n2.next;
                n--;
            }

            if(n2 == null) return head.next;

            while(n2 != null)
            {
                n2 = n2.next;
                n1 = n1.next;
            }

            

            n1.next = n1.next.next;



            return head;


        }
            #endregion
        }
    }
