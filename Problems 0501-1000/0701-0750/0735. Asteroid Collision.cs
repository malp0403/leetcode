using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Question
/*
 We are given an array asteroids of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.

 

Example 1:

Input: asteroids = [5,10,-5]
Output: [5,10]
Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never collide.
Example 2:

Input: asteroids = [8,-8]
Output: []
Explanation: The 8 and -8 collide exploding each other.
Example 3:

Input: asteroids = [10,2,-5]
Output: [10]
Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.
 

Constraints:

2 <= asteroids.length <= 104
-1000 <= asteroids[i] <= 1000
asteroids[i] != 0
 */
#endregion
namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0735
    {
        #region 09/12/2023
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

        #region 09/17/2024 Stack 
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var item in asteroids)
            {
                if(stack.Count ==0 || Math.Sign(item) == Math.Sign(stack.Peek()) || (
                    Math.Sign(item) == 1 && Math.Sign(stack.Peek())==-1
                    ))
                {
                    stack.Push(item);
                }
                else
                {
                    while(stack.Count >0 && stack.Peek() >0 && stack.Peek() < Math.Abs(item))
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0 || stack.Peek() <0) stack.Push(item);
                    else if(stack.Peek() == Math.Abs(item))
                    {
                        stack.Pop();
                    }
                }
            }

            List<int> answer = new List<int>();
            while(stack.Count > 0)
            {
                answer.Add(stack.Pop());
            }
            answer.Reverse();
            return answer.ToArray();

        }
        #endregion

    }
}
