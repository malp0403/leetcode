using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0339
    {
        int sum = 0;
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            foreach(var ele in nestedList)
            {
                transform(ele, 1);
            }

            return sum;
        }

        public void transform(NestedInteger data, int level)
        {
            //if single integer
            if (data.IsInteger())
            {
                sum += data.GetInteger() * level;
                return;
            }

            if (data.GetList() != null)
            {
                foreach (var ele in data.GetList())
                {
                    var increaseleve = ele.GetList() != null;
                    transform(ele, increaseleve ? level + 1 : level);
                }
            }

        }

        //01-01-2021--------------------
        public int DepthSum_R2(IList<NestedInteger> nestedList)
        {
            int sum = 0;
            foreach(var ele in nestedList)
            {
                sum += helper(ele, 1);
            }
            return sum;
        }
        public int helper(NestedInteger n,int level)
        {
            if (n.IsInteger()) return n.GetInteger() * level;
            else
            {
                int sum = 0;
                foreach(var ele in n.GetList())
                {
                    sum += helper(ele, level + 1);
                }
                return sum;
            }
        }
        public interface NestedInteger
        {

            // Constructor initializes an empty nested list.
            //public NestedInteger();

            //// Constructor initializes a single integer.
            //public NestedInteger(int value);

            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger();

            // Set this NestedInteger to hold a single integer.
            public void SetInteger(int value);

            // Set this NestedInteger to hold a nested list and adds a nested integer to it.
            public void Add(NestedInteger ni);

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList();
        }
    }

}
