using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0438
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> answer = new List<int>() { };
            if (s.Length < p.Length) return answer;
            int[] records = Enumerable.Repeat(0, 26).ToArray();
            int[] reference = Enumerable.Repeat(0, 26).ToArray();
            for(int i = 0; i < p.Length; i++)
            {
                reference[p[i] - 'a']++;
                records[s[i] - 'a']++;
            }
            if (checkMatch(records, reference)) answer.Add(0);

            for(int j = p.Length; j < s.Length; j++)
            {
                records[s[j - p.Length] - 'a']--;
                records[s[j] - 'a']++;

                if (checkMatch(records, reference))
                {
                    answer.Add(j - p.Length+1);
                }

            }
            return answer;
        }

        public bool checkMatch(int[] arr1, int[] arr2)
        {
            for(int i =0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}
