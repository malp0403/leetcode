using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0271
    {
        #region 07/11/2024
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            string split = "π";
            return string.Join(split, strs);
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            return s.Split("π").ToList();
        }
        #endregion
    }
}
