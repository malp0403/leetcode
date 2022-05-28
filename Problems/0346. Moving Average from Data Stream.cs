using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0346
    {
        Queue<int> memo = new Queue<int>() { };
        double sum = 0;
        int _size;
        public _0346(int size)
        {
            _size = size;
        }

        public double Next(int val)
        {
            if (memo.Count >= _size) {
                var num = memo.Dequeue();
                sum -= num;
            }
            
            sum += val;
            memo.Enqueue(val);
            return sum / memo.Count;
        }
    }
}
