using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0791
    {
        public string CustomSortString(string order, string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for (int i = 0; i < order.Length; i++)
            {
                dic.Add(order[i], i);
            }
            List<char> li = new List<char>() { };

            var arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (dic.ContainsKey(arr[j]) && (dic[arr[i]] > dic[arr[j]]) )
                        {
                            var temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }

            return new string(arr);


        }

        //01-06-2022---------------------------
        Dictionary<char, int> dic = new Dictionary<char, int>() { };
        public string CustomSortString_R2(string order,string s)
        {
            for(int i=0; i < order.Length; i++)
            {
                dic.Add(order[i], i);
            }
            char[] chars = s.ToCharArray();
            List<char> list = chars.ToList();
            list.Sort((x, y) => MyComparer(x, y)) ;


            return String.Join("",list.ToArray());
        }
        public int MyComparer(char a, char b)
        {
            var a1 = dic.ContainsKey(a) ? dic[a] : 0;
            var b1 = dic.ContainsKey(b) ? dic[b] : 0;
            return a1 - b1;
            
        }
        //---------------------------------------------
    }
}
