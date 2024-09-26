using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0437
    {

        #region Solution
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        int count = 0;
        public int PathSum_s1(TreeNode root, int targetSum)
        {
            if (root == null) return 0;
            travel(root, targetSum, root.val);
            return count;
        }

        public void travel(TreeNode cur, int k, int preTotal)
        {
            if (cur == null) return;
            int curSum = preTotal + cur.val;
            if (curSum == k) count++;
            if (d.ContainsKey(curSum - k))
            {
                count += d[curSum - k];
            }
            if (d.ContainsKey(curSum)) d[curSum]++;
            else d.Add(curSum, 1);

            travel(cur.left, k, curSum);
            travel(cur.right, k, curSum);

            if (d[curSum] == 1) d.Remove(curSum);
            else { d[curSum]--; }
        }
        #endregion

        #region Approach 1: Prefix Sum 09/22/2024
        int count_2024_09_22 = 0;
        Dictionary<long, int> dic_2024_09_22 = new Dictionary<long, int>();

        public int PathSum(TreeNode root, int targetSum)
        {
            DFS_2024_09_22(root,0,targetSum);
  
            return count_2024_09_22;
        }

        public void DFS_2024_09_22(TreeNode node,long curSum,int targetSum)
        {
            if (node == null) return;

            curSum += node.val;

            if(curSum == targetSum)
            {
                count_2024_09_22++;
            }
            if (dic_2024_09_22.ContainsKey(curSum - targetSum))
            {
                count_2024_09_22 += dic_2024_09_22[curSum - targetSum];
            }

            if(dic_2024_09_22.ContainsKey(curSum))
            {
                dic_2024_09_22[curSum]++;
            }
            else
            {
                dic_2024_09_22.Add(curSum,1);
            }

            DFS_2024_09_22(node.left, curSum, targetSum);
            DFS_2024_09_22(node.right,curSum,targetSum);



            dic_2024_09_22[curSum]--;

           
        }
        #endregion


    }
}
