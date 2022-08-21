using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    /// <test>
    ///            
    // TreeNode n4 = new TreeNode(4);
    //TreeNode n1 = new TreeNode(1);
    //TreeNode n6 = new TreeNode(6);
    //TreeNode n0 = new TreeNode(0);
    //TreeNode n2 = new TreeNode(2);
    //TreeNode n5 = new TreeNode(5);
    //TreeNode n7 = new TreeNode(7);
    //TreeNode n8 = new TreeNode(8);

    //n4.left = n1;
    //        n4.right = n6;
    //        n1.left = n0;
    //        n1.right = n2;
    //        n6.left = n5;
    //        n6.right = n7;
    //        n7.right = n8;
    /// </summary>
    class _1038
    {
        public TreeNode BstToGst(TreeNode root)
        {
            int sum = 0;
            TreeNode node = root;
            while (node != null)
            {
                if (node.right == null)
                {
                    sum += node.val;
                    node.val = sum;
                    node = node.left;
                }
                else
                {
                    var suc = getSussor(node);
                    if(suc.left == null)
                    {
                        suc.left = node;
                        node = node.right;
                    }
                    else
                    {
                        suc.left = null;
                        sum += node.val;
                        node.val = sum;
                        node = node.left;
                    }
                }
            }

            return root;

        }
        public TreeNode getSussor(TreeNode node)
        {
            var suc = node.right;
            while (suc.left != null && suc.left != node)
            {
                suc = suc.left;
            }
            return suc;
        }

        // ******** stack and recalculate********
        Stack<TreeNode> stack;
        public TreeNode BstToGst_V2(TreeNode root)
        {
            stack = new Stack<TreeNode>() { };
            dsf_helper(root);
            int sum = 0;
            while (stack.Count != 0)
            {
                var n = stack.Pop();
                sum += n.val;
                n.val = sum;
            }
            return root;
        }
        public void dsf_helper(TreeNode root)
        {
            if (root != null)
            {
                dsf_helper(root.left);
                stack.Push(root);
                dsf_helper(root.right);
            }
        }


        public TreeNode BstToGst2(TreeNode root)
        {
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            TreeNode node = root;
            while(stack.Count !=0 || node != null)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.right;
                }

                node = stack.Pop();
                sum += node.val;
                node.val = sum;

                node = node.left;
            }
            return root;
        }


        //01-01-2022-----------------
        public TreeNode BstToGst_R2(TreeNode root)
        {
            int sum = 0;
            TreeNode curr = root;
            while(curr != null)
            {
                if(curr.right == null)
                {
                    sum += curr.val;
                    curr.val = sum;
                    curr = curr.left;
                }
                else
                {
                    var succsor = helper(curr);
                    if(succsor.left == null)
                    {
                        succsor.left = curr;
                        curr = curr.right;
                    }
                    else
                    {
                        succsor.left = null;

                        sum += curr.val;
                        curr.val = sum;

                        curr = curr.left;
                    }
                }
            }
            return curr;
        }
        public TreeNode helper(TreeNode n)
        {
            var temp = n.right;
            while(temp.left != null && temp.left != n)
            {
                temp = temp.left;
            }
            return temp;
        }
    }
}
