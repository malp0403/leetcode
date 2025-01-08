using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0386
    {
        #region 09/03/2024
        IList<int> answer;
        int _n;
        public IList<int> LexicalOrder(int n)
        {
            answer= new List<int>();
            _n =n;
            helper(0);
            return answer;
        }

        public void helper(int val)
        {
            if (val > _n) return;
            if(val != 0)
            {
                answer.Add(val);
            }

            for(int i =0; i < 10; i++)
            {
                if (val == 0 && i == 0) continue;
                helper(val * 10 + i);
            }
        }


        #endregion
    }
}
