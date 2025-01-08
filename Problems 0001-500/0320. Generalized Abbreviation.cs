using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0320
    {
        #region 07/23/2024
        IList<string> answer_2024_07_22;
        public IList<string> GenerateAbbreviations(string word)
        {
            answer_2024_07_22 = new List<string>();
            dfs(word, 0, "", 0);
            return answer_2024_07_22;
        }

        public void dfs(string word, int index,string sb,int accumulate)
        {
            if (index >= word.Length)
            {
                if(accumulate > 0)
                {
                    answer_2024_07_22.Add(sb.ToString() + accumulate);
                }
                else
                {
                    answer_2024_07_22.Add(sb.ToString());
                }
                return;
            }

            //skip
            dfs(word, index + 1, sb, accumulate + 1);
            //take
            if(accumulate != 0)
            {
              
                dfs(word, index + 1, sb + accumulate+ word[index], 0);
               
            }
            else
            {
                dfs(word, index + 1, sb+ word[index], 0);
            }



        }
        #endregion
    }
}
