using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0835
    {
        #region 09/18/2023  Approach 2: Linear Transformation
        public int LargestOverlap_20230918(int[][] img1, int[][] img2)
        {
            var list1 = findOnePair(img1);
            var list2 = findOnePair(img2);

            Dictionary<(int r, int c), int> dic = new Dictionary<(int r, int c), int>() { };
            int max = 0;
            for(int i =0; i < list1.Count; i++)
            {
                for(int j=0;j < list2.Count; j++)
                {
                    (int r, int c) pair = (list1[i].r - list2[j].r, list1[i].c - list2[i].c);
                    if (dic.ContainsKey(pair))
                    {
                        dic[pair]++;
                    }
                    else
                    {
                        dic.Add(pair, 1);
                    }
                    max = Math.Max(max, dic[pair]);
                }


            }
            return max;
        }

        public List<(int r,int c)> findOnePair(int[][] img)
        {
            List<(int r,int c)> list = new List<(int r,int c)> ();

            for(int i =0; i < img.Length; i++)
            {
                for(int j=0; j < img.Length; j++)
                {
                    if (img[i][j] == 1)
                    {
                        list.Add((i, j));
                    }
                }
            }
            return list;
        }
        #endregion
    }
}
