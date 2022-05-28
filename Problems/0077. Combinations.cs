using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0077
    {
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
    }
}
