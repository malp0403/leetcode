using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace leetcode.Problems_2001_2500
{
    internal class _2246
    {
        #region My Solution && Leetcode :Approach 1: Depth First Search

        Dictionary<int, List<int>> children = new Dictionary<int, List<int>>();
        int max = 1;
        int[] parent;
        string s;
        public int LongestPath(int[] parent, string s)
        {
            this.parent = parent;
            this.s = s;
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] != -1)
                {
                    int p = parent[i];
                    if (children.ContainsKey(p))
                    {
                        children[p].Add(i);
                    }
                    else
                    {
                        children.Add(p, new List<int>() { i });
                    }
                }
            }

            helper(0);


            return max;
        }
        public int helper(int index)
        {
            if (!children.ContainsKey(index)) return 1;

            int first = 0;
            int second = 0;

            foreach (var child in children[index])
            {

                int temp = helper(child);
                if (s[index] == s[child]) continue;
                if(temp > first)
                {
                    second = first;
                    first = temp;
                }else if(temp > second)
                {
                    second = temp;
                }
            }

            max = Math.Max(max, first + 1 + second);

            return Math.Max(first, second) + 1;

        }
        #endregion

        #region Another Solution

        public int LongestPath_s2(int[] parent, string s)
        {
            this.parent = parent;
            this.s = s;
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] != -1)
                {
                    int p = parent[i];
                    if (children.ContainsKey(p))
                    {
                        children[p].Add(i);
                    }
                    else
                    {
                        children.Add(p, new List<int>() { i });
                    }
                }
            }

            helper(0, ' ');


            return max;
        }
        public int helper(int index, char pre)
        {
            if (s[index] == pre)
            {
                helper(index, ' ');
                return 0;
            }

            if (!children.ContainsKey(index)) return 1;

            List<int> childs = children[index];
            int first = 0;
            int second = 0;
            for (int i = 0; i < childs.Count; i++)
            {
                int val = helper(childs[i], s[index]);

                if (val > first)
                {
                    second = first;
                    first = val;
                }
                else if (val > second)
                {
                    second = val;
                }
            }
            max = Math.Max(max, first + 1 + second);

            return Math.Max(first, second) + 1;

        }
        #endregion

        #region LeetCode Approach 2: Breadth First Search #having implemented yet


        #endregion
    }
}
