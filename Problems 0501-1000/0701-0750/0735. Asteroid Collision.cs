using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0735
    {
        #region 20230912
        public int[] AsteroidCollision_20230912(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int asteroid in asteroids)
            {
                bool flag = true;
                if (stack.Count > 0 && asteroid < 0)
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                        flag = false;
                    }

                    if (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() > Math.Abs(asteroid))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    stack.Push(asteroid);
                }

            }

            List<int> list = new List<int>();
            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }

            list.Reverse();

            return list.ToArray();
        }
        #endregion

    }
}
