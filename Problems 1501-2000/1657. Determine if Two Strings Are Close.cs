using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Question
/*
 Two strings are considered close if you can attain one from the other using the following operations:

Operation 1: Swap any two existing characters.
For example, abcde -> aecdb
Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
You can use the operations on either string as many times as necessary.

Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.

 

Example 1:

Input: word1 = "abc", word2 = "bca"
Output: true
Explanation: You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -> "acb"
Apply Operation 1: "acb" -> "bca"
Example 2:

Input: word1 = "a", word2 = "aa"
Output: false
Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
Example 3:

Input: word1 = "cabbba", word2 = "abbccc"
Output: true
Explanation: You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -> "caabbb"
Apply Operation 2: "caabbb" -> "baaccc"
Apply Operation 2: "baaccc" -> "abbccc"
 

Constraints:

1 <= word1.length, word2.length <= 105
word1 and word2 contain only lowercase English letters.
 */
#endregion
namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1657
    {
        #region 09/17/2024  1. same char set 2. same frequence set
        public bool CloseStrings(string word1, string word2)
        {
            HashSet<char> set1 = new HashSet<char>();
            HashSet<char> set2 = new HashSet<char>();
            Dictionary<char,int> dic1 = new Dictionary<char,int>();
            Dictionary<char,int > dic2 = new Dictionary<char,int>();

            foreach (var i in word1)
            {
                set1.Add(i);
                if (dic1.ContainsKey(i))
                {
                    dic1[i]++;
                }
                else
                {
                    dic1.Add(i, 1);
                }
            }

            foreach (var i in word2)
            {
                set2.Add(i);
                if (dic2.ContainsKey(i))
                {
                    dic2[i]++;
                }
                else
                {
                    dic2.Add(i, 1);
                }
            }

            if (set1.Count != set2.Count) return false;

            foreach (var item in set1)
            {
                if (!set2.Contains(item)) return false;
            }

            var list1 = new List<int>();
            var list2 = new List<int>();

            foreach (var item in dic1.Keys)
            {
                list1.Add(dic1[item]);
                list2.Add(dic2[item]);
            }

            list1.Sort(); list2.Sort();

            for(int i =0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i]) return false;
            }

            return true;
        }
        #endregion
    }
}
