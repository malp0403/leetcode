using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0225
    {
        #region 07/07/2024
        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        public _0225()
        {

        }

        public void Push(int x)
        {
            queue1.Enqueue(x);
        }

        public int Pop()
        {
            while(queue1.Count >= 2)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            int answer = queue1.Dequeue();

            queue1 = queue2;
            queue2 = new Queue<int>();


            return answer;
        }

        public int Top()
        {
            while (queue1.Count >= 2)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            int answer = queue1.Dequeue();

            queue2.Enqueue(answer);

            queue1 = queue2;
            queue2 = new Queue<int>();


            return answer;
        }

        public bool Empty()
        {
            return queue1.Count == 0;
        }
        
        #endregion
    }
}
