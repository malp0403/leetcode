using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500._2001_2050
{
    internal class _2034
    {

        #region 10/09/2023 2 PriorityQueue
        //Dictionary<int, int> dic;
        //PriorityQueue<(int, int), int> minque;
        //PriorityQueue<(int, int), int> maxque;

        //int lastest = 0;
        //public _2034()
        //{
        //    dic = new Dictionary<int, int>();
        //    minque = new PriorityQueue<(int t, int p), int>();
        //    maxque = new PriorityQueue<(int t, int p), int>();

        //}

        //public void Update(int timestamp, int price)
        //{

        //    if (dic.ContainsKey(timestamp))
        //    {
        //        dic[timestamp] = price;

        //    }
        //    else
        //    {
        //        dic.Add(timestamp, price);
        //    }


        //    lastest = Math.Max(lastest, timestamp);

        //    minque.Enqueue((timestamp, price), price);
        //    maxque.Enqueue((timestamp, price), -price);

        //    while (maxque.Count > 0)
        //    {
        //        var item = maxque.Peek();

        //        if (dic[item.Item1] == item.Item2) break;
        //        maxque.Dequeue();
        //    }
        //    while (minque.Count > 0)
        //    {
        //        var item = minque.Peek();

        //        if (dic[item.Item1] == item.Item2) break;
        //        minque.Dequeue();
        //    }


        //}

        //public int Current()
        //{
        //    return dic[lastest];
        //}

        //public int Maximum()
        //{

        //    return maxque.Peek().Item2;
        //}

        //public int Minimum()
        //{
        //    return minque.Peek().Item2;
        //}
        #endregion

    }
}
