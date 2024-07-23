using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#region Test Case
/*
             var x = double.MaxValue;
            Console.Write(x.ToString().Length);

            var obj = new _0305();
            int[][] m = new int[4][];
            m[0] = new int[2] { 0,0};
            m[1] = new int[2] { 0,1};
            m[2] = new int[2] { 1,2};
            m[3] = new int[2] { 2,1};
            obj.NumIslands2(3,3,m);
 */
#endregion

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0305
    {
        #region 07/22/2024 TLE
        Dictionary<int, HashSet<(int x, int y)>> dic;
        int[][] _positions;
        int m = 0;
        int n = 0;
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            this.m = m;
            this.n = n;
            dic = new Dictionary<int, HashSet<(int x, int y)>>();
            _positions = positions;
            int key = 0;
            IList<int> answer = new List<int>();
            foreach (var item in positions)
            {
                helper(item[0], item[1], key);
                answer.Add(dic.Keys.Count);
                key++;
            }

            return answer;
        }
        public void helper(int x, int y, int curKey)
        {
            List<int> list = new List<int>() { };
            List<List<int>> dirs = new List<List<int>>()
            {
                new List<int>(){1,0},
                new List<int>(){-1,0},
                new List<int>(){0,1},
                new List<int>(){0,-1},
                new List<int>(){0,0}
            };
            List<(int x, int y)> neis = new List<(int x, int y)>();
            foreach (var item in dirs)
            {
                int r = item[0] + x;
                int c = item[1] + y;
                if (r < 0 || r >= m || c < 0 || c >= n) continue;
                neis.Add((r, c));
            }

            foreach (var key in dic.Keys)
            {
                bool isFound = false;
                foreach (var item1 in neis)
                {
                    if (dic[key].Contains(item1))
                    {
                        isFound = true;
                        break;
                    };
                }
                if (isFound)
                {
                    list.Add(key);
                }
            }

            if (list.Count == 1) return;


            dic.Add(curKey, new HashSet<(int x, int y)>() { (x, y) });
            if (list.Count == 0)
            {
                return;
            }

            foreach (var item in list)
            {
                foreach (var item2 in dic[item])
                {
                    dic[curKey].Add(item2);
                }
                dic.Remove(item);
            }


        }
        #endregion 
    }
}
