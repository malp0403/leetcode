using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            int[] arr1 = Enumerable.Repeat(0, 26).ToArray();
            int[] arr2 = Enumerable.Repeat(0, 26).ToArray();

            for (int i=0; i < s1.Length; i++)
            {
                arr1[s1[i] - 'a']++;
                arr2[s2[i] - 'a']++;
            }

            for(int j=0; j < s2.Length - s1.Length; j++)
            {
                if (isMatch(arr1, arr2)) return true;
                arr2[s2[j] - 'a']--;
                arr2[s2[j + s1.Length] - 'a']++;
            }
            return isMatch(arr1,arr2);
        }
        public bool isMatch(int[] a1, int[] a2)
        {
            for(int i = 0; i < 26; i++)
            {
                if (a1[i] != a2[i]) return false;
            }
            return true;
        }
    }
}
