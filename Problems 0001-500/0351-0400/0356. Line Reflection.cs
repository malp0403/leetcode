using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
            var obj = new _0356();

            obj.IsReflected(new int[][]
{
                new int[]{1,2},
                new int[]{2,2},
                 new int[]{1,4},
                  new int[]{2,4 }
});


            obj.IsReflected(new int[][]
{
                new int[]{0,0  },
                new int[]{1,0}
});
            obj.IsReflected(new int[][]
            {
                new int[]{1,1  },
                new int[]{-1,-1}
            });
 */
#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0356
    {
        #region 09/01/2024
        public bool IsReflected(int[][] points)
        {
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
            foreach (int[] point in points)
            {
                if (!dic.ContainsKey(point[1]))
                {
                    dic.Add(point[1], new HashSet<int>() { point[0] });
                }
                else
                {
                    dic[point[1]].Add(point[0]);
                }
            }

            double? y = null;

            foreach (int key in dic.Keys)
            {

                if (y == null)
                {

                    y = getY(dic[key].ToList());
                    if (y == null) return false;
                }
                else
                {

                    if (!validate(dic[key].ToList(), (double)y)) return false;
                }

            }
            return true;


        }

        public double? getY(List<int> list)
        {
            list.Sort();
            double? y = list.Count % 2 == 0 ? (double)(list[0] + list[list.Count - 1]) / 2 : list[list.Count / 2];

            int l = 0;
            int r = list.Count - 1;
            while (l < r)
            {
                if ((list[l] + list[r]) / 2.0 != y) return null;
                l++; r--;
            }
            return y;

        }

        public bool validate(List<int> list, double y)
        {
            list.Sort();
            int l = 0;
            int r = list.Count - 1;
            while (l <= r)
            {
                if ((double)(list[r] + list[l]) / 2 != y) return false;
                l++; r--;
            }
            return true;
        }
        #endregion
    }
}
