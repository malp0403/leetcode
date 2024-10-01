using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0547
    {
        #region 09/28/2024
        HashSet<int> visited_2024_09_28;
        public int FindCircleNum_2024_09_28(int[][] isConnected)
        {
            int count = 0;
            visited_2024_09_28 = new HashSet<int>();

            for(int i =0; i < isConnected.Length; i++)
            {

                if (!visited_2024_09_28.Contains(i))
                {
                    count++;
                    dfs_2024_09_28(i, isConnected);
                }
            }

            return count;
        }

        public void dfs_2024_09_28(int index,int[][] isConnected)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(index);
            visited_2024_09_28.Add(index);
            while (stack.Count > 0)
            {
                int num = stack.Pop();
                for(int i =0; i< isConnected[num].Length; i++)
                {
                    if(!visited_2024_09_28.Contains(i) && isConnected[num][i] == 1)
                    {
                        stack.Push(i);
                        visited_2024_09_28.Add(i);
                    }
                }
            }


        }
        #endregion
    }
}
