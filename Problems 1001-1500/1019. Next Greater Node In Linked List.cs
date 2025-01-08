using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You are given the head of a linked list with n nodes.

For each node in the list, find the value of the next greater node. That is, for each node, find the value of the first node that is next to it and has a strictly larger value than it.

Return an integer array answer where answer[i] is the value of the next greater node of the ith node (1-indexed). If the ith node does not have a next greater node, set answer[i] = 0.

 

Example 1:


Input: head = [2,1,5]
Output: [5,5,0]
Example 2:


Input: head = [2,7,4,3,5]
Output: [7,0,5,5,0]
 

Constraints:

The number of nodes in the list is n.
1 <= n <= 104
1 <= Node.val <= 109
 */
#endregion

namespace leetcode.Problems_1001_1500._1001_1050
{
    internal class _1019
    {
        #region MyRegion
        public int[] NextLargerNodes_20231112(ListNode head) // use Index to records 
        {
            List<int> list = Enumerable.Repeat(-1, 10000).ToList();

            Stack<(int index, int value)> stack = new Stack<(int index, int value)>();
            int index = 0;

            while (head != null)
            {


                while (stack.Count > 0 && head.val > stack.Peek().value)
                {
                    var ele = stack.Pop();
                    list[ele.index] = head.val;
                }

                stack.Push((index, head.val));

                index++;
                head = head.next;
            }

            while (stack.Count > 0)
            {
                var ele = stack.Pop();
                list[ele.index] = 0;
            }

            list = list.Where(x => x != -1).ToList();

            return list.ToArray();
            #endregion
        }
    }
}
