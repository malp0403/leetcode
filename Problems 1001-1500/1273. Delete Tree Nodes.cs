using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 A tree rooted at node 0 is given as follows:

The number of nodes is nodes;
The value of the ith node is value[i];
The parent of the ith node is parent[i].
Remove every subtree whose sum of values of nodes is zero.

Return the number of the remaining nodes in the tree.

 

Example 1:


Input: nodes = 7, parent = [-1,0,0,1,2,2,2], value = [1,-2,4,0,-2,-1,-1]
Output: 2
Example 2:

Input: nodes = 7, parent = [-1,0,0,1,2,2,2], value = [1,-2,4,0,-2,-1,-2]
Output: 6
 

Constraints:

1 <= nodes <= 104
parent.length == nodes
0 <= parent[i] <= nodes - 1
parent[0] == -1 which indicates that 0 is the root.
value.length == nodes
-105 <= value[i] <= 105
The given input is guaranteed to represent a valid tree.
 */
#endregion
namespace leetcode.Problems_1001_1500._1251_1300
{
    internal class _1273
    {
        #region 11/04/2023
        Dictionary<int, List<int>> children;  
        Dictionary<int, int> sums;
        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            children = new Dictionary<int, List<int>>();
            sums = new Dictionary<int, int>();
            for(int i =1; i < parent.Length; i++)
            {
                int p = parent[i];
                if (children.ContainsKey(p))
                {
                    children[p].Add(i);
                }
                else
                {
                    children.Add(p, new List<int>() { i});
                }
            }
            dfs(0, value);

            int count = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            while(queue.Count > 0)
            {
                int i = queue.Dequeue();
                if (sums[i] != 0)
                {
                    count++;
                    if(children.ContainsKey(i))
                    {
                        foreach (int p in children[i])
                        {
                            queue.Enqueue(p);
                        }
                    }
                  
                }
            }
            return count;


        }
        public int dfs(int index,int[] value)
        {
            if (sums.ContainsKey(index))
            {
                return sums[index];
            }
            int total = value[index];
            if(children.ContainsKey(index))
            {
                foreach(int i in children[index]) {
                    total += dfs(i, value);
                }
            }

            sums.Add(index, total);
            return sums[index];

        }
        #endregion
    }
}
