using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question
/*
 Given a rows x cols screen and a sentence represented as a list of strings, return the number of times the given sentence can be fitted on the screen.

The order of words in the sentence must remain unchanged, and a word cannot be split into two lines. A single space must separate two consecutive words in a line.

 

Example 1:

Input: sentence = ["hello","world"], rows = 2, cols = 8
Output: 1
Explanation:
hello---
world---
The character '-' signifies an empty space on the screen.
Example 2:

Input: sentence = ["a", "bcd", "e"], rows = 3, cols = 6
Output: 2
Explanation:
a-bcd- 
e-a---
bcd-e-
The character '-' signifies an empty space on the screen.
Example 3:

Input: sentence = ["i","had","apple","pie"], rows = 4, cols = 5
Output: 1
Explanation:
i-had
apple
pie-i
had--
The character '-' signifies an empty space on the screen.
 

Constraints:

1 <= sentence.length <= 100
1 <= sentence[i].length <= 10
sentence[i] consists of lowercase English letters.
1 <= rows, cols <= 2 * 104
 */
#endregion

#region Test
/*
 
 */
#endregion
namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0418
    {
        #region 09/05/2024
        public int WordsTyping(string[] sentence, int rows, int cols)
        {
            int index = 0;
            int curRow = 0;
            int count = 0;
            List<string> list = new List<string>();
            while(curRow < rows)
            {
                string s = "";
                while(s.Length <cols && (s.Length +  (s.Length==0?0:1) + sentence[index].Length) <= cols)
                {
                    s = s+ (s==""?"":"-") + sentence[index];
                    index += 1;
                    
                    if(index == sentence.Length)
                    {
                        index = 0;
                        count++;
                    }
                }

                while(s.Length < cols)
                {
                    s += "-";
                }
                list.Add(s);
                curRow++;
            }

            return count;
        }
        #endregion
    }
}
