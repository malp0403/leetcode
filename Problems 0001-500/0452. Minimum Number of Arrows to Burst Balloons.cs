using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 There are some spherical balloons taped onto a flat wall that represents the XY-plane. The balloons are represented as a 2D integer array points where points[i] = [xstart, xend] denotes a balloon whose horizontal diameter stretches between xstart and xend. You do not know the exact y-coordinates of the balloons.

Arrows can be shot up directly vertically (in the positive y-direction) from different points along the x-axis. A balloon with xstart and xend is burst by an arrow shot at x if xstart <= x <= xend. There is no limit to the number of arrows that can be shot. A shot arrow keeps traveling up infinitely, bursting any balloons in its path.

Given the array points, return the minimum number of arrows that must be shot to burst all balloons.

 

Example 1:

Input: points = [[10,16],[2,8],[1,6],[7,12]]
Output: 2
Explanation: The balloons can be burst by 2 arrows:
- Shoot an arrow at x = 6, bursting the balloons [2,8] and [1,6].
- Shoot an arrow at x = 11, bursting the balloons [10,16] and [7,12].
Example 2:

Input: points = [[1,2],[3,4],[5,6],[7,8]]
Output: 4
Explanation: One arrow needs to be shot for each balloon for a total of 4 arrows.
Example 3:

Input: points = [[1,2],[2,3],[3,4],[4,5]]
Output: 2
Explanation: The balloons can be burst by 2 arrows:
- Shoot an arrow at x = 2, bursting the balloons [1,2] and [2,3].
- Shoot an arrow at x = 4, bursting the balloons [3,4] and [4,5].
 

Constraints:

1 <= points.length <= 105
points[i].length == 2
-231 <= xstart < xend <= 231 - 1
 */
#endregion

#region Test
/*
             int s = int.MinValue; int v = int.MaxValue;
            var obj = new _0452();
            obj.FindMinArrowShots(new int[][]
            {
                            new int[2]{9,12},
                             new int[2]{1,10},
                            new int[2]{4,11},
                            new int[2]{8,12},
                            new int[2]{3,9},
                            new int[2]{6,9},
                            new int[2]{6,7}
            });


            obj.FindMinArrowShots(new int[][]
            {
                            new int[2]{-2147483646,-2147483645},
                             new int[2]{2147483646,2147483647}
            });
            obj.FindMinArrowShots(new int[][]
            {
                new int[2]{10,16},
                 new int[2]{2,8},
                new int[2]{1,6},
                new int[2]{7,12}
            });
 */
#endregion
namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0452
    {
        #region 11/25/2023 order by 1st then 2rd, 
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 1) return 1;
            points = points.OrderBy(row => row[0]).ThenBy(row => row[1]).ToArray();


            int count = 1;
            int max = int.MinValue;
            for(int i =0; i < points.Length; i++)
            {
               if(max == int.MinValue)
                {
                    max = points[i][1];
                }
                else
                {
                    if (points[i][0] > max)
                    {
                        count++;
                        max = points[i][1];
                    }
                    else
                    {
                        max = Math.Min(max, points[i][1]);
                    }
                }
            }

            return count;
        }
        #endregion
    }
}
