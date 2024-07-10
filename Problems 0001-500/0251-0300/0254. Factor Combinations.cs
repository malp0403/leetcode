using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0254
    {
        #region 07/08/2024
        IList<IList<int>> answer = new List<IList<int>>();
        public IList<IList<int>> GetFactors(int n)
        {
            if (n == 1) return answer;
            backTracking(n, new List<int>() { }, false,2);
            return answer;
        }
        public void backTracking(int n,List<int> curList,bool isInclusive,int smallest)
        {
            if (n == 1)
            {
                answer.Add(curList.ToList());
                return;
            }

            for(int i = smallest; i <= (isInclusive?n:n-1); i++)
            {
                if(n%i == 0)
                {
                    curList.Add(i);

                    backTracking(n / i, curList,true,i);
                    curList.RemoveAt(curList.Count - 1);
                }
            }
            

        }
        #endregion
    }
}
