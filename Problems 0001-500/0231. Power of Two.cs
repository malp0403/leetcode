using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0231
    {
        public bool IsPowerOfTwo(int n)
        {
            List<int> list = new List<int>();
            for(int i =0; i < 31; i++)
            {
                list.Add((int)Math.Pow(2, i));
            }
            for(int i =list.Count-1;i >= 0; i--)
            {
                if (n == list[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
