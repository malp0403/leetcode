using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1123
    {
        Dictionary<TreeNode, TreeNode> dic;
        int deepth = -1;
        List<TreeNode> list = new List<TreeNode>() { };
        //************************new class***************
        public MyTreeNode helper(TreeNode node)
        {
            if (node == null) return new MyTreeNode(0, null);
            MyTreeNode left = helper(node.left);
            MyTreeNode right = helper(node.right);
            int height = Math.Max(left.height, right.height) + 1;
            TreeNode lca = left.height == right.height ? node : (left.height < right.height ? right.lca : left.lca);
            return new MyTreeNode(height, lca);
        }
        public class MyTreeNode
        {
            public int height;
            public TreeNode lca;
            public MyTreeNode(int height, TreeNode lca)
            {
                this.height = height;
                this.lca = lca;
            }
        }
        //*************************************************
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            dic = new Dictionary<TreeNode, TreeNode>() { };
            travel(root, 0, null);

            if (list.Count == 1)
            {
                return list.First();
            }
            else if (list.Count >= 2)
            {
                TreeNode intial = list[0];
                List<TreeNode> tracker = new List<TreeNode>() { };
                for (int i = 1; i < list.Count; i++)
                {
                    intial = getMostCommon(intial, list[i]);
                }
                return intial;

            }
            return null;
        }
        public TreeNode getMostCommon(TreeNode n1, TreeNode n2)
        {
            List<TreeNode> l = new List<TreeNode>() { };
            var temp = n1;
            while (temp != null)
            {
                l.Add(temp);
                temp = dic[temp];
            }
            var temp2 = n2;
            while (!l.Contains(temp2))
            {
                temp2 = dic[temp2];
            }
            return temp2;
        }

        public void travel(TreeNode n, int level, TreeNode parent)
        {
            if (n != null)
            {

                dic.Add(n, parent);

                //if leave
                if (n.left == null && n.right == null)
                {
                    if (level > deepth)
                    {
                        list = new List<TreeNode>() { };
                        list.Add(n);
                        deepth = level;
                    }
                    else if (level == deepth)
                    {
                        list.Add(n);
                    }
                }
                else
                {
                    travel(n.left, level + 1, n);
                    travel(n.right, level + 1, n);
                }

            }
        }

        //01-05-2022------------
        public TreeNode LcaDeepestLeaves_R2(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            dic = new Dictionary<TreeNode, TreeNode>() { };
            q.Enqueue(root);
            List<TreeNode> deepest = new List<TreeNode>() { };
            while (q.Count != 0)
            {
                int size = q.Count;
                deepest = new List<TreeNode>() { };
                while (size > 0)
                {
                    var n = q.Dequeue();
                    deepest.Add(n);
                    if (n.left != null) {
                        dic.Add(n.left, n);
                        q.Enqueue(n.left);
                    }

                    if (n.right != null) {
                        dic.Add(n.right, n);
                        q.Enqueue(n.right);
                    }
                    size--;
                }
            }
            if (deepest.Count == 1) return deepest[0];
            else
            {
                TreeNode ans = new TreeNode();
                while (true)
                {
                    Console.WriteLine(deepest.Count);
                    ans = deepest[0];

                    if (deepest.All(x => x == ans))
                    {
                        break;
                    }
                    else
                    {

                        deepest = deepest.Select(x => dic[x]).ToList();
                    }
                }
                return ans;
            }

        }



    }
}
