using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace leetcode.Problems
{
    class _0346
    {
        #region Approach 1: Array or List

        #endregion

        #region Approach 2: Double-ended Queue

        #endregion
        #region Solution
        //Queue<int> memo = new Queue<int>() { };
        //double sum = 0;
        //int _size;
        //public _0346(int size)
        //{
        //    _size = size;
        //}

        //public double Next(int val)
        //{
        //    if (memo.Count >= _size)
        //    {
        //        var num = memo.Dequeue();
        //        sum -= num;
        //    }

        //    sum += val;
        //    memo.Enqueue(val);
        //    return sum / memo.Count;
        //}
        #endregion

        #region 08/31/2024
        //Queue<int> queue = new Queue<int>() { };
        //double sum = 0;
        //int size = 0;
        //public _0346(int size)
        //{
        //    this.size= size;

        //}

        //public double Next(int val)
        //{
        //    if(queue.Count == this.size)
        //    {
        //        sum -= queue.Dequeue();
        //    }

        //    queue.Enqueue(val);
        //    sum += val;

        //    return sum/queue.Count;
        //}
        #endregion

        #region 10/07/2024
        /*
        int moveIndex = 0;
        List<int> list;
        double total = 0;
        int size = 0;
        public MovingAverage(int size)
        {
            this.size = size;
            list = new List<int>();
        }

        public double Next(int val)
        {
            if (list.Count < size)
            {
                list.Add(val);
            }
            else
            {
                int toMoveValue = list[moveIndex];
                total -= toMoveValue;
                list[moveIndex] = val;

                moveIndex = ((moveIndex + 1) % size);
            }

            total += val;


            return total / list.Count;
        }

            */
        #endregion
    }
}
