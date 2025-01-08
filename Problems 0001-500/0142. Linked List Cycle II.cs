using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
             var obj = new _0142() { };
            ListNode n3 = new ListNode(3);
            ListNode n2 = new ListNode(2);
            ListNode n0 = new ListNode(0);
            ListNode n_4 = new ListNode(-4);
            n3.next = n2;n2.next = n0;n0.next = n_4;n_4.next = n2;
            obj.DetectCycle(n3);
 */
#endregion

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0142
    {

        #region LeetCode Approach 1: Hash Set

        #endregion
        #region LeetCode Approach 2: Floyd's Tortoise and Hare Algorithm

        #endregion
        #region 03/26/2024
        public ListNode DetectCycle(ListNode head)
        {
            ListNode ans = new ListNode();

            ListNode fast = head;
            ListNode slow = head;
            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) break;
            }

            if (fast == null || fast.next == null) return null;

            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (!visited.Contains(fast))
            {
                visited.Add(fast);
                fast = fast.next;

            }

            while (!visited.Contains(head))
            {
                
                head = head.next;

            }

            return head;
        }
        #endregion
    }
}
