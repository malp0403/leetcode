using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500
{
    internal class _2095
    {
        #region initial fast = head.next.next Approach 2: Fast and Slow Pointers 09/16/2024 
        public ListNode DeleteMiddle_2024_09_16(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode slow = head;
            ListNode fast = head.next.next;


            while(fast !=null && fast.next != null)
            {
               
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return head;
        }
        #endregion

    }
}
