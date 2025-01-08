using leetcode.Problems_2501_3000._2301_2350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Test Data
//var obj2 = new _2391();
//obj2.GarbageCollection(
//    new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 4, 3 });
#endregion
namespace leetcode.Problems_2501_3000._2301_2350
{
    internal class _2391
    {
        #region 09/26/2023
  
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            bool P_start = false;
            bool G_start = false;
            bool M_start = false;

            int time = 0;
            for(int i =garbage.Length-1; i >=0; i--)
            {
                var res = helper(garbage[i]);
                int t = i == 0 ? 0 : travel[i - 1];
    

                if (res.P > 0)
                {
                    time +=  res.P;
                    P_start = true;
                }
                if (res.G > 0)
                {
                    time +=   res.G;
                    G_start = true;
                }
                if (res.M > 0)
                {
                    time += res.M;
                    M_start = true;
                }
                if (P_start) time += t;
                if (G_start) time += t;
                if (M_start) time += t;
            }
            return time;
        }
        public (int G, int P,int M) helper(string s)
        {
            int G = 0; int P = 0;int  M = 0;
            foreach (char c in s)
            {
                if (c == 'G') G++;
                if (c == 'P') P++;
                if (c == 'M') M++;
            }
            return (G, P, M);

        }
        #endregion
    }
}
