using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0953
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };
            for (int z = 0; z < order.Length; z++)
            {
                dic.Add(order[z], z);
            }
            dic.Add(' ', -999);
            string pos = words[0];
            bool sorted = true;
            int i = 1;
            int start = 0;
            while (i < words.Length)
            {
                int len = Math.Max(pos.Length, words[i].Length);
                start = 0;
                while (start < len)
                {
                    var char1 = start < pos.Length ? pos[start] : ' ';
                    var char2 = start < words[i].Length ? words[i][start] : ' ';
                    if (dic[char1] < dic[char2]) break;
                    else if (dic[char1] == dic[char2]) { start++; }
                    else
                    {
                        sorted = false;
                        break;
                    }
                }
                if (!sorted) break;
                pos = words[i];
                i++;
            }
            return sorted;

        }

        //--12-25-2021-----------
        public bool IsAlienSorted_R2(string[] words, string order)
        {
            Dictionary<char, int> d = new Dictionary<char, int>() { };
            for (int i = 0; i < order.Length; i++)
            {
                d.Add(order[i], i);
            }
            for (int j = 0; j < words.Length - 1; j++)
            {
                for (int z = 0; z < words[j].Length; z++)
                {
                    if (z >= words[j + 1].Length) return false;

                    if (d[words[j][z]] == d[words[j + 1][z]])
                    {
                        continue;
                    }
                    else if (d[words[j][z]] > d[words[j + 1][z]])
                    {
                        return false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return true;
        }
    }
}
