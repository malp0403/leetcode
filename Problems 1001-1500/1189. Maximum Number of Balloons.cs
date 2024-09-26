using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region examples
/*
 Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.

 

Example 1:



Input: text = "nlaebolko"
Output: 1
Example 2:



Input: text = "loonbalxballpoon"
Output: 2
Example 3:

Input: text = "leetcode"
Output: 0
 

Constraints:

1 <= text.length <= 104
text consists of lower case English letters only.
 */
#endregion
namespace leetcode.Problems_1001_1500._1151_1200
{
    internal class _1189
    {
        #region 11/05/2023
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char,int> dic = new Dictionary<char, int>();
            dic.Add('b', 0);
            dic.Add('a', 0);
            dic.Add('l', 0);
            dic.Add('o', 0);
            dic.Add('n', 0);



            foreach (char c in text)
            {
                if (c == 'b' || c == 'a' || c == 'l' || c == 'o' || c == 'n')
                {
                    dic[c]++;
                }
            }
            int answer = int.MaxValue;
            foreach (var k in dic.Keys)
            {
                if(k == 'b' || k == 'a' ||  k== 'n')
                {
                    answer = Math.Min(answer, dic[k]);
                }
                else
                {
                    answer = Math.Min(answer, dic[k] / 2);
                }
            }
            return answer != int.MinValue ? answer : 0;
        }
        #endregion
    }
}
