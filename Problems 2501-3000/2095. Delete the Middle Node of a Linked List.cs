using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2051_2100
{
    internal class _2095
    {
        #region 10/09/2023   remeber to check head is null or head is single node situation.

        public ListNode DeleteMiddle(ListNode head)
        {
            if(head == null || head.next ==null) return null;
            ListNode slow = head;
            ListNode fast = head;
            ListNode pre_slow = null;
            while(fast.next !=null && fast.next.next != null)
            {
                pre_slow = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            if(fast.next == null)
            {
                if(pre_slow != null)
                {
                    pre_slow.next = pre_slow.next.next;
                }
            }else if(fast.next.next == null)
            {
                slow.next = slow.next.next;
            }
            return head;
        }

        #endregion
    }
}
