using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500
{
    internal class _2300
    {
        #region 09/29/2024  Sort + binary search
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            List<int> result = new List<int>();

            for (int i = 0; i < spells.Length; i++)
            {
                result.Add(find_2024_09_29(potions, (long)spells[i], success));
            }

            return result.ToArray();

        }

        public int find_2024_09_29(int[] potions, long spell, long success)
        {
            //int n = potions.Length;
            //int l = 0;
            //int r = n - 1;

            //while(l <= r)
            //{
            //    int mid = l + (r - l) / 2;
            //    if (potions[mid]* spell >= success)
            //    {
            //        if (mid == 0) return n;
            //        if (potions[mid - 1] * spell < success) return n - mid;
            //        r = mid;
            //    }
            //    else
            //    {
            //        if (mid == n - 1) return 0;
            //        if (potions[mid + 1] * spell >= success) return n - mid-1;

            //        l = mid + 1;
            //    }
            //}


            int n = potions.Length;
            int l = 0;
            int r = n - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (potions[mid] * spell >= success)
                {

                    r = mid - 1;
                }
                else
                {


                    l = mid + 1;
                }
            }

            return n - l;


        }
        #endregion
    }
}
