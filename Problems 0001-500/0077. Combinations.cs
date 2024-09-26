using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0077
    {
        #region answer
        List<int> list = new List<int>() { };
        IList<IList<int>> answer = new List<IList<int>>() { };
        int _k;
        int _n;
        public IList<IList<int>> Combine(int n, int k)
        {
            _k = k; _n = n;
            BT(1);
            return answer;
        }
        public void BT(int start)
        {
            if(list.Count == _k)
            {
                answer.Add(new List<int>(list));
            }
            for( int i= start; i <= _n; i++)
            {
                list.Add(i);
                BT(i + 1);
                list.RemoveAt(list.Count - 1);
            }
        }
        #endregion

        #region 01/11/2022
        //01-11-2022--------------------------------------
        public IList<IList<int>> Combine_R2(int n,int k)
        {
            BackTracking_R2(1, n, k, new List<int>() { });
            return answer;
        }

        public void BackTracking_R2(int start,int n,int k,List<int> list)
        {
            if (list.Count == k)
            {
                answer.Add(new List<int>(list));
                return;
            }
            for (int i = start; i <= n; i++)
            {
                list.Add(i);
                BackTracking_R2(i + 1, n, k, list);
                list.RemoveAt(list.Count - 1);
            }
        }
        #endregion

        #region 08/10/2022
        IList<IList<int>> res = new List<IList<int>>() { };
        public IList<IList<int>> Combine_20220810(int n, int k)
        {
            helper_20220810(n, k,1, new List<int>() { });
            return res;
        }
        public void helper_20220810(int n, int k, int start, List<int> list)
        {
            if (list.Count == k)
            {
                res.Add(list.Select(x => x).ToList());
                return;
            }
            for (int i = start; i <= n; i++)
            {
                list.Add(i);
                helper_20220810(n, k, i + 1, list);
                list.Remove(i);
            }
        }
        #endregion

        #region 03/09/2024 BackTracking
        IList<IList<int>> answer_2024_03_09;
        public IList<IList<int>> Combine_2024_03_09(int n, int k)
        {
            answer_2024_03_09= new List<IList<int>>() { };
           // bool[] chosen = Enumerable.Repeat(false, n).ToArray();

            helper(n,k, Enumerable.Repeat(false, n).ToArray(), new List<int>() { },0);

            return answer_2024_03_09;
        }
        public void helper(int n, int k, bool[] chosen,List<int> curList,int startindex)
        {
            if(curList.Count == k)
            {
                answer_2024_03_09.Add(new List<int>(curList)); return;
            }
             for(int i = startindex; i < chosen.Length; i++)
            {
                if (!chosen[i])
                {
                    chosen[i] = true;
                    curList.Add(i+1);
                    helper(n, k, chosen, curList,i+1);
                    curList.RemoveAt(curList.Count - 1);
                    chosen[i] = false;
                }
            }

        }
        #endregion
    }
}
