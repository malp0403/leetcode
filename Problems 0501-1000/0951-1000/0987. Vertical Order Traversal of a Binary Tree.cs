using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0987
    {
        Dictionary<(int row, int col), List<int>> dic = new Dictionary<(int row, int col), List<int>>() { };
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            SortedDictionary<int, SortedDictionary<int,List<int>>> temp = new SortedDictionary<int, SortedDictionary<int, List<int>>>() { };
            search(root, 0, 0);
            foreach (var (key, val) in dic)
            {
                val.Sort();
                if (temp.ContainsKey(key.col))
                {
                    if (temp[key.col].ContainsKey(key.row)) temp[key.col][key.row].AddRange(val);
                    else temp[key.col].Add((key.row), val);
                }
                else {
                    var temp2 = new SortedDictionary<int, List<int>>();
                    temp2.Add(key.row, val);
                    temp.Add(key.col,temp2);
                } 
            }
            IList<IList<int>> result = new List<IList<int>>() { };
            foreach (var (key, val) in temp)
            {
                var li = new List<int>() { };
                foreach(var (key2,val2) in val)
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
                dic.Add((row, col), new List<int>() { node.val});
           }
            search(node.left, row + 1, col - 1);
            search(node.right, row + 1, col + 1);
        }
    }
}
