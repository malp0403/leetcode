using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0118
    {
        #region answer
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> answer = new List<IList<int>>() { };
            if (numRows == 1)
            {
                answer.Add(new List<int>() { 1 });
                return answer;
            }
            else if (numRows == 2)
            {
                answer.Add(new List<int>() { 1 });
                answer.Add(new List<int>() { 1, 1 });
                return answer;
            }
            else
            {
                answer.Add(new List<int>() { 1 });
                answer.Add(new List<int>() { 1, 1 });
                for (int i = 2; i < numRows; i++)
                {
                    List<int> list = new List<int>() { };
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            list.Add(1);
                        }
                        else
                        {
                            list.Add(answer[i - 1][j - 1] + answer[i - 1][j]);
                        }
                    }
                    answer.Add(list);
                }
            }
            return answer;
        }
        #endregion
        #region 08/17/2022
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> answer = new List<int>() { };
            if (rowIndex == 1)
            {
                answer.Add(1);
                return answer;
            }
            else if (rowIndex == 2)
            {
                answer.Add(1);
                answer.Add(1);
                return answer;
            }
            else
            {
                answer.Add(1);
                answer.Add(1);
                for (int i = 2; i < rowIndex; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            continue;
                        }
                        else if (j == i)
                        {
                            answer.Add(1);
                        }
                        else
                        {
                            answer[i] = answer[i - 1] + answer[i];
                        }
                    }
                }
                return answer;
            }
        }
        #endregion
    }
}
