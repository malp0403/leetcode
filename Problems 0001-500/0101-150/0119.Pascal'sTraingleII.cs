using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0119
    {
        #region solution1
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> answer = new List<int>() { };
            if (rowIndex == 0)
            {
                answer.Add(1);
                return answer;
            }
            else if (rowIndex == 1)
            {
                answer.Add(1);
                answer.Add(1);
                return answer;
            }
            else
            {
                answer.Add(1);
                answer.Add(1);
                for (int i = 2; i <= rowIndex; i++)
                {
                    List<int> cur = new List<int>() { };
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            cur.Add(1);
                        }
                        else
                        {
                            cur.Add(answer[j - 1] + answer[j]);

                        }
                    }
                    answer = cur;
                }
                return answer;
            }
        }
        #endregion
        #region solution2 Backwards
        public IList<int> GetRow_v2(int rowIndex)
        {
            IList<int> answer = new List<int>() { 1};

            for(int i =0; i < rowIndex; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    answer[j] = answer[j] + answer[j - 1];
                }
                answer.Add(1);

            }


            return answer;
        }
        #endregion
    }
}
