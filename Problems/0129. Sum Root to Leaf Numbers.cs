using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0129
    {
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
                        if(pre.left == null)
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
    }
}
