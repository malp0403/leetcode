using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0277
    {
     
        // Mock API
        public bool Knows(int i, int j)
        {
            return true;
        }

        #region 07/11/2024
        public int FindCelebrity(int n)
        {
            int candidate = 0;
            for(int i =0; i < n; i++)
            {
                if (Knows(candidate, i))
                {
                    candidate = i;
                }
            }
            for(int i =0; i < n; i++)
            {
                if (i == candidate) continue;
                if (Knows(candidate, i) || !Knows(i, candidate))
                {
                    return -1;
                }
            }
            return candidate;
        }
            #endregion
        }
    }
