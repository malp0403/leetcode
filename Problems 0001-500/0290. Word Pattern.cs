using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0290
    {
        #region 07/15/2024
        public bool WordPattern(string pattern, string s)
        {
            List<string> arr1 = new List<string>();
            foreach (var item in pattern)
            {
                arr1.Add(item.ToString());
            }
            string[] arr2 = s.Split(" ");
            if (arr1.Count != arr2.Length) return false;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            HashSet<string> seen = new HashSet<string>();
            for(int i =0; i < arr1.Count; i++)
            {
                if (dic.ContainsKey(arr1[i]))
                {
                    if (dic[arr1[i]] != arr2[i]) return false;
                }
                else
                {
                    if (seen.Contains(arr2[i])) return false;
                    dic.Add(arr1[i], arr2[i]);
                }
                seen.Add(arr2[i]);
            }
            return true;
        }
        #endregion
    }
}
