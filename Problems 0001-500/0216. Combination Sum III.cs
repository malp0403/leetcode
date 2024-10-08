﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0216
    {
        #region LeetCode Approach 1: Backtracking
        #endregion

        #region Solution
        IList<IList<int>> answer_2024_07_07 = new List<IList<int>>();
        bool[] visite_2024_07_07;
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            visite_2024_07_07 = Enumerable.Repeat(false, 10).ToArray();
            backTracking_2024_07_07(1, k, n, new List<int>());
            return answer_2024_07_07;
        }

        public void backTracking_2024_07_07(int start, int countLeft, int sumLeft, List<int> curList)
        {
            if (sumLeft < 0) return;

            if (countLeft == 0)
            {
                if (sumLeft == 0 && curList.Count > -0)
                {
                    answer_2024_07_07.Add(curList.ToList());
                }
            }
            else
            {
                for (int i = start; i <= 9; i++)
                {
                    if (!visite_2024_07_07[i])
                    {

                        curList.Add(i);
                        visite_2024_07_07[i] = true;
                        backTracking_2024_07_07(i + 1, countLeft - 1, sumLeft - i, curList);
                        curList.Remove(i);
                        visite_2024_07_07[i] = false;
                    }
                }
            }

        }

        #endregion

        #region 09/29/2024 set upper bound when backtracking to avoid duplicate
        IList<IList<int>> res_2024_09_29;
        public IList<IList<int>> CombinationSum3_2024_09_29(int k, int n)
        {
            res_2024_09_29= new List<IList<int>>();
            backTracking_2024_09_29(k, new List<int>(),n,9);
            return res_2024_09_29;
        }

        public void backTracking_2024_09_29(int k,List<int> curlist,int curSum,int upper)
        {
            if (k==0)
            {
                if(curSum == 0)
                {
                    res_2024_09_29.Add(curlist.ToList());

                }
               
                    return;
                
            }
            if (curSum <= 0) return;

            for (int i = upper; i >= 1; i--) { 
            
                if(!curlist.Contains(i))
                {
                    curlist.Add(i);

                    backTracking_2024_09_29(k - 1, curlist, curSum - i,i-1);
                    curlist.RemoveAt(curlist.Count - 1);


                }
            }
        }
        #endregion

    }
}
