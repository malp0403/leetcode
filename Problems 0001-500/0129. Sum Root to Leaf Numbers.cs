using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace leetcode.Problems
{
    class _0129
    {
        #region LeetCode Approach 1: Iterative Preorder Traversal.

        #endregion

        #region LeetCode Approach 2: Recursive Preorder Traversal.

        #endregion

        #region LeetCode Approach 3: Morris Preorder Traversal.

        #endregion

        #region Solution1
        List<string> list;
        List<string> arr;
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;

            list = new List<string>() { };
            arr = new List<string>() { };
            helper(root);
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += Int32.Parse(list[i]);
            }
            return sum;
        }
        public void helper(TreeNode n)
        {
            if (n != null)
            {
                arr.Add(n.val.ToString());
                if (n.right == null && n.left == null)
                {
                    list.Add(String.Join("", arr.ToArray()));
                }

                helper(n.right);
                helper(n.left);
                arr.RemoveAt(arr.Count - 1);
            }
        }
        #endregion

        #region Solution2
        //****************Solution 2********************
        int sum = 0;
        public int SumNumbers_v2(TreeNode root)
        {
            if (root == null) return 0;

            helper_v2(root, 0);

            return sum;
        }
        public void helper_v2(TreeNode n, int number)
        {
            if (n != null)
            {
                number = number * 10 + n.val;
                if (n.right == null && n.left == null)
                {
                    sum += number;
                }

                helper_v2(n.right, number);
                helper_v2(n.left, number);
                number = number / 10;
            }
        }
        #endregion

        #region 01/17/2022
        //01-17-2022----------------------------------
        public int SumNumbers_R2(TreeNode root)
        {
            helper_R2(root, 0);
            return sum;
        }
        public void helper_R2(TreeNode node, int currSum)
        {
            if (node != null)
            {
                int temp = currSum * 10 + node.val;
                if (node.left == null && node.right == null)
                {
                    sum += temp;
                }
                else
                {
                    helper_R2(node.left, temp);
                    helper_R2(node.right, temp);
                }
            }
        }
        #endregion

        #region 01/17/2022 Iterative
        // 01-17-2022---------------------------
        public int SumNumbers_R2_Iterative(TreeNode root)
        {
            if (root == null) return 0;
            Queue<(TreeNode n, int sum)> q = new Queue<(TreeNode n, int sum)>() { };
            q.Enqueue((root, 0));
            int sum = 0;
            while (q.Count != 0)
            {
                int size = q.Count;
                while (size > 0)
                {
                    var temp = q.Dequeue();
                    int tempSum = temp.sum * 10 + temp.n.val;
                    if (temp.n.left == null && temp.n.right == null)
                    {
                        sum += tempSum;
                    }
                    else if (temp.n.left != null)
                    {
                        q.Enqueue((temp.n.left, tempSum));
                    }
                    else if (temp.n.right != null)
                    {
                        q.Enqueue((temp.n.right, tempSum));

                    }
                    size--;
                }
            }
            return sum;
        }
        #endregion 01/17/2022 Morris

        #region 01/17/2022
        //01-17-2022------------------------------
        public int SumNumbers_R2_Morris(TreeNode root)
        {
            int currSum = 0;
            int ans = 0;
            int steps;
            TreeNode pre;
            while (root != null)
            {
                if (root.left != null)
                {
                    pre = root.left;
                    steps = 1;
                    while (pre.right != null && pre.right != root)
                    {
                        pre = pre.right;
                        steps++;
                    }
                    if (pre.right == null)
                    {
                        currSum = (currSum * 10 + root.val);
                        pre.right = root;
                        root = root.left;
                    }
                    else
                    {
                        if (pre.left == null)
                        {
                            ans += currSum;
                        }
                        pre.right = null;
                        for (int i = 0; i < steps; i++)
                        {
                            currSum /= 10;
                        }

                        root = root.right;
                    }
                }
                else
                {
                    currSum = (currSum * 10 + root.val);
                    if (root.right == null)
                    {
                        ans += currSum;
                    }
                    root = root.right;
                }
            }
            return ans;
        }
        #endregion

        #region 08/17/2022
        int sum_20220817 = 0;
        public int SumNumbers_20220817(TreeNode root)
        {
            helper_20220817(root, 0);
            return sum_20220817;
        }
        public void helper_20220817(TreeNode node, int curSum)
        {
            if (node == null) return;
            if (node.left == null && node.right == null)
            {
                sum_20220817 += curSum * 10 + node.val;
                return;
            }
            curSum = curSum * 10 + node.val;
            helper_20220817(node.left, curSum);
            helper_20220817(node.right, curSum);

        }
        public int SumNumbers_20220817_v2(TreeNode root)
        {
            int sum = 0;
            int step = 1;
            int curSum = 0;
            while (root != null)
            {
                if (root.left != null)
                {
                    TreeNode pre = root.left;
                    while (pre.right != null && pre.right != root)
                    {
                        pre = pre.right;
                        step++;
                    }
                    if (pre.right == null)
                    {
                        curSum = curSum * 10 + root.val;
                        pre.right = root;
                        root = root.left;
                    }
                    else
                    {
                        if (pre.left == null)
                        {
                            sum += curSum;
                        }
                        for (int i = 0; i < step; i++)
                        {
                            curSum /= 10;
                        }
                        pre.right = null;
                        root = root.right;
                    }
                }
                else
                {
                    curSum = curSum * 10 + root.val;
                    if (root.right == null)
                    {
                        sum += curSum;
                    }
                    root = root.right;
                }
            }
            return sum;



        }

        #endregion

        #region 03/25/2024
        public int SumNumbers_03_25_2024(TreeNode root)
        {
            Queue<(TreeNode node, int cur)> q = new Queue<(TreeNode node, int cur)>();

            if (root == null) return 0;
            q.Enqueue((root, 0));
            int answer = 0;
            while (q.Count > 0)
            {
                var element = q.Dequeue();
                int val = element.cur * 10 + element.node.val;

                if (element.node.left == null && element.node.right == null)
                {
                    answer += val;
                }
                else
                {
                    if (element.node.left != null)
                    {
                        q.Enqueue((element.node.left, val));
                    }
                    if (element.node.right != null)
                    {
                        q.Enqueue((element.node.right, val));
                    }
                }
            }
            return answer;
        }
        #endregion

        #region 10/07/2024
        public int SumNumbers_2024_10_07(TreeNode root)
        {
            int sum = 0;
            Queue<(int cur, TreeNode node)> q = new Queue<(int cur, TreeNode node)>();
            if (root == null) return 0;
            q.Enqueue((root.val, root));
            while (q.Count > 0)
            {
                var ele = q.Dequeue();
                if (ele.node.right == null && ele.node.left == null)
                {
                    sum += ele.cur;
                }
                if (ele.node.left != null)
                {
                    q.Enqueue((ele.cur * 10 + ele.node.left.val, ele.node.left));
                }
                if (ele.node.right != null)
                {
                    q.Enqueue((ele.cur * 10 + ele.node.right.val, ele.node.right));

                }

            }

            return sum;
        }
        #endregion











    }
}
