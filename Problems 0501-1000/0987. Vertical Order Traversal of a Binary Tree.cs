using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0987
    {
        #region Solution
        Dictionary<(int row, int col), List<int>> dic = new Dictionary<(int row, int col), List<int>>() { };
        public IList<IList<int>> VerticalTraversal_s(TreeNode root)
        {
            SortedDictionary<int, SortedDictionary<int, List<int>>> temp = new SortedDictionary<int, SortedDictionary<int, List<int>>>() { };
            search(root, 0, 0);
            foreach (var (key, val) in dic)
            {
                val.Sort();
                if (temp.ContainsKey(key.col))
                {
                    if (temp[key.col].ContainsKey(key.row)) temp[key.col][key.row].AddRange(val);
                    else temp[key.col].Add((key.row), val);
                }
                else
                {
                    var temp2 = new SortedDictionary<int, List<int>>();
                    temp2.Add(key.row, val);
                    temp.Add(key.col, temp2);
                }
            }
            IList<IList<int>> result = new List<IList<int>>() { };
            foreach (var (key, val) in temp)
            {
                var li = new List<int>() { };
                foreach (var (key2, val2) in val)
                {
                    li.AddRange(val2);
                }
                result.Add(li);
            }
            return result;
        }

        public void search(TreeNode node, int row, int col)
        {
            if (node == null) return;

            if (dic.ContainsKey((row, col)))
            {
                dic[(row, col)].Add(node.val);
            }
            else
            {
                dic.Add((row, col), new List<int>() { node.val });
            }
            search(node.left, row + 1, col - 1);
            search(node.right, row + 1, col + 1);
        }
        #endregion

        #region 10/07/2024
        public IList<IList<int>> VerticalTraversal_2024_10_07(TreeNode root)
        {
            SortedDictionary<int, List<(int r, int val)>> dic = new SortedDictionary<int, List<(int r, int val)>>();
            IList<IList<int>> ans = new List<IList<int>>() { };

            if (root == null) return ans;
            Queue<(int r, int c, TreeNode node)> q = new Queue<(int r, int c, TreeNode node)>();
            q.Enqueue((0, 0, root));
            while (q.Count > 0)
            {
                var e = q.Dequeue();
                if (dic.ContainsKey((e.c)))
                {
                    dic[e.c].Add((e.r, e.node.val));
                }
                else
                {
                    dic.Add(e.c, new List<(int r, int val)>() { (e.r, e.node.val) });
                }

                if (e.node.left != null)
                {
                    q.Enqueue((e.r + 1, e.c - 1, e.node.left));
                }
                if (e.node.right != null)
                {
                    q.Enqueue((e.r + 1, e.c + 1, e.node.right));
                }
            }

            foreach (var key in dic.Keys)
            {
                dic[key].Sort((x, y) => x.r == y.r ? x.val - y.val : x.r - y.r);
                ans.Add(dic[key].Select(x=>x.val).ToList());
            }

            return ans;

        }
        #endregion



























    }
}
