using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given a string s. Return all the words vertically in the same order in which they appear in s.
Words are returned as a list of strings, complete with spaces when is necessary. (Trailing spaces are not allowed).
Each word would be put on only one column and that in one column there will be only one word.

 

Example 1:

Input: s = "HOW ARE YOU"
Output: ["HAY","ORO","WEU"]
Explanation: Each word is printed vertically. 
 "HAY"
 "ORO"
 "WEU"
Example 2:

Input: s = "TO BE OR NOT TO BE"
Output: ["TBONTB","OEROOE","   T"]
Explanation: Trailing spaces is not allowed. 
"TBONTB"
"OEROOE"
"   T"
Example 3:

Input: s = "CONTEST IS COMING"
Output: ["CIC","OSO","N M","T I","E N","S G","T"]
 

Constraints:

1 <= s.length <= 200
s contains only upper case English letters.
It's guaranteed that there is only one space between 2 words.
It's guaranteed that there is only one space between 2 words.
 */
#endregion

#region TEST
/*
             var obj = new _1324();
            obj.PrintVertically("TO BE OR NOT TO BE");
 */
#endregion

namespace leetcode.Problems_1001_1500._1301_1350
{
    internal class _1324
    {

        #region 11/04/2023
        public IList<string> PrintVertically_20231104(string s)
        {
            string[] arr = s.Split(" ");
            IList<string> list = new List<string>();
            int start = 0;
             while (true)
            {
                StringBuilder sb = new StringBuilder();
                for(int i=0; i < arr.Length; i++)
                {
                    if (start < arr[i].Length)
                    {
                        sb.Append(arr[i][start]);
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }
                string temp = sb.ToString().TrimEnd();
                if (temp.Length == 0) break;
                list.Add(temp);
                start++;
            }
            return list;


        }
        #endregion
    }
}
