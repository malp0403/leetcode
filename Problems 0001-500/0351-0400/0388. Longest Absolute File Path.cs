using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0388
    {
        #region 09/04/2024 attemp failed
        //int max = 0;
        //public int LengthLongestPath_2024_09_04(string input)
        //{
        //    if (input.IndexOf('.') < 0) return 0;

        //    string[] step1 = input.Split('\n');
        //    List<List<string[]>> finalList = new List<List<string[]>>();

        //    List<string[]> list = new List<string[]>();
        //    foreach (var item in step1)
        //    {
        //        string[] temp = item.Split("\t");
        //        if(temp.Length == 1)
        //        {
        //            if(list.Count > 0)
        //            {
        //                finalList.Add(list.Select(x=>x).ToList());
        //            }
        //            list = new List<string[]>();
        //        }

        //        list.Add(temp);
        //    }
        //    finalList.Add(list);

        //    for(int i =0; i < finalList.Count; i++)
        //    {
        //        dfs(0, finalList[i], 1, "");

        //    }

        //    return max;
        //}

        //public void dfs(int start, List<string[]> list, int target, string str)
        //{

        //    for (int i =0; i < list.Count; i++)
        //    {
        //        if (list[i].Length == target)
        //        {
        //            string temp = str + (str == "" ? "" : "/") + list[i][target - 1];
        //            if (temp.IndexOf(".") >= 0)
        //            {
        //                Console.WriteLine(temp.Length + ":"+temp);
        //                max = Math.Max(temp.Length, max );
        //            }
        //            else
        //            {
        //                dfs(i, list, target + 1, temp);

        //            }
        //        }
        //    }
           

        //}
        #endregion

    }
}
