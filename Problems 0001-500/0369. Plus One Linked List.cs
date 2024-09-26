using leetcode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0369
    {
        #region Approach 1: Sentinel Head + Textbook Addition.
        public ListNode PlusOne_app1(ListNode head)
        {
            ListNode Senti = new ListNode(0);
            Senti.next = head;
            ListNode temp = Senti;

            while(head != null)
            {
                if(head.val != 9)
                {
                    temp = head;
                }

                head = head.next;

            }
            temp.val++;
            temp = temp.next;

            while(temp != null)
            {
                temp.val = 0;
                temp = temp.next;
            }

            return Senti.val != 0 ? Senti : Senti.next;
        }

        #region 09/01/2024

        #endregion


    }
    #endregion

}
