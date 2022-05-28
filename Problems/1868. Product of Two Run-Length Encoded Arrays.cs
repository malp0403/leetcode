using System;
using System.Collections.Generic;
using System.Text;
/// <summary>test 1
//int[][] c1 = new int[2][];
//c1[0] = new int[] { 1, 3 };
//c1[1] = new int[] { 2, 3 };
//int[][] c2 = new int[2][];
//c2[0] = new int[] { 6, 3 };
//c2[1] = new int[] { 3, 3 };
/// </summary>
/// /// <summary>test 1
//int[][] c1 = new int[2][];
//c1[0] = new int[] { 1, 3 };
//c1[1] = new int[] { 2, 3 };
//int[][] c2 = new int[2][];
//c2[0] = new int[] { 6, 3 };
//c2[1] = new int[] { 3, 3 };
/// </summary>
namespace leetcode.Problems
{
    class _1868
    {
        // ************** My solution(timeout)************************
        public IList<IList<int>> FindRLEArray(int[][] encoded1, int[][] encoded2)
        {


            //int[][] c1 = new int[2][];
            //c1[0] = new int[] { 1, 3 };
            //c1[1] = new int[] { 2, 3 };
            //int[][] c2 = new int[2][];
            //c2[0] = new int[] { 6, 3 };
            //c2[1] = new int[] { 3, 3 };
            //List<int> l1 = DeCoding(encoded1);
            //List<int> l2 = DeCoding(encoded2);
            int i = 0;
            int j = 0;
            List<int> result = new List<int>() { };
            while (i < encoded1.Length || j < encoded2.Length)
            {
                int a = encoded1[i][0];
                int b = encoded2[j][0];
                if ((--encoded1[i][1]) == 0) i++; ;
                if ((--encoded2[j][1]) == 0) j++;
                result.Add(a * b);
            }
            return EnCoding(result);
        }

        public IList<IList<int>> EnCoding(List<int> code)
        {
            IList<IList<int>> ans = new List<IList<int>>() { };
            int prev = code[0];
            int count = 1;
            for (int i = 0; i < code.Count; i++)
            {
                if (i == code.Count - 1 || code[i] != code[i + 1])
                {
                    ans.Add(new List<int>() { code[i], count });
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            return ans;
        }
        // ************** My solution(slow but not timeOut)************************
        public IList<IList<int>> FindRLEArray_R2(int[][] encoded1, int[][] encoded2)
        {
            int i = 0;
            int j = 0;
            IList<IList<int>> ans = new List<IList<int>>() { };
            while (i < encoded1.Length || j < encoded2.Length)
            {
                var computed = encoded1[i][0] * encoded2[j][0];
                List<int> list = new List<int>() { computed };
                if (encoded1[i][1] == encoded2[j][1])
                {
                    list.Add(encoded1[i][1]);
                    i++;
                    j++;
                }
                else if (encoded1[i][1] > encoded2[j][1])
                {
                    list.Add(encoded2[j][1]);
                    encoded1[i][1] = encoded1[i][1] - encoded2[j][1];
                    j++;
                }
                else
                {
                    list.Add(encoded1[i][1]);
                    encoded2[j][1] = encoded2[j][1] - encoded1[i][1];
                    i++;
                }
                helper(ans, list);
            }
            return ans;
        }
        public void helper(IList<IList<int>> list, List<int> li)
        {
            if (list.Count == 0) list.Add(li);
            else
            {
                IList<int> last = list[list.Count - 1];
                if (last[0] == li[0])
                {
                    last[1] += li[1];
                }
                else
                {
                    list.Add(li);
                }
            }
        }
    }
}
