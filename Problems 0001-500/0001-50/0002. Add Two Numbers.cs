using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0002
    {
        #region LeetCode Approach 1: Elementary Math
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode copy = result;

            int increase = 0;

            while (l1 != null || l2 != null || increase !=0)
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
            return result.next;
        }
        #endregion

        #region 07/14/2023
        public ListNode AddTwoNumbers_20230714(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            int incre = 0;
            ListNode temp = answer;

            while (l1 != null || l2 != null)
            {
                int n1 = l1 == null ? 0 : l1.val;
                int n2 = l2 == null ? 0 : l2.val;

                int val = (n1 + n2 + incre) % 10;
                incre = (n1 + n2 + incre) / 10;

                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
                temp.next = new ListNode(val);
                temp = temp.next;

            }
            if (incre == 1)
            {
                temp.next = new ListNode(incre);
            }

            return answer.next;

        }

        #endregion

        #region 01/02/2024 put the incre into the loop condition check increase the speed from 5% to 88%(odd)
        public ListNode AddTwoNumbers_2024_01_02(ListNode l1, ListNode l2)
        {
            ListNode ans = new ListNode(0);
            ListNode temp = ans;
            int incre = 0;
            while(l1 != null || l2 != null || incre !=0)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int curSum = val1 + val2 + incre;
                incre = curSum / 10;

                temp.next = new ListNode(curSum % 10);
                temp = temp.next;
                if(l1 != null)
                {
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    l2 = l2.next;
                }
            }


            return ans.next;

        }
        #endregion
    }


}
