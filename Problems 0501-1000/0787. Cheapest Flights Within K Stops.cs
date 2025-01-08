using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _0787() { };

//obj.FindCheapestPrice_20230917_withoutset(3, new int[3][]
//{
//   new int[3]{0,1,100},
//   new int[3]{1,2,100},
//   new int[3]{0,2,500},

//}, 0, 2, 0);

//obj.FindCheapestPrice_20230917_withoutset(4, new int[5][]
//{
//   new int[3]{0,1,100},
//   new int[3]{1,2,100},
//   new int[3]{2,0,100},
//   new int[3]{1,3,600},
//   new int[3]{2,3,200},

//}, 0, 3, 1);

#endregion

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0787
    {
        #region 09/13/2023 TLE
        int cheapest = int.MaxValue;
        Dictionary<int, List<(int dst, int cost)>> dic;
        int _dst;
        int maxStops;
        HashSet<int> visited;
        public int FindCheapestPrice_20230913(int n, int[][] flights, int src, int dst, int k)
        {
            dic = new Dictionary<int, List<(int dst, int cost)>>() { };
            _dst = dst;
            maxStops = k;
            visited = new HashSet<int>(src);

            foreach (var flight in flights)
            {
                int start = flight[0];
                int end = flight[1];
                int cost = flight[2];
                if (dic.ContainsKey(start))
                {
                    dic[start].Add((end, cost));
                }
                else
                {
                    dic.Add(start, new List<(int dst, int cost)>() { (end, cost) });
                }

            }


            helper(0, src, 0);

            return cheapest == int.MaxValue?-1:cheapest;
            


        }

        public void helper(int stops,int curStop,int curCost)
        {
            if(curStop == _dst)
            {
                cheapest = Math.Min(curCost, cheapest);
                return;
            }
            if (curCost > cheapest) return;
   

            if (stops > maxStops ) return;
            if (!dic.ContainsKey(curStop)) return;
            foreach (var item in dic[curStop])
            {
                if (visited.Contains(item.dst)) continue;
                visited.Add(item.dst);
                helper(stops + 1, item.dst, curCost + item.cost);
                visited.Remove(item.dst);

            }

        }
        #endregion

        #region 09/17/2023 BFS
        public int FindCheapestPrice_20230917(int n, int[][] flights, int src, int dst, int k)
        {
            Dictionary<int, List<(int dst, int cost)>>  dic = new Dictionary<int, List<(int dst, int cost)>>() { };
            int answer = int.MaxValue;
            foreach (var flight in flights)
            {
                int start = flight[0];
                int end = flight[1];
                int cost = flight[2];
                if (dic.ContainsKey(start))
                {
                    dic[start].Add((end, cost));
                }
                else
                {
                    dic.Add(start, new List<(int dst, int cost)>() {( end, cost) });
                }
            }

            Queue<(int cur, int cost,HashSet<int> set)> q = new Queue<(int cur, int cost, HashSet<int> set)>() { };

            q.Enqueue((src, 0,new HashSet<int>() { src}));
            int level = 0;
            while(q.Count>0 && level<=k)
            {
                int size = q.Count();
                while(size>0)
                {
                    size--;
                    var ele = q.Dequeue();
                    int cur = ele.cur;
                    int cost = ele.cost;
                    if (!dic.ContainsKey(cur)) continue;

                    foreach (var item in dic[cur])
                    {
                        int destination = item.dst;
                        if(destination == dst)
                        {
                            answer = Math.Min(cheapest, cost + item.cost);
                            continue;   
                        }
                        if (ele.set.Contains(destination)) continue;
                        if ((cost + item.cost) > answer) continue;
                        var set = new HashSet<int>(ele.set);
                        set.Add(destination);
                        q.Enqueue((destination, cost + item.cost, set));
                    }


                }
                level++;

            }
            return answer == int.MaxValue?-1:answer;

        }
        #endregion

        #region 09/17/2023 BFS without set; use array to record the cheapest price from src to index;
        public int FindCheapestPrice_20230917_withoutset(int n, int[][] flights, int src, int dst, int k)
        {
            Dictionary<int, List<(int dst, int cost)>> dic = new Dictionary<int, List<(int dst, int cost)>>() { };
            int answer = int.MaxValue;
            foreach (var flight in flights)
            {
                int start = flight[0];
                int end = flight[1];
                int cost = flight[2];
                if (dic.ContainsKey(start))
                {
                    dic[start].Add((end, cost));
                }
                else
                {
                    dic.Add(start, new List<(int dst, int cost)>() { (end, cost) });
                }
            }

            Queue<(int cur, int cost)> q = new Queue<(int cur, int cost)>() { };
            int[] dist = Enumerable.Repeat(int.MaxValue, n).ToArray();
            q.Enqueue((src, 0));
            int level = 0;
            while (q.Count > 0 && level <= k)
            {
                int size = q.Count();
                while (size > 0)
                {
                    size--;
                    var ele = q.Dequeue();
                    int cur = ele.cur;
                    int cost = ele.cost;
                    if (!dic.ContainsKey(cur)) continue;

                    foreach (var item in dic[cur])
                    {
                        int destination = item.dst;
                        int price = cost + item.cost;

                        if (dist[destination] != int.MaxValue && price >= dist[destination])
                        {
                            continue;
                        }

                        dist[destination] = price;

                        q.Enqueue((destination, cost + item.cost));
                    }


                }
                level++;

            }
            return dist[dst] == int.MaxValue ? -1 : dist[dst];

        }
        #endregion

    }
}
