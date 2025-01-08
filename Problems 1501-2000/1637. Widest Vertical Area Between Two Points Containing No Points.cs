using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given n points on a 2D plane where points[i] = [xi, yi], Return the widest vertical area between two points such that no points are inside the area.

A vertical area is an area of fixed-width extending infinitely along the y-axis (i.e., infinite height). The widest vertical area is the one with the maximum width.

Note that points on the edge of a vertical area are not considered included in the area.

 

Example 1:

​
Input: points = [[8,7],[9,9],[7,4],[9,7]]
Output: 1
Explanation: Both the red and the blue area are optimal.
Example 2:

Input: points = [[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]
Output: 3
 */
#endregion

namespace leetcode.Problems_1501_2000._1601_1650
{
    internal class _1637
    {
        #region 10/17/2023
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (x, y) => { return x[0] - y[0]; });


            int max = int.MinValue;
            for(int i =1; i < points.Length; i++)
            {
                max = Math.Max(max, points[i][0] - points[i - 1][0]);
            }
            return max;
        }
        #endregion
    }
}
