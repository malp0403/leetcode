using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0384
    {
        #region Approach #2 Fisher-Yates Algorithm 费雪耶兹（Fisher–Yates） 也被称作高纳德（ Knuth）随机置乱算法 09/03/2024 

        int[] _num;
        public _0384(int[] nums)
        {
            _num= nums.Select(i=>i).ToArray();
        }

        public int[] Reset()
        {
            return _num;
        }

        public int[] Shuffle()
        {
            int[] numCopy = _num.Select(i => i).ToArray();

            for(int i =0;i < numCopy.Length; i++)
            {
                int index = new Random().Next(numCopy.Length);

                int temp= numCopy[i];
                numCopy[i] = numCopy[index];
                numCopy[index] = temp;

            }
            return numCopy;
        }
        #endregion
    }
}
