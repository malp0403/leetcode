using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0223
    {
        #region LeetCode
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            int area1 = (ay2 - ay1) * (ax2 - ax1);
            int area2 = (by2 - by1) * (bx2 - bx1);

            //x overlap
            int left = Math.Max(ax1, bx1);
            int right = Math.Min(ax2, bx2);
            int xOverap = right - left;

            //y overlap
            int bottom = Math.Max(ay1, by1);
            int top = Math.Min(ay2, by2);
            int yOverlap = top - bottom;

            int overlapArea = 0;
            if(xOverap > 0 && yOverlap>0) {
                overlapArea = xOverap * yOverlap;
            }

            return area1 + area2 - overlapArea;
        }
        #endregion
    }
}
