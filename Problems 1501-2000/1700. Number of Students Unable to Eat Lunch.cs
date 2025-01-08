using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Example
/*
 The school cafeteria offers circular and square sandwiches at lunch break, referred to by numbers 0 and 1 respectively. All students stand in a queue. Each student either prefers square or circular sandwiches.

The number of sandwiches in the cafeteria is equal to the number of students. The sandwiches are placed in a stack. At each step:

If the student at the front of the queue prefers the sandwich on the top of the stack, they will take it and leave the queue.
Otherwise, they will leave it and go to the queue's end.
This continues until none of the queue students want to take the top sandwich and are thus unable to eat.

You are given two integer arrays students and sandwiches where sandwiches[i] is the type of the i​​​​​​th sandwich in the stack (i = 0 is the top of the stack) and students[j] is the preference of the j​​​​​​th student in the initial queue (j = 0 is the front of the queue). Return the number of students that are unable to eat.

 

Example 1:

Input: students = [1,1,0,0], sandwiches = [0,1,0,1]
Output: 0 
Explanation:
- Front student leaves the top sandwich and returns to the end of the line making students = [1,0,0,1].
- Front student leaves the top sandwich and returns to the end of the line making students = [0,0,1,1].
- Front student takes the top sandwich and leaves the line making students = [0,1,1] and sandwiches = [1,0,1].
- Front student leaves the top sandwich and returns to the end of the line making students = [1,1,0].
- Front student takes the top sandwich and leaves the line making students = [1,0] and sandwiches = [0,1].
- Front student leaves the top sandwich and returns to the end of the line making students = [0,1].
- Front student takes the top sandwich and leaves the line making students = [1] and sandwiches = [1].
- Front student takes the top sandwich and leaves the line making students = [] and sandwiches = [].
Hence all students are able to eat.
Example 2:

Input: students = [1,1,1,0,0,1], sandwiches = [1,0,0,0,1,1]
Output: 3
 

Constraints:

1 <= students.length, sandwiches.length <= 100
students.length == sandwiches.length
sandwiches[i] is 0 or 1.
students[i] is 0 or 1.
 */
#endregion

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1700
    {
        #region 10/17/2023 LinkedList
        public int CountStudents(int[] students, int[] sandwiches)
        {
            LinkedList<int> stu = new LinkedList<int>();
            LinkedList<int> san = new LinkedList<int>();

            int zeros = 0;
            int ones = 0;
            int stu_ones = 0;
            int stu_zeros = 0;
            foreach (var item in students)
            {
                stu.AddLast(item);
                if (item == 1)
                {
                    stu_ones++;
                }
                else
                {
                    stu_zeros++;
                }
            }
            foreach (var item in sandwiches)
            {
                san.AddLast(item);
                if (item == 0) zeros++;
                else ones++;
            }

            while (stu.Count > 0)
            {
                if (stu.First.Value == san.First.Value)
                {
                    if (stu.First.Value == 1)
                    {
                        ones--;
                        stu_ones--;
                    }
                    else
                    {
                        zeros--;
                        stu_zeros--;
                    }
                    stu.RemoveFirst();
                    san.RemoveFirst();
                }
                else
                {
                    if ((san.First.Value == 1 && stu_ones == 0) || (san.First.Value == 0 && stu_zeros == 0))
                    {
                        return stu.Count;
                    }
                    stu.AddLast(stu.First.Value);
                    stu.RemoveFirst();

                }

            }

            return 0;

        }
        #endregion
    }
}
