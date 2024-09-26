using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0406
    {


        #region Approach 1: Greedy
        public int[][] ReconstructQueue(int[][] people)

        {
            Array.Sort(people, CompareStrings);




            for (int i = 0; i < people.Length; i++)
            {
                for (int j = 0; j < people[i].Length; j++)
                {
                    Console.Write(people[i][j] + " ");
                }
                Console.WriteLine();
            }
            return null;
        }
        public static int CompareStrings(int[] o1, int[] o2)
        {
            return o1[0] == o2[0] ? o1[1] - o2[1] : o2[0] - o1[0];
        }
        #endregion

        #region 01/05/2022
        //01-05-2022----------------
        public int[][] ReconstructQueue_R2(int[][] people)
        {
            Array.Sort(people, CompareStrings);
            List<int[]> ans = new List<int[]>() { };
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i][1] == ans.Count)
                {
                    ans.Add(people[i]);
                }
                else
                {
                    ans.Insert(people[i][1], people[i]);
                }
            }
            return ans.ToArray();
        }
        #endregion

        #region 09/05/2024 sort by height in desceding then sort count by assceding order
        public int[][] ReconstructQueue_2024_09_05(int[][] people)
        {
            Array.Sort(people, (a, b) =>
            {
                if (a[0] == b[0]) return a[1] - b[1];
                else return b[0] - a[0];
            });

            List<int[]> output = new List<int[]>();
            for(int i =0;i < people.Length; i++)
            {
                output.Insert(people[i][1], people[i]);
            }
            return output.ToArray();
        }
        #endregion

    }

}

