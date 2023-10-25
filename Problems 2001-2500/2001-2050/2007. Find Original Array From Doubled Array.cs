using leetcode.Problems_2001_2500._2001_2050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _2007() { };
//obj.FindOriginalArray(new int[] { 50000, 100000 });
#endregion

namespace leetcode.Problems_2001_2500._2001_2050
{
    internal class _2007
    {
        #region 10/10/2023
        public int[] FindOriginalArray_20231010(int[] changed)
        {
            int[] arr = Enumerable.Repeat(0, 100001).ToArray();

            foreach (var item in changed)
            {
                arr[item]++;
            }
            List<int> list = new List<int>();
            for(int i = 100000; i >= 0; i--)
            {
                while (arr[i] > 0)
                {
                    if (i % 2 == 1) return new int[] { };
                    arr[i]--;
                    int half = i / 2;

                    if (arr[half] == 0) return new int[] { };
                   
                    arr[half]--;
                    list.Add(half);
                }
            }
            return list.ToArray();
        }
        #endregion
    }
}
