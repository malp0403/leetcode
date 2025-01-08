using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1701_1750
{
    internal class _1710
    {
        #region 10/17/2023
        public int MaximumUnits_20231017(int[][] boxTypes,int truckSize)
        {

            Array.Sort(boxTypes, (a, b) => { return b[1] - a[1]; });
            int sum = 0;
            for(int i=0; i < boxTypes.Length; i++)
            {


                if (truckSize == 0) break;

                int boxCount= Math.Min(truckSize, boxTypes[i][0]);
                sum += boxCount * boxTypes[i][1];
                truckSize -= boxCount;

            }
            return sum;

        }
        #endregion
    }
}
