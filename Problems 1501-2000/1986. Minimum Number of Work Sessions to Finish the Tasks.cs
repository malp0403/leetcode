using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1951_2000
{
    internal class _1986
    {
        #region 10/10/2023 greedy 
        int min = int.MaxValue;

        int[] tasks_20231010;
        int[] rooms_20231010;
        int sessiontTime_20231010;
        public int MinSessions(int[] tasks,int sessionTime)
        {
            tasks_20231010 = tasks; 
            sessiontTime_20231010 = sessionTime;
            rooms_20231010 = Enumerable.Repeat(0,tasks.Length).ToArray();

            //put first task in the first meetings first
            rooms_20231010[0] = tasks[0];
            helper(1, 0);
            return min;
        }

        public void helper(int taskIndex,int lastRoomIndex) {
            if(taskIndex >= tasks_20231010.Length)
            {
                min = Math.Min(min, lastRoomIndex + 1);
                return;
            }
            //put to next room
            rooms_20231010[lastRoomIndex + 1] = tasks_20231010[taskIndex];
            helper(taskIndex+1, lastRoomIndex + 1);
            rooms_20231010[lastRoomIndex + 1] -= tasks_20231010[taskIndex];

            for (int i =0; i <= lastRoomIndex; i++)
            {
                if(rooms_20231010[i] + tasks_20231010[taskIndex] <= sessiontTime_20231010)
                {
                    rooms_20231010[i] += tasks_20231010[taskIndex];
                    helper(taskIndex + 1, lastRoomIndex);
                    rooms_20231010[i] -= tasks_20231010[taskIndex];
                }
            }


        }
        #endregion

        #region 10/10/2023 bitMask && DP; dont understand

        #endregion
    }
}

#region example
/*
 Example 1:

Input: tasks = [1,2,3], sessionTime = 3
Output: 2
Explanation: You can finish the tasks in two work sessions.
- First work session: finish the first and the second tasks in 1 + 2 = 3 hours.
- Second work session: finish the third task in 3 hours.
Example 2:

Input: tasks = [3,1,3,1,1], sessionTime = 8
Output: 2
Explanation: You can finish the tasks in two work sessions.
- First work session: finish all the tasks except the last one in 3 + 1 + 3 + 1 = 8 hours.
- Second work session: finish the last task in 1 hour.
Example 3:

Input: tasks = [1,2,3,4,5], sessionTime = 15
Output: 1
Explanation: You can finish all the tasks in one work session.
 */
#endregion
