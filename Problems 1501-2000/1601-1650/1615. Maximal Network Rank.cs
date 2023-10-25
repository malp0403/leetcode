using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 There is an infrastructure of n cities with some number of roads connecting these cities. Each roads[i] = [ai, bi] indicates that there is a bidirectional road between cities ai and bi.

The network rank of two different cities is defined as the total number of directly connected roads to either city. If a road is directly connected to both cities, it is only counted once.

The maximal network rank of the infrastructure is the maximum network rank of all pairs of different cities.

Given the integer n and the array roads, return the maximal network rank of the entire infrastructure.

 

Example 1:



Input: n = 4, roads = [[0,1],[0,3],[1,2],[1,3]]
Output: 4
Explanation: The network rank of cities 0 and 1 is 4 as there are 4 roads that are connected to either 0 or 1. The road between 0 and 1 is only counted once.
Example 2:



Input: n = 5, roads = [[0,1],[0,3],[1,2],[1,3],[2,3],[2,4]]
Output: 5
Explanation: There are 5 roads that are connected to cities 1 or 2.
Example 3:

Input: n = 8, roads = [[0,1],[1,2],[2,3],[2,4],[5,6],[5,7]]
Output: 5
Explanation: The network rank of 2 and 5 is 5. Notice that all the cities do not have to be connected.
 

Constraints:

2 <= n <= 100
0 <= roads.length <= n * (n - 1) / 2
roads[i].length == 2
0 <= ai, bi <= n-1
ai != bi
Each pair of cities has at most one road connecting them.
 */
#endregion

#region Test
/*
             var obj =new  _1615();
            obj.MaximalNetworkRank(5, new int[][] { new int[] { 0,1} ,
            new int[] { 0,3 },
            new int[] { 1,2 },
            new int[] { 1,3 },
            new int[] { 2,3 },
            new int[] { 2,4 }});
            obj.MaximalNetworkRank(2,new int[][] { new int[] { 1,0} });

 */
#endregion
namespace leetcode.Problems_1501_2000._1601_1650
{
    internal class _1615
    {
        #region 10/19/2023  dest-> all possible dests; remove 1->2 and 2->1 duplicate situation
        public int MaximalNetworkRank(int n, int[][] roads) 
        {
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>() { };

            for(int i =0; i < roads.Length; i++)
            {
                int dest1 = roads[i][0];
                int dest2 = roads[i][1];
                if (dic.ContainsKey(dest1)) dic[dest1].Add(dest2);
                else dic.Add(dest1, new HashSet<int>() { dest2});

                if(dic.ContainsKey(dest2)) dic[dest2].Add(dest1);
                else dic.Add(dest2 , new HashSet<int>() { dest1 });
            }

            int max = 0;
            List<int> dests = dic.Keys.ToList();

            for (int i = 0; i < dests.Count; i++)
            {
                for(int j=i+1;j< dests.Count; j++)
                {
           
                       max= Math.Max(max, dic[dests[i]].Count + dic[dests[j]].Count- (dic[dests[i]].Contains(dests[j])?1:0 ));
                    if (max == 6)
                    {

                    }

                }
            }

            return max;
        }
        #endregion
    }
}
