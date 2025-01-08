using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0312
    {
        #region 07/23/2024 TLE
        Dictionary<string, int> dic;
        public int MaxCoins(int[] nums)
        {
            dic = new Dictionary<string, int>();
            List<int> list = new List<int>();
            foreach (var item in nums)
            {
                if(item != 0)
                {
                    list.Add(item);
                }
            }
            return helper_2024_07_22(list);
        }

        public int helper_2024_07_22( List<int> list)
        {
            if (list.Count == 0) return 0;
            if (list.Count == 1) return list[0];

            string key = formatKey(list);
            if (dic.ContainsKey(key)) return dic[key];


            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                List<int> newList = list.ToList();
                newList.RemoveAt(i);

                int prev = i > 0 ? list[i] : 1;
                int latter = i < list.Count - 1 ? list[i + 1] : 1;

                sum = Math.Max(sum, prev * latter * list[i] + helper_2024_07_22(newList));
            }

            dic.Add(key, sum);
            return dic[key];
        }

        public string formatKey(List<int> list)
        {
            string str = string.Join("#", list);
            return str;
        }
        #endregion
    }
}
