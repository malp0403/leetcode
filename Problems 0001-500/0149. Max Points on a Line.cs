using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0101_150
{
    internal class _0149
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length == 1) return 1;

            HashSet<(double, double, bool, bool, int, int)> set = new HashSet<(double, double, bool, bool, int, int)>();

            int max = 2;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var key = getLine(points[i][0], points[i][1], points[j][0], points[j][1]);
                    if (set.Contains(key))
                    {
                        continue;
                    }
                    else
                    {
                        int temp = 2;
                        for (int z = j + 1; z < points.Length; z++)
                        { 
                            if (key.isX)
                            {
                                temp += key.x == points[z][0] ? 1 : 0;
                            }
                            else if (key.isY)
                            {
                                temp += key.y == points[z][1] ? 1 : 0;
                            }
                            else if (getLine(points[i][0], points[i][1], points[z][0], points[z][1]) == key)
                            {
                                temp++;
                            }
                        }

                        max = Math.Max(max, temp);
                    }
                }
            }

            return max;

        }


        public (double k, double c, bool isX, bool isY, int x, int y) getLine(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                return (0, 0, true, false, x1, 0);
            }
            else if (y1 == y2)
            {
                return (0, 0, false, true, 0, y1);
            }

            double k_ = (double)(y2 - y1) / (x2 - x1);
            return (k_, y1 - k_ * x1, false, false, 0, 0);
        }
    }
}
