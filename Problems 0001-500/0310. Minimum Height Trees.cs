using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0310
    {
        #region 07/23/2024  leaves at most 2
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            List<int> leaves = new List<int>();

            if (n < 2)
            {
               for(int i =0; i < n; i++)
                {
                    leaves.Add(i);
                }
                return leaves;
            }

            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            foreach (var item in edges)
            {
                int node1 = item[0];
                int node2 = item[1];
                if (dic.ContainsKey(node1))
                {
                    dic[node1].Add(node2);
                }
                else
                {
                    dic.Add(node1, new List<int>() { node2});
                }
                if (dic.ContainsKey(node2))
                {
                    dic[node2].Add(node1);
                }
                else
                {
                    dic.Add(node2,new List<int>() { node1 });
                }
            }

            int totalCount = n;
            foreach (var key in dic.Keys)
            {
                if (dic[key].Count == 1)
                {
                    leaves.Add(key);
                }
            }

            while (totalCount > 2)
            {
                totalCount -= leaves.Count;
                List<int> newLeavse = new List<int>() { };

                foreach (var item in leaves)
                {
                    if (dic.ContainsKey(item))
                    {
                        int node = dic[item][0];
                        dic[node].Remove(item);
                        if (dic[node].Count == 1)
                        {
                            newLeavse.Add(node);
                        }
                    }
                }
                leaves = newLeavse;
            }

            return leaves;
        }
        #endregion

    }
}
