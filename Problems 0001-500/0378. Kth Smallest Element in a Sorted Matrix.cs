﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
#region Examples
/*
 Given an n x n matrix where each of the rows and columns is sorted in ascending order, return the kth smallest element in the matrix.

Note that it is the kth smallest element in the sorted order, not the kth distinct element.

You must find a solution with a memory complexity better than O(n2).

 

Example 1:

Input: matrix = [[1,5,9],[10,11,13],[12,13,15]], k = 8
Output: 13
Explanation: The elements in the matrix are [1,5,9,10,11,12,13,13,15], and the 8th smallest number is 13
Example 2:

Input: matrix = [[-5]], k = 1
Output: -5
 

Constraints:

n == matrix.length == matrix[i].length
1 <= n <= 300
-109 <= matrix[i][j] <= 109
All the rows and columns of matrix are guaranteed to be sorted in non-decreasing order.
1 <= k <= n2
 

Follow up:

Could you solve the problem with a constant memory (i.e., O(1) memory complexity)?
Could you solve the problem in O(n) time complexity? The solution may be too advanced for an interview but you may find reading this paper fun.
 */
#endregion
namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0378
    {
        #region 11/21/2023
        public int KthSmallest(int[][] matrix, int k)
        {

            Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
            PriorityQueue<int, int> summary_queue = new PriorityQueue<int, int>();
            HashSet<(int r, int c)> visited = new HashSet<(int r, int c)>();
            List<List<int>> directions = new List<List<int>>()
            {
                new List<int>(){0,1},
                new List<int>(){1,0}
            };
            queue.Enqueue((0, 0));
            visited.Add((0, 0));
            summary_queue.Enqueue(matrix[0][0], matrix[0][0]);

            while (queue.Count > 0 || summary_queue.Count < k)
            {
                int count = queue.Count;
                while (count > 0)
                {
                    var element = queue.Dequeue();
                    foreach (var item in directions)
                    {
                        int row = element.r + item[0];
                        int col = element.c + item[1];
                        if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[0].Length || visited.Contains((row, col))) continue;
                        summary_queue.Enqueue(matrix[row][col], matrix[row][col]);
                        queue.Enqueue((row, col));
                        visited.Add((row, col));
                    }
                    count--;
                }

            }
            int ans = 1;
            while (k > 0)
            {
                ans = summary_queue.Dequeue();
                k--;
            }

            return ans;



        }

        public int getCurMaxGroup((int curMax, int i)[] dp)
        {
            int curMax = int.MinValue;
            int index = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                if (dp[i].curMax > curMax)
                {
                    curMax = dp[i].curMax;
                    index = dp[i].i;
                }
            }
            return index;
        }
        #endregion

        #region 09/01/2024
        public int KthSmallest_2024_09_01(int[][] matrix, int k)
        {
            List<List<int>> dir = new List<List<int>>()
            {
                new List<int>(){0,1},
                new List<int>(){1,0}
            };
            PriorityQueue<(int row, int col), int> priorityQueue = new PriorityQueue<(int row, int col), int>();
            HashSet<(int row, int col)> seen = new HashSet<(int row, int col)>();

            Queue<(int row, int col)> queue = new Queue<(int row, int col)>();

            queue.Enqueue((0, 0));
            seen.Add((0, 0));
            priorityQueue.Enqueue((0, 0), matrix[0][0]);
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                foreach (var ele in dir)
                {
                    int r = ele[0] + item.row;
                    int c = ele[1] + item.col;
                    if (r >= matrix.Length || c >= matrix[0].Length || seen.Contains((r, c))) continue;
                    queue.Enqueue((r, c));
                    seen.Add((r, c));
                    priorityQueue.Enqueue((r, c), matrix[r][c]);
                }

            }

            int ans = 1;
            while (k > 0)
            {
                var ele = priorityQueue.Dequeue();
                ans = matrix[ele.row][ele.col];
                k--;
            }

            return ans;


        }
        #endregion

        #region Approach 1: Min-Heap approach 09/01/2024
        public int KthSmallest_app1(int[][] matrix, int k)
        {
            PriorityQueue<(int row, int index), int> priorityQueue = new PriorityQueue<(int row, int index), int>();

            for(int i =0; i < matrix.Length; i++)
            {
                priorityQueue.Enqueue((i, 0), matrix[i][0]);
            }
            int ans = 1;
            while(k > 0)
            {
                var ele = priorityQueue.Dequeue();
                ans = matrix[ele.row][ele.index];

                if(ele.index +1 < matrix[0].Length)
                {
                    priorityQueue.Enqueue((ele.row, ele.index + 1), matrix[ele.row][ele.index+1]);
                }




                k--;



            }

            return ans;

        }
        #endregion  

        #region Approach 2: Binary Search  still cant understand

        #endregion
    }
}
