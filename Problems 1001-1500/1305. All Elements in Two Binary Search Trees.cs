using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1305
    {
        List<int> answer = new List<int>() { };

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            travel(root1);
            travel(root2);
            answer.Sort();
            return answer;
        }
        public void travel(TreeNode node)
        {
            if(node != null)
            {
                answer.Add(node.val);
                travel(node.left);
                travel(node.right);
            }
        }

        //******* Iterative*************
        public IList<int> GetAllElements_v2(TreeNode root1,TreeNode root2)
        {
            Stack<TreeNode> s1 = new Stack<TreeNode>() { };
            Stack<TreeNode> s2 = new Stack<TreeNode>() { };
            while(root1 !=null || root2 !=null || s1.Count !=0 || s2.Count != 0)
            {
                while(root1 != null)
                {
                    s1.Push(root1);
                    root1 = root1.left;
                }
                while (root2 != null)
                {
                    s2.Push(root2);
                    root2 = root2.left;
                }
                if(s2.Count !=0 || s1.Count != 0)
                {
                    if (s1.Peek().val < s2.Peek().val)
                    {
                        root1 = s1.Pop();
                        answer.Add(root1.val);
                        root1 = root1.right;
                    }
                    else
                    {
                        root2 = s2.Pop();
                        answer.Add(root2.val);
                        root2 = root2.right;
                    }
                }
                else
                {
                    if(s2.Count != 0)
                    {
                        root2 = s2.Pop();
                        answer.Add(root2.val);
                        root2 = root2.right;
                    }
                    else
                    {
                        root1 = s1.Pop();
                        answer.Add(root1.val);
                        root1 = root1.right;
                    }
                }
            }
            return answer;
        }
        ///01-02-2020-----------------
        
        public IList<int> GetAllElements_R2(TreeNode root1, TreeNode root2)
        {
            List<int> l1 = new List<int>() { };
            List<int> l2 = new List<int>() { };
            helper(root1, l1);
            helper(root2, l2);
            l1.AddRange(l2);
            l1.Sort();
            return l1;
        }
        public void helper(TreeNode node,List<int> list)
        {
            if(node != null)
            {
                helper(node.left,list);
                list.Add(node.val);
                helper(node.right, list);
            }
        }
    }
}
