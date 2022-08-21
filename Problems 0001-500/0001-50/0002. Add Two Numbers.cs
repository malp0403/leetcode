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
    }


}
