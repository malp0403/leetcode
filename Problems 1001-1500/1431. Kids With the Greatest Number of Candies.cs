using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1001_1500._1451_1500
{
    internal class _1431
    {
        #region MyRegion
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            foreach (var item in candies)
            {
                max = Math.Max(item,max);
            }
            IList<bool> res= new List<bool>();

            foreach (var item in candies)
            {
                bool temp = (item + extraCandies) >= max ? true : false;
                res.Add(temp);
            }

            return res;
        }
        #endregion
    }
}
