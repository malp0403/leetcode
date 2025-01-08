using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0265
    {
        #region 07/09/2024
        public int MinCostII(int[][] costs)
        {

            
            int Length = costs[0].Length;


            int min1 = 0;
            int min2 = 0;
            int p1 = -1;
            int p2 = -1;

            int? min1_temp = null;
            int? mint2_temp = null;
            int p1_temp = p1;
            int p2_temp = p2;

            for (int i =0; i < costs.Length; i++)
            {
                min1_temp = null;
                mint2_temp = null;
                p1_temp = p1;
                p2_temp = p2;

                for(int j=0; j < Length; j++)
                {
                    int cost = 0;
                    if (j != p1)
                    {
                        cost = min1 + costs[i][j];
                    }
                    else{
                        cost = min2 + costs[i][j];
                    }

                    if(min1_temp == null)
                    {
                        min1_temp = cost;
                        p1_temp = j;
                    }else if(mint2_temp == null)
                    {
                        if(min1_temp > cost)
                        {

                            mint2_temp = min1_temp;
                            p2_temp = p1_temp;

                            min1_temp = cost;
                            p1_temp = j;
                        }
                        else
                        {
                            mint2_temp = cost;
                            p2_temp = j;
                        }
                    }else if(cost < min1_temp)
                    {
                        mint2_temp = min1_temp;
                        p2_temp = p1_temp;

                        min1_temp = cost;
                        p1_temp = j;
                    }else if(cost < mint2_temp)
                    {
                        mint2_temp = cost;
                        p2_temp = j;
                    }


                }

                min1 = (int)min1_temp;
                min2 = (int)mint2_temp;
                p1 = p1_temp;



            }




            return (int)min1;
        }
        #endregion
    }
}
