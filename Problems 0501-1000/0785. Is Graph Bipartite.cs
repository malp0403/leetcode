using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0785
    {

        #region 09/12/2023
        public bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            int[] arr = Enumerable.Repeat(-1,n).ToArray();

            for(int i =0; i < n; i++)
            {
                if (arr[i] == -1)
                {
                    Stack<int> stack = new Stack<int>();
                    stack.Push(i);
                    arr[i] = 0;
                    while (stack.Count > 0)
                    {
                        int number = stack.Pop();
                        foreach (var item in graph[number])
                        {
                            if (arr[item] == -1)
                            {
                                stack.Push(item);
                                arr[item] = arr[number] ^ 1;
                            }else if (arr[item] == arr[number])
                            {
                                return false;
                            }
                        }

                    }

                }
            }
            return true;
        }
        #endregion
    }
}
