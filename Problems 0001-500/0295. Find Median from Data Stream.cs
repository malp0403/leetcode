using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Case
/*
             var obj = new _0295();
            obj.AddNum(40);
            var test1 = obj.FindMedian();
            obj.AddNum(12);
             test1 = obj.FindMedian();
            obj.AddNum(16);
            test1 = obj.FindMedian();
            obj.AddNum(-4);
            test1 = obj.FindMedian();
            obj.AddNum(-5);
            test1 = obj.FindMedian();
            Console.Write("123");
        }
 */
#endregion

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0295
    {
        #region 07/15/2024 PriorityQueue
        //PriorityQueue<int, int> q1 = new PriorityQueue<int, int>();
        //            PriorityQueue<int, int> q2 = new PriorityQueue<int, int>();

        //public _0295()
        //{
           
        //}

        //public void AddNum(int num)
        //{
        //    if (q1.Count == 0)
        //    {
        //        q1.Enqueue(num, -num);
        //    }else if (q2.Count == 0)
        //    {
        //        int val = q1.Peek();
        //        if(num >= val)
        //        {
        //            q2.Enqueue(num, num);
        //        }
        //        else
        //        {
        //            q1.Dequeue();
        //            q2.Enqueue(val, val);
        //            q1.Enqueue(num, -num);
        //        }
        //    }else
        //    {
        //        if (q1.Count == q2.Count)
        //        {
                  
        //                if(num <= q2.Peek())
        //                {
        //                    q1.Enqueue(num, -num);
        //                }
        //                else
        //                {
        //                    int val = q2.Dequeue();
        //                    q1.Enqueue(val, -val);
        //                    q2.Enqueue(num, num);
        //                }
                
                    
        //        }
        //        else
        //        {

        //            if(num >= q1.Peek())
        //            {
        //                q2.Enqueue(num, num);
        //            }
        //            else
        //            {
        //                    int val = q1.Dequeue();
        //                    q2.Enqueue(val, val);
        //                    q1.Enqueue(num, -num);
                        
        //            }

        //        }
        //    }

         
        //}

        //public double FindMedian()
        //{
        //    if (q1.Count > q2.Count) return q1.Peek();

        //    return (q1.Peek() + q2.Peek()) / 2.0;
        //}

        
        #endregion


    }
}
