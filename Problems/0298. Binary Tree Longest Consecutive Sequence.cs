using System;
using System.Collections.Generic;
using System.Text;
//test
//TreeNode n1 = new TreeNode(1);
//TreeNode n2 = new TreeNode(2);
//TreeNode n3 = new TreeNode(3);
//TreeNode n4 = new TreeNode(4);
//TreeNode n5 = new TreeNode(5);
//n1.right = n3;
//            n3.left = n2;
//            n3.right = n4;
//            n4.right = n5;
namespace leetcode.Problems
{
    class _0298
    {
        HashSet<TreeNode> visited = new HashSet<TreeNode>() { };
        Queue<TreeNode> q;
        TreeNode result;
        int max=0;
        public int LongestConsecutive(TreeNode root)
        {
            result = root;
            search(root);
            return max;
        }

        public void search(TreeNode n)
        {
            if (n != null)
            {
                var temp = n;
                q = new Queue<TreeNode>() { };
                q.Enqueue(temp);
                while (!visited.Contains(temp) && ((temp.left !=null && temp.val- temp.left.val ==-1) || (temp.right != null && temp.val - temp.right.val == -1)) ) 
                {
                    visited.Add(temp);
                    if (temp.left != null && temp.val - temp.left.val == -1)
                    {
                        temp = temp.left;
                        q.Enqueue(temp);
                    }
                    else if(temp.right != null && temp.val - temp.right.val == -1)
                    {
                        temp = temp.right;
                        q.Enqueue(temp);
                    }
                    else
                    {
                        break;
                    }            
                }
                if (q.Count >0)
                {
                    if(q.Count > max)
                    {
                        max = q.Count;
                        result = q.Dequeue();
                        
                    }
                }

                search(n.left);
                search(n.right);           
            }
        }
    }
}
