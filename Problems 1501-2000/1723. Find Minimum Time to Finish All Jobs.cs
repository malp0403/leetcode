using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1701_1750
{
    internal class _1723
    {
        #region 10/17/2023  DFS
        int min = int.MaxValue;
        public int MinimumTimeRequired(int[] jobs,int k)
        {
            if (jobs.Length == 1) return jobs[0];

            int[] persons = Enumerable.Repeat(0, k).ToArray();
           
            Array.Sort(jobs, (a, b) => { return b - a; });

            persons[0] = jobs[0];
            helper(1, jobs, 0, persons, jobs[0]);

            return min;
        }

        public void helper(int jobIndex, int[] jobs, int personIndex, int[] persons,int curMax)
        {

            if(jobIndex >= jobs.Length)
            {   
                if(personIndex == persons.Length - 1)
                {
                    min = Math.Min(curMax, min);

                }
                return;
            }

            //sign to new person
            if(personIndex < persons.Length-1)
            {
                persons[personIndex + 1] = jobs[jobIndex];
                helper(jobIndex + 1, jobs, personIndex + 1, persons, Math.Max(curMax, persons[personIndex + 1]));
                persons[personIndex + 1] -= jobs[jobIndex];
            }


            for(int i =0; i <= personIndex; i++)
            {
                persons[i] += jobs[jobIndex];
                helper(jobIndex + 1, jobs, personIndex, persons, Math.Max(curMax, persons[i]));
                persons[i] -= jobs[jobIndex];
            }
        }
        #endregion
    }
}
