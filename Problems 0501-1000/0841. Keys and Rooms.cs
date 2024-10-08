﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 There are n rooms labeled from 0 to n - 1 and all the rooms are locked except for room 0. Your goal is to visit all the rooms. However, you cannot enter a locked room without having its key.

When you visit a room, you may find a set of distinct keys in it. Each key has a number on it, denoting which room it unlocks, and you can take all of them with you to unlock the other rooms.

Given an array rooms where rooms[i] is the set of keys that you can obtain if you visited room i, return true if you can visit all the rooms, or false otherwise.

 

Example 1:

Input: rooms = [[1],[2],[3],[]]
Output: true
Explanation: 
We visit room 0 and pick up key 1.
We then visit room 1 and pick up key 2.
We then visit room 2 and pick up key 3.
We then visit room 3.
Since we were able to visit every room, we return true.
Example 2:

Input: rooms = [[1,3],[3,0,1],[2],[0]]
Output: false
Explanation: We can not enter room number 2 since the only key that unlocks it is in that room.
 

Constraints:

n == rooms.length
2 <= n <= 1000
0 <= rooms[i].length <= 1000
1 <= sum(rooms[i].length) <= 3000
0 <= rooms[i][j] < n
All the values of rooms[i] are unique.
 */
#endregion

namespace leetcode.Problems_0501_1000._0801_0850
{
    internal class _0841
    {
        #region 12/10/2023   Approach #1: Depth-First Search  Using Array to check visited
        public bool CanVisitAllRooms_2023_12_10(IList<IList<int>> rooms)
        {
            //no room
            if (rooms.Count == 0) return false;
            //room 0 doesnt have any keys
            if (rooms[0].Count == 0) return false;
            Queue<int> queue = new Queue<int>();
            bool[] visited = Enumerable.Repeat(false, rooms.Count).ToArray();

            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                int r = queue.Dequeue();
                visited[r] = true;
                foreach (var item in rooms[r])
                {
                    if (!visited[item])
                    {
                        queue.Enqueue(item);
                    }
                }

            }

            foreach (var item in visited)
            {

                if (!item) return false;
            }

            return true;

        }
        #endregion  

        #region 09/26/2024 using hashSet to check visited 
        public bool CanVisitAllRooms_2024_09_26(IList<IList<int>> rooms)
        {
            if (rooms.Count <= 1) return true;

            HashSet<int> keys = new HashSet<int>();
            HashSet<int> visitedRooms = new HashSet<int>();
            foreach (var item in rooms[0])
            {
                keys.Add(item);
            }
            visitedRooms.Add(0);

            while (keys.Count > 0)
            {
                HashSet<int> newKeys = new HashSet<int>();
                foreach (var key in keys) {

                    visitedRooms.Add(key);
                    foreach (var ro in rooms[key])
                    {
                        if (!visitedRooms.Contains(ro))
                        {
                            newKeys.Add(ro);
                        }
                    }


                }

                keys = newKeys;

            }

            return visitedRooms.Count == rooms.Count;

        }
        #endregion
    }
}
