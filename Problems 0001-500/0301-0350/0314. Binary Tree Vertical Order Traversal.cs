using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0314
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            int pos = 0;
            SortedDictionary<int, SortedDictionary<int, List<int>>> dic = new SortedDictionary<int, SortedDictionary<int, List<int>>>() { };
            List<int[]> result = new List<int[]>() { };
            travel(root, 0, 0, dic);

            foreach (var (key, val) in dic)
            {
                List<int> li = new List<int>() { };
                foreach (var (key2, val2) in val)
                {
                    li.AddRange(val2);
                }
                result.Add(li.ToArray());
            }
            return result.ToArray();
        }

        public void travel(TreeNode root, int pos, int level, SortedDictionary<int, SortedDictionary<int, List<int>>> dic)
        {
            if (root != null)
            {
                //right;
                if (dic.ContainsKey(pos))
                {
                    if (!dic[pos].ContainsKey(level))
                    {
                        dic[pos].Add(level, new List<int>() { root.val });
                    }
                    else
                    {
                        dic[pos][level].Add(root.val);
                    }
                }
                else
                {
                    var temp = new SortedDictionary<int, List<int>>() { };
                    temp.Add(level, new List<int>() { root.val });
                    dic.Add(pos, temp);
                }
                travel(root.left, pos - 1, level + 1, dic);
                travel(root.right, pos + 1, level + 1, dic);
            }
        }
    }
}
