using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0791
    {
        #region LeetCode Approach 1: Custom Comparator
        public string CustomSortString(string order, string s)
        {
            char[] arr=s.ToCharArray();
            Array.Sort(arr, (x, y) =>
            {
                return order.IndexOf(x) - order.IndexOf(y);
            });
            return new string(arr);
        }
        #endregion

        #region Approach 2: Frequency Table and Counting
        /*
             string customSortString(string order, string s) {
        // Create a frequency table
        unordered_map<char, int> freq;

        // Initialize frequencies of letters
        // freq[c] = frequency of char c in s
        for (char letter : s) {
            freq[letter]++;
        }

        // Iterate order string to append to result
        string result = "";
        for (char letter : order) {
            while (freq[letter]-- > 0) {
                result += letter;
            }
        }

        // Iterate through freq and append remaining letters
        // This is necessary because some letters may not appear in `order`
        for (auto & [letter, count] : freq) { 
            while (count-- > 0) {
                result += letter;
            }
        }

        // Return the result
        return result;
    }
         */
        #endregion

        #region Solution
        public string CustomSortString_s(string order, string s)
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
                        if (dic.ContainsKey(arr[j]) && (dic[arr[i]] > dic[arr[j]]))
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
        #endregion

        #region 01/06/2022
        Dictionary<char, int> dic = new Dictionary<char, int>() { };
        public string CustomSortString_R2(string order, string s)
        {
            for (int i = 0; i < order.Length; i++)
            {
                dic.Add(order[i], i);
            }
            char[] chars = s.ToCharArray();
            List<char> list = chars.ToList();
            list.Sort((x, y) => MyComparer(x, y));


            return String.Join("", list.ToArray());
        }
        public int MyComparer(char a, char b)
        {
            var a1 = dic.ContainsKey(a) ? dic[a] : 0;
            var b1 = dic.ContainsKey(b) ? dic[b] : 0;
            return a1 - b1;

        }
        #endregion

        #region 10/07/2024 using index value as priority ; using Dictionary
        public string CustomSortString_2024_10_07(string order, string s)
        {
            char[] arr = s.ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i =0; i < order.Length; i++)
            {
                dic.Add(order[i], i);
            }


            Array.Sort(arr, (x, y) =>
            {
                int weight1 = dic.ContainsKey(x) ? dic[x] : 0;
                int weight2 = dic.ContainsKey(y) ? dic[y] : 0;
                return weight1 - weight2;
            });
            return new string(arr);

        }
        #endregion


























    }
}
