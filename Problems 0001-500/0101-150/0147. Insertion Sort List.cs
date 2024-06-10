using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0147
    {
        #region 03/27/2024
        public ListNode InsertionSortList_2024_03_27(ListNode head)
        {
            ListNode node = new ListNode(-5001);

            while(head != null)
            {
                ListNode next = head.next;

                head.next = null;

                ListNode temp = node;
                while(temp.next !=null && temp.next.val <= head.val)
                {
                    temp = temp.next;
                }

                ListNode next2 = temp.next;
                temp.next = head;
                head.next = next2;




                head = next;
            }

            return node.next;
        }
        #endregion
    }
}
