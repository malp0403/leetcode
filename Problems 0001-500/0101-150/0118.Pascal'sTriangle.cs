using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0118
    {
        #region LeetCode Solution1: Dynamic Programming
        public IList<IList<int>> Generate_DP(int numRows)
        {
            IList<IList<int>> ans = new List<IList<int>>() { };
            if(numRows ==1)
            {
                ans.Add(new List<int>() {1 });
                return ans;
            }
            ans.Add(new List<int>() { 1 });
            int i = 1;
            while (i < numRows)
            {
                IList<int> temp = new List<int>() { };
                IList<int> prev = ans[ans.Count - 1];

                temp.Add(1);
                for(int j = 1; j < i; j++)
                {
                    temp.Add(prev[j-1] + prev[j]);
                }
                temp.Add(1);

                i++;
                ans.Add(temp);
            }
            return ans;
        }

        #endregion

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

        #region 12/28/2022
        public IList<IList<int>> Generate_20221228(int numRows)
        {
            IList<IList<int>> ans = new List<IList<int>>() { };
            if(numRows == 1)
            {
                ans.Add(new List<int>() {1 });
            }else if(numRows == 2)
            {
                ans.Add(new List<int>() { 1 });
                ans.Add(new List<int>() { 1, 1, });
            }
            else
            {
                ans.Add(new List<int>() { 1 });
                ans.Add(new List<int>() { 1, 1, });
                for (int i =3; i <= numRows; i++)
                {
                    List<int> temp = new List<int>() { };
                    IList<int> cur = ans[ans.Count - 1];
                    for (int j=0; j <= cur.Count; j++)
                    {
                        if(j==0 || j == cur.Count)
                        {
                            temp.Add(1);
                        }
                        else
                        {
                            temp.Add(cur[j - 1] + cur[j]);
                        }
                    }
                    ans.Add(temp);
                }
            }
            return ans;
        }
        #endregion
    }
}
