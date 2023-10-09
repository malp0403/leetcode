using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0836
    {
        #region 09/18/2023 TLE
        public bool IsRectangleOverlap_20230918_brutalForce(int[] rec1, int[] rec2)
        {
            for (int i = rec1[0]; i <= rec1[2]; i++)
            {
                for (int j = rec1[1]; j <= rec1[3]; j++)
                {
                    if (i > rec2[0] && j > rec2[1] && i < rec2[2] && j < rec2[3])
                    {
                        return true;
                    }
                }
            }
            return false;


        }
        #endregion

        #region 09/18/2023 TLE
        //public bool IsRectangleOverlap_20230918(int[] rec1, int[] rec2)
        //{
        //    int xbottom1 = rec1[0];
        //    int ybottom1 = rec1[1];
        //    int xTop1 = rec1[2];
        //    int yTop1 = rec1[3];

        //    int xbottom2 = rec2[0];
        //    int ybottom2 = rec2[1];
        //    int xTop2 = rec2[2];
        //    int yTop2 = rec2[3];



        //}
        #endregion
    }
}
