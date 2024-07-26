using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace leetcode.Problems
{
    class _0314
    {
        #region Solution

       
        public IList<IList<int>> VerticalOrder_(TreeNode root)
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
        #endregion

        #region 07/23/2024 
        SortedDictionary<int, List<int>> dic_2024_07_22;
        public IList<IList<int>> VerticalOrder_2024_07_22(TreeNode root)
        {
            dic_2024_07_22 = new SortedDictionary<int, List<int>>();
            IList<IList<int>> ans = new List<IList<int>>();

            Queue<(TreeNode node, int level)> queue = new Queue<(TreeNode node, int level)>();
            if (root == null) return ans;

            queue.Enqueue((root, 0));
            while(queue.Count != 0)
            {

                int n = queue.Count;
                while(n > 0)
                {
                    var ele = queue.Dequeue();
                    if (dic_2024_07_22.ContainsKey(ele.level))
                    {
                        dic_2024_07_22[ele.level].Add(ele.node.val);
                    }
                    else
                    {
                        dic_2024_07_22.Add(ele.level, new List<int>() { ele.node.val });
                    }

                    if(ele.node.left != null)
                    {
                        queue.Enqueue((ele.node.left, ele.level - 1));
                    }
                    if (ele.node.right != null)
                    {
                        queue.Enqueue((ele.node.right, ele.level + 1));
                    }

                    n--;
                }

            }

            foreach (var item in dic_2024_07_22.Keys)
            {
                ans.Add(dic_2024_07_22[item]);
            }
            return ans;
        }
        #endregion
    }
}
