using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0170
    {
        #region 04/15/2024
        Dictionary<int, int> dic;
        public _0170()
        {
            dic = new Dictionary<int, int>();
        }

        public void Add(int number)
        {
            if (dic.ContainsKey(number))
            {
                dic[number]++;
            }
            else
            {
                dic.Add(number, 1);
            }


        }

        public bool Find(int value)
        {
            foreach (var item in dic.Keys)
            {
                int com = value - item;

                if (dic.ContainsKey(com))
                {
                    if (com == item && dic[com] >= 2)
                    {
                        return true;
                    }
                    else if (com != item)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        #endregion

    }
}
