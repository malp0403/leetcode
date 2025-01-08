using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 11/29/2023
/*
 Given the coordinates of four points in 2D space p1, p2, p3 and p4, return true if the four points construct a square.

The coordinate of a point pi is represented as [xi, yi]. The input is not given in any order.

A valid square has four equal sides with positive length and four equal angles (90-degree angles).

 

Example 1:

Input: p1 = [0,0], p2 = [1,1], p3 = [1,0], p4 = [0,1]
Output: true
Example 2:

Input: p1 = [0,0], p2 = [1,1], p3 = [1,0], p4 = [0,12]
Output: false
Example 3:

Input: p1 = [1,0], p2 = [-1,0], p3 = [0,1], p4 = [0,-1]
Output: true
 

Constraints:

p1.length == p2.length == p3.length == p4.length == 2
-104 <= xi, yi <= 104
 */
#endregion

namespace leetcode.Problems_0501_1000._0551_0600
{
    internal class _0593
    {
        #region 11/29/2023
        Dictionary<double, int> dic;
        bool isVisited = false;
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            dic = new Dictionary<double, int>();
            helper(p1, p2);
            helper(p1, p3);
            helper(p1, p4);
            helper(p2, p3);
            helper(p2, p4);
            helper(p3, p4);
            if (dic.Keys.Count != 2) return false;
            if (isVisited) return false;
            return true;
        }
        public void helper(int[] p1, int[] p2)
        {
            if (p1[0] == p2[0] && p1[1]== p2[1])
            {
                isVisited = true;
            }
            double dis = Math.Sqrt(Math.Pow(p1[0] - p2[0], 2) + Math.Pow(p1[1] - p2[1], 2));
            if (dic.ContainsKey(dis))
            {
                dic[dis]++;
            }
            else
            {
                dic.Add(dis, 1);
            }
            
        }
        #endregion
    }
}
