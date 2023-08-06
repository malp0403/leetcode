using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0002
    {
        #region answer
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode copy = result;

            int increase = 0;

            while(l1 !=null || l2 != null)
            {
                int num1 = l1 != null ? l1.val : 0;
                int num2 = l2 != null ? l2.val : 0;
                int sum = num1 + num2 + increase;
                copy.next = new ListNode(sum % 10);
                copy = copy.next;
                increase = sum / 10;
                if (l1 != null) { l1 = l1.next; }
                if (l2 != null) { l2 = l2.next; }

                
            }
            if (increase == 1)
            {
                copy.next = new ListNode(1);
            }
            return result.next;
        }
        #endregion

        #region 07/14/2023
        public ListNode AddTwoNumbers_20230714(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            int incre = 0;
            ListNode temp = answer;

            while(l1 !=null || l2 != null)
            {
                int n1 = l1 == null ? 0 : l1.val;
                int n2 = l2 == null ? 0 : l2.val;

                int val = (n1 + n2 + incre) % 10;
                incre = (n1 + n2 + incre)/10;

                if(l1 != null)
                {
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    l2 = l2.next;
                }
                temp.next = new ListNode(val);
                temp = temp.next;

            }
            if(incre == 1)
            {
                temp.next = new ListNode(incre);
            }

            return answer.next;

        }

        #endregion
    }


}
