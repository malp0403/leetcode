using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0293
    {
        #region 07/15/2024 can only flip "++"
        public IList<string> GeneratePossibleNextMoves(string currentState)
        {
            IList<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            for(int i =0; i < currentState.Length - 1; i++)
            {
                if (currentState[i] == currentState[i + 1])
                {
                    if (currentState[i] == '+')
                    {
                        list.Add(sb.ToString() + "--" + (i+2 <currentState.Length?currentState.Substring(i + 2):""));
                    }

                }

                sb.Append(currentState[i]);
            }
            return list;
        }
        #endregion


    }
}
