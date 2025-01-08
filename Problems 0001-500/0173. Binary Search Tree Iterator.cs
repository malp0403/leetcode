using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0173
    {
        //SortedDictionary<int, TreeNode> d;
        //ListNode l = new ListNode(-1);
        //public _0173(TreeNode root)
        //{
        //    d = new SortedDictionary<int, TreeNode>() { };
        //    travel(root);
        //    ListNode r = new ListNode(-1);
        //    var copy = r;
        //    foreach (var (key,val) in d)
        //    {
        //        var temp = new ListNode(key);
        //        copy.next= temp;
        //        copy = copy.next;
        //    }

        //    l = l.next; 

        //}
        //public void travel(TreeNode node)
        //{
        //    if (node != null)
        //        d.Add(node.val, node  );
        //    travel(node.right);
        //    travel(node.left);
        //}

        //public int Next()
        //{
        //    if (l != null && this.HasNext()) {
        //        l = l.next;
        //        return l.val;
        //    } 
        //    return 0;
        //}

        //public bool HasNext()
        //{
        //    return l!= null && l.next != null;
        //}
        // 01-08-2022

        //public TreeNode curr = new TreeNode(-1);
        //public TreeNode head;
        //public _0173(TreeNode root)
        //{
        //    head = curr;
        //    inorder(root);

        //}
        //public void inorder(TreeNode node)
        //{
        //    if(node != null)
        //    {
        //        inorder(node.left);
        //        head.right = node;
        //        head = head.right;
        //        inorder(node.right);
        //    }
        //}

        //public int Next()
        //{
        //    if (curr == null) return 0;
        //    TreeNode ans = curr.right;
        //    curr = curr.right;
        //    return ans.val;
        //}

        //public bool HasNext()
        //{
        //    return curr != null && curr.right != null;
        //}

        #region 04/16/2024
        public TreeNode cur = new TreeNode(-1);
        public TreeNode head;
        public _0173(TreeNode root)
        {
            head = cur;
            inorder(root);
        }

        public void inorder(TreeNode node)
        {
            if (node != null)
            {
                inorder(node.left);
                head.right = node;
                head = head.right;
                inorder(node.right);
            }
        }

        public int Next()
        {
            if (cur == null) return 0;
            cur = cur.right;
            return cur.val;
        }

        public bool HasNext()
        {
            return cur != null && cur.right != null ? true : false;
        }
        #endregion

    }
}
