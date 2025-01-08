using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 You are given a 0-indexed string s that you must perform k replacement operations on. The replacement operations are given as three 0-indexed parallel arrays, indices, sources, and targets, all of length k.

To complete the ith replacement operation:

Check if the substring sources[i] occurs at index indices[i] in the original string s.
If it does not occur, do nothing.
Otherwise if it does occur, replace that substring with targets[i].
For example, if s = "abcd", indices[i] = 0, sources[i] = "ab", and targets[i] = "eee", then the result of this replacement will be "eeecd".

All replacement operations must occur simultaneously, meaning the replacement operations should not affect the indexing of each other. The testcases will be generated such that the replacements will not overlap.

For example, a testcase with s = "abc", indices = [0, 1], and sources = ["ab","bc"] will not be generated because the "ab" and "bc" replacements overlap.
Return the resulting string after performing all replacement operations on s.

A substring is a contiguous sequence of characters in a string.

 

Example 1:


Input: s = "abcd", indices = [0, 2], sources = ["a", "cd"], targets = ["eee", "ffff"]
Output: "eeebffff"
Explanation:
"a" occurs at index 0 in s, so we replace it with "eee".
"cd" occurs at index 2 in s, so we replace it with "ffff".
Example 2:


Input: s = "abcd", indices = [0, 2], sources = ["ab","ec"], targets = ["eee","ffff"]
Output: "eeecd"
Explanation:
"ab" occurs at index 0 in s, so we replace it with "eee".
"ec" does not occur at index 2 in s, so we do nothing.
 

Constraints:

1 <= s.length <= 1000
k == indices.length == sources.length == targets.length
1 <= k <= 100
0 <= indexes[i] < s.length
1 <= sources[i].length, targets[i].length <= 50
s consists of only lowercase English letters.
sources[i] and targets[i] consist of only lowercase English letters.
 */
#endregion

#region Test
/*
             var obj = new _0833();
            obj.FindReplaceString_2023_12_10("vmokgggqzp", new int[] { 3,5,1 }, new string[] { "kg", "ggq" ,"mo"}, new string[] { "s", "so","bfr" });
            obj.FindReplaceString_2023_12_10("abcd",new int[] {0,2},new string[] {"a","cd"},new string[] {"eee","ffff" });
            

 */
#endregion

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0833
    {


        #region 12/10/2023  Sort indice, Map all indices
        public string FindReplaceString_2023_12_10(string s, int[] indices, string[] sources, string[] targets)
        {
            Dictionary<int, List<(string source, string target)>> dic = new Dictionary<int, List<(string source, string target)>>();

            for(int i =0; i < indices.Length; i++)
            {
                if (dic.ContainsKey(indices[i]))
                {
                    dic[indices[i]].Add((sources[i], targets[i]));
                }
                else
                {
                    dic.Add(indices[i], new List<(string source, string target)>() { (sources[i], targets[i]) });
                }
            }
            Array.Sort(indices);


            int start = 0;
            int index = 0;
            StringBuilder sb = new StringBuilder();
            while(start < s.Length)
            {
                while(index < indices.Length &&   start < indices[index] )
                {
                    sb.Append(s[start]);
                    start++;
                }
                if (index >= indices.Length) break;
                //replace
                foreach(var ele in dic[indices[index]])
                {
                    if ( start + ele.source.Length <=s.Length &&   s.Substring(start, ele.source.Length) == ele.source)
                    {
                        sb.Append(ele.target);
                        start += ele.source.Length;
                        break;
                    }
                }

         
                index++;
            }

            for(int i = start;i < s.Length; i++)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();

        }
        #endregion
    }
}
