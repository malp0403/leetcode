using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_1501_2000._1551_1600
{
    internal class _1584
    {
        int distance = int.MaxValue; 
        public int MinCostConnectPoints(int[][] points)
        {
            int result = 0;
            int min = int.MaxValue;
            for(int i =0; i < points.Length; i++)
            {
                int temp = int.MaxValue;
                for(int j =0;j < points.Length; j++)
                {
                    if(i != j)
                    {
                        int d = Math.Abs(points[j][0]- points[i][0]) + Math.Abs(points[j][1]- points[i][1]);
                        if (d < temp)
                        {
                            temp = d;
                        }
                    }

                }
                if(temp < min)
                {
                    min = temp;
                }
                result = temp;
            }

            return result - min;

        }
        public void helper(int[][] points, HashSet<int> seen, int cur,int prevIndex)
        {


        }
    }
}
