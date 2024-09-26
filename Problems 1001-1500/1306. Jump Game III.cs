using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1306
    {
        public bool CanReach(int[] arr, int start)
        {
            HashSet<int> visited = new HashSet<int>() { start};
            if (arr[start] == 0) return true;
            List<int> input = new List<int>() { start };
            while(input.Count > 0)
            {
                List<int> list = new List<int>() { };
                foreach (var item in input)
                {
                    int left = item - arr[item];
                    if(left >=0 && left < arr.Length && !visited.Contains(left))
                    {
                        if (arr[left] == 0) return true;
                        list.Add(left);
                        visited.Add(left);
                    }
                    int right = item + arr[item];
                    if (right >= 0 && right < arr.Length && !visited.Contains(right)) {
                        if (arr[right] == 0) return true;
                        list.Add(right);
                        visited.Add(right);
                    }
                }
                input = list;
            }
            return false;
        }

        public bool CanReach_v2(int[] arr, int start)
        {
            if (arr[start] == 0) return true;
            Queue<int> q = new Queue<int>() { };
            q.Enqueue(start);
            while (q.Count > 0)
            {
                var num = q.Dequeue();
                if (arr[num] == 0) return true;
                if (arr[num] < 0) continue;
                var left = num - arr[num];
                if(left >= 0)
                {
                    q.Enqueue(left);
                }
                var right = num + arr[num];
                if(right < arr.Length)
                {
                    q.Enqueue(right);
                }

                arr[num] = -arr[num];

            }

            return false;
        }
    }
}
