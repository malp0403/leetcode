using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1751_1800
{
    internal class _1791
    {
        public int FindCenter(int[][] edges)
        {
            int first = -1;
            int second = -1;
            for(int i =0; i < edges.Length; i++)
            {
                if (i == 0)
                {
                    first = edges[i][0];
                    second= edges[i][1];
                }
                else
                {
                    if(first == edges[i][0] || first == edges[i][1])
                    {
                        return first;
                    }else
                    {
                        return second;
                    }
                    
                }
            }
            return first != -1 ? first : second;

        }
    }
}
