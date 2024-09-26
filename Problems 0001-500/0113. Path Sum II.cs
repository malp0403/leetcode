using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0113
    {
        #region answer
        IList<IList<int>> result = new List<IList<int>>() { };
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<TreeNode> path = new List<TreeNode>() { };
            travel(root, 0, targetSum, path);


            return result;
        }
        public void travel(TreeNode n, int sum, int target, List<TreeNode> l)
        {
            if (n != null)
            {
                l.Add(n);
                sum += n.val;
                //check if it is the leaf;
                if (n.right == null && n.left == null)
                {
                    if (sum == target)
                    {
                        var copy = l.Select(x => x.val).ToList();
                        result.Add(copy);
                    }
                }
                travel(n.right, sum, target, l);
                travel(n.left, sum, target, l);

                l.RemoveAt(l.Count - 1);
                sum -= n.val;
            }
        }
        #endregion

        #region 08/16/2022
        IList<IList<int>> answer = new List<IList<int>>() { };
        public IList<IList<int>> PathSum_20220816(TreeNode root, int targetSum)
        {
            if (root == null) return answer;
            helper_20220816(root, targetSum, 0, new List<int>() { });
            return answer;
        }
        public void helper_20220816(TreeNode node, int targetSum, int cur,IList<int> list)
        {
            if (node == null) return;
            list.Add(node.val);
            if(cur+node.val == (targetSum))
            {
                if(node.left == null && node.right == null)
                {
                    answer.Add(list.Select(x => x).ToList());
                }
              
            }
            helper_20220816(node.left, targetSum, cur + node.val, list);
            helper_20220816(node.right, targetSum, cur + node.val, list);
            list.RemoveAt(list.Count - 1);
        }
        #endregion

        #region 03/22/2024
        IList<IList<int>> res_2024_03_22 ;
        public IList<IList<int>> PathSum_2024_03_24(TreeNode root, int targetSum)
        {
            res_2024_03_22 = new List<IList<int>>() { };
            helper_2024_03_22(root,targetSum,new List<int> { });

            return res_2024_03_22;

        }
        public void helper_2024_03_22(TreeNode node, int targetSum, List<int> list)
        {
            if (node == null) return;
            if(node.val == (targetSum) && node.left == null && node.right== null) {
                res_2024_03_22.Add(new List<int>(list));
                return;
            }

            list.Add(node.val);
            helper_2024_03_22(node.left, targetSum - node.val, list);
            helper_2024_03_22(node.right, targetSum - node.val, list);
            list.RemoveAt((int)list.Count - 1);
        }
        #endregion

    }
}
