using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500
{
    internal class _2130
    {
        #region Approach 3: Reverse Second Half In Place 09/22/2024
        public int PairSum_2024_09_22(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;

            while(fast != null && fast.next !=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode node = reverse_2024_09_22(slow.next);

            int max = 1;
            while(node != null)
            {
                max = Math.Max(node.val + head.val, max);
                node = node.next;
                head = head.next;
            }
            return max;
        }

        public ListNode reverse_2024_09_22(ListNode node)
        {
            if (node == null || node.next == null) return node;
            ListNode temp = reverse_2024_09_22(node.next);
            node.next.next = node;
            node.next = null;
            return temp;
        }
        #endregion
    }
}
