using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0237
    {
        #region LeetCode Approach: Data Overwriting
        public void DeleteNode_a1(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        #endregion

        #region 07/07/2024
        public void DeleteNode_2024_07_07(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        #endregion
    }
}
