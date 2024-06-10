using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0179
    {
        #region 04/16/2024
        public class myComparer : IComparer<string>{
            public int Compare(string s1, string s2)
            {
                string x = s1 + s2;
                string y = s2 + s1;
                return y.CompareTo(x);
            }
        }
        public string LargestNumber_2024_04_16(int[] nums)
        {
            string[] arr = nums.Select(x => x.ToString()).ToArray();
            var comparer = new myComparer();
            Array.Sort(arr, comparer);

            if (arr[0] == "0")
            {
                return "0";
            }
            string res = "";
            foreach (var item in arr)
            {
                res += item;
            }
            return res;
        }


        #endregion

        #region someone else clean solution
        public string LargestNumber_someoneElse1(int[] nums)
        {
            if (nums.All(_ => _ == 0)) return "0";

            var s = nums.Select(_ => _.ToString()).ToList();

            s.Sort((a, b) => (b + a).CompareTo(a + b));

            return string.Concat(s);
        }
        #endregion
    }

}
