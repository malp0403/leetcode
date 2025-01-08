using System;
using System.Collections.Generic;
using System.Text;
//*****************test data************
//TreeNode n1 = new TreeNode(1);
//TreeNode n2 = new TreeNode(2);

//TreeNode n3 = new TreeNode(1);
//TreeNode n4 = new TreeNode(2);
//n1.left = n2;
//n3.right = n4;

//note: check left and right when Enqueuing.

namespace leetcode.Problems
{
    class _0100
    {
        #region LeetCode Approach 1: Recursion
        public bool IsSameTree_Approach1(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null || q.val != p.val) return false;

            return IsSameTree_Approach1(p.right, q.right) && IsSameTree_Approach1(p.left, q.left);
        }
        #endregion

        #region LeetCode Approach 2: Iteration

        #endregion

        #region answer
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>() { };
            Queue<TreeNode> q2 = new Queue<TreeNode>() { };
            if (!check(p, q)) return false;
            q1.Enqueue(p);
            q2.Enqueue(q);
            while(q1.Count > 0)
            {
                var temp1 = q1.Dequeue();
                var temp2 = q2.Dequeue();
                if(temp1 != null)
                {
                    if (!check(temp1.left, temp2.left)) return false;
                    if(temp1.left != null)
                    {
                        q1.Enqueue(temp1.left);
                        q2.Enqueue(temp2.left);
                    }
                    if (!check(temp1.right, temp2.right)) return false;
                    if (temp1.right != null)
                    {
                        q1.Enqueue(temp1.right);
                        q2.Enqueue(temp2.right);
                    }
                }
            }
            return true;

        }
        public bool check(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null) return true;
            if (n1 == null || n2 == null) return false;
            if (n1.val == n2.val) return true;
            return false;
        }
        #endregion
        #region 12/23/2021
        //----------------------------------12/23/2021
        public bool IsSameTree_R2(TreeNode p, TreeNode q)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode?>() { };
            Queue<TreeNode> q2 = new Queue<TreeNode?>() { };
            if (!check(p, q)) return false;
            if (p == null) return true;
            q1.Enqueue(p);
            q2.Enqueue(q);
            while (q1.Count != 0)
            {
                var n1 = q1.Dequeue();
                var n2 = q2.Dequeue();
                if (!check(n1, n2)) return false;
                if (!check(n1.left, n2.left)) return false;
                if(n1.left != null)
                {
                    q1.Enqueue(n1.left);
                    q2.Enqueue(n2.left);
                }

                if (!check(n1.right, n2.right)) return false;

                if(n1.right != null)
                {
                    q1.Enqueue(n1.right);
                    q2.Enqueue(n2.right);
                }
            }
            return true;
        }
        #endregion
        #region 08/12/2022
        public bool IsSameTree_20220812(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if ((p == null && q != null) || (p != null && q == null)) return false;
            if (p.val != q.val) return false;
            return IsSameTree_20220812(p.left, q.left) && IsSameTree_20220812(p.right, q.right);
        }
        #endregion

        #region 03/18/2024
        public bool IsSameTree_2024_03_18(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null || q.val != p.val) return false;

            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }
        #endregion
    }
}
 