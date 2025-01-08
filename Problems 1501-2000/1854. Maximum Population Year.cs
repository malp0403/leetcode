using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1851_1900
{
    internal class _1854
    {
        #region 10/11/2023
        public int MaximumPopulation(int[][] logs)
        {
            int[] records = Enumerable.Repeat(0, 101).ToArray();


            foreach (var item in logs)
            {
                for(int i = item[0];i < item[1]; i++)
                {
                    records[i - 1950]++;
                }
            }
            int max = 0;
            int year = 0;
            for(int i =0; i< records.Length; i++)
            {
                if (records[i] > max)
                {
                    max = records[i];
                    year = i + 1950;
                }
            }
            return year;
        }
        #endregion
    }
}
