using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question
/*
 Given an array of strings words, return true if it forms a valid word square.

A sequence of strings forms a valid word square if the kth row and column read the same string, where 0 <= k < max(numRows, numColumns).

 

Example 1:


Input: words = ["abcd","bnrt","crmy","dtye"]
Output: true
Explanation:
The 1st row and 1st column both read "abcd".
The 2nd row and 2nd column both read "bnrt".
The 3rd row and 3rd column both read "crmy".
The 4th row and 4th column both read "dtye".
Therefore, it is a valid word square.
Example 2:


Input: words = ["abcd","bnrt","crm","dt"]
Output: true
Explanation:
The 1st row and 1st column both read "abcd".
The 2nd row and 2nd column both read "bnrt".
The 3rd row and 3rd column both read "crm".
The 4th row and 4th column both read "dt".
Therefore, it is a valid word square.
Example 3:


Input: words = ["ball","area","read","lady"]
Output: false
Explanation:
The 3rd row reads "read" while the 3rd column reads "lead".
Therefore, it is NOT a valid word square.
 

Constraints:

1 <= words.length <= 500
1 <= words[i].length <= 500
words[i] consists of only lowercase English letters.
 */
#endregion

#region Test
/*
            var obj = new _0422();
            var res = obj.ValidWordSquare_app2(new List<string>{
                "abc","b"
            });
*/
#endregion
namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0422
    {

        #region Approach 2: Iterate on the Matrix 09/10/2024
        public bool ValidWordSquare_app2(IList<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {

                     if(j >= words.Count||  i >= words[j].Length ||
                        words[i][j] != words[j][i])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        #endregion

        #region 09/10/2024
        public bool ValidWordSquare_2024_09_10(IList<string> words)
        {
            for(int i =0; i < words.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for(int j =0; j < words.Count; j++)
                {
                    if(i < words[j].Length)
                    {
                        sb.Append(words[j][i]);
                    }
                }

                if (words[i] != sb.ToString()) return false;
            }
            return true;
        }

        #endregion
    }
}
