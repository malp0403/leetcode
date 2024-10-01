using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500
{
    internal class _0399
    {
        #region 09/28/2024
        Dictionary<(string a, string b), double> mapping;
        Dictionary<string, List<string>> dic2;
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            mapping = new Dictionary<(string a, string b), double>();
            dic2 = new Dictionary<string, List<string>>();
            for(int i =0; i < equations.Count; i++)
            {
                string first = equations[i][0];
                string second = equations[i][1];
                mapping.Add((first, second), values[i]);
                mapping.Add((second, first), 1/values[i]);
                if (dic2.ContainsKey(first))
                {
                    dic2[first].Add(second);
                }
                else
                {
                    dic2.Add(first, new List<string> { second });
                }

                if (dic2.ContainsKey(second))
                {
                    dic2[second].Add(first);
                }
                else
                {
                    dic2.Add(second, new List<string> { first });
                }
            }

           List<double> result = new List<double>();

            for(int i =0; i < queries.Count; i++)
            {

                result.Add(dfs_2024_09_28(queries[i]));
            }

            return result.ToArray();
        }

        public double dfs_2024_09_28(IList<string> query)
        {
            if (!dic2.ContainsKey(query[0]) || !dic2.ContainsKey(query[1])) return -1;
            if (query[0] == query[1]) return 1;

            HashSet<string> visited = new HashSet<string>();
            Queue<(string str,double prod)> queue= new Queue<(string str, double prod)>();

            queue.Enqueue((query[0],1));
            visited.Add(query[0]);

           
            while (queue.Count >0)
            {
                var ele = queue.Dequeue();

                if (dic2.ContainsKey(ele.str))
                {
                    List<string> children = dic2[ele.str];

                    foreach (var item in children)
                    {
                        if (!visited.Contains(item))
                        {

                            if(item == query[1])
                            {
                                return ele.prod * mapping[(ele.str, item)];
                            }
                            visited.Add(item);
                            queue.Enqueue((item, ele.prod * mapping[(ele.str, item)]));
                        }
                    }
                }
                
            }

            return -1;
        }

        #endregion
    }
}
