using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0187
    {
        #region 06/11/2024
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> result = new HashSet<string>();
            HashSet<string> seen = new HashSet<string>();

            StringBuilder sb = new StringBuilder();

            for(int i =0; i < s.Length; i++)
            {
                if(sb.Length >= 10)
                {
                    sb.Remove(0, 1);
                }
          
                    sb.Append(s[i]);

                if (seen.Contains(sb.ToString()))
                {
                    result.Add(sb.ToString());
                }
                else
                {
                    seen.Add(sb.ToString());
                }
                


            }

            return result.ToList();
        }
        #endregion
    }
}
