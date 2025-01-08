using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2151_2200
{
    internal class _2181
    {
        #region 10/08/2023
       public ListNode MergeNodes(ListNode head)
        {
            ListNode answer = new ListNode();
            ListNode temp = answer;
            while(head != null)
            {
                if(head.val == 0)
                {
                    head = head.next;
                }
                else
                {
                    ListNode start = new ListNode(0);
                    while(head.val != 0)
                    {
                        start.val += head.val;
                        head = head.next;
                    }
                    temp.next = start;
                    temp = temp.next;
                }
            }
            return answer.next;
        }
        #endregion
    }
}
