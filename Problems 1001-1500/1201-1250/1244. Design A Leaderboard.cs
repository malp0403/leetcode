using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1244
    {
        Dictionary<int, int> dic ;
        public _1244()
        {
            dic = new Dictionary<int, int>() { };
        }

        public void AddScore(int playerId, int score)
        {
            if (!dic.ContainsKey(playerId)) dic.Add(playerId, score);
            else dic[playerId] += score;
        }

        public int Top(int K)
        {
            List<int> list = dic.Values.ToList();
            list.Sort((x, y) => { return y - x; });
            int sum = list.Where((x, indx) => { return indx <= K - 1; }).Sum(x => x);
            return sum;
        }

        public void Reset(int playerId)
        {
            dic.Remove(playerId);
        }
    }
}
