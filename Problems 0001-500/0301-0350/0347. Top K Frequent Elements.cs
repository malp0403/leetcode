using leetcode.Problems_0001_500._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj2 = new _0347() { };
//obj2.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
#endregion

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0347
    {
        #region 09/05/2023  My Attempt with LinkedList
        public int[] TopKFrequent_20230905_linkedList(int[] nums, int k)
        {
            SortedDictionary<int,int> dic = new SortedDictionary<int,int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }
            LinkedList<(int value,int count)> list = new LinkedList<(int value, int count)>();    
            foreach (int num in dic.Keys)
            {

                if(list.Count < k)
                {
                    LinkedList<(int value, int count)> tempList = new LinkedList<(int value, int count)>();
                    while(list.Count>0 && dic[num] > list.Last.Value.count)
                    {
                        tempList.AddLast(list.Last.Value);
                        list.RemoveLast();
                    }
                    list.AddLast((num, dic[num]));
                    while(tempList.Count > 0)
                    {
                        list.AddLast(tempList.Last.Value);
                        tempList.RemoveLast();
                    }
                }
                else
                {
                    if (dic[num] <= list.Last.Value.count) continue;
                    if(dic[num] > list.First.Value.count)
                    {
                        list.AddFirst((num, dic[num]));
                        list.RemoveLast();
                    }
                    else
                    {
                        LinkedList<(int value, int count)> tempList = new LinkedList<(int value, int count)>();
                        while (list.Count > 0 && dic[num] > list.Last.Value.count)
                        {
                            tempList.AddLast(list.Last.Value);
                            list.RemoveLast();
                        }
                        list.AddLast((num, dic[num]));
                        while (tempList.Count > 1)
                        {
                            list.AddLast(tempList.Last.Value);
                            tempList.RemoveLast();
                        }

                    }
                }
            }

            List<int> result = new List<int>();
            while(list.Count > 0)
            {
                result.Add(list.First.Value.value);
                list.RemoveFirst();
            }

            return result.ToArray();
        }
        #endregion

        #region 09/05/2023 Mu Attemp with Priority Queue
        public int[] TopKFrequent_heap(int[] nums, int k)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            PriorityQueue<int, int> q = new PriorityQueue<int, int>() { };
            foreach (var item in dic.Keys)
            {
                if(q.Count < k)
                {
                    q.Enqueue(item, dic[item]);
                }
                else
                {
                    if (dic[q.Peek()] >= dic[item]) continue;
                    q.Dequeue();
                    q.Enqueue(item, dic[item]);
                }
            }

            List<int> result = new List<int>() { };
            while (q.Count > 0)
            {
                result.Add(q.Dequeue());
            }
            return result.ToArray();

        }
        #endregion

        #region 08/31/2024 Priority Queue
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> countDic = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!countDic.ContainsKey(num))
                {
                    countDic.Add(num, 1);
                }
                else
                {
                    countDic[num]++;
                }
            }
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>() { };
            foreach (var item in countDic.Keys)
            {
                queue.Enqueue(item, -countDic[item]);
            }

            List<int> list = new List<int> { };
            while (k > 0 && queue.Count > 0)
            {
                list.Add(queue.Dequeue());
                k--;
            }
            return list.ToArray();
        }
        #endregion

    }
}
