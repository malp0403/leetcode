using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0352
    {
        #region 08/31/2024
        List<int[]> _list;
        public _0352()
        {
            _list = new List<int[]>();
        }

        public void AddNum(int value)
        {
            for(int i =0; i < _list.Count; i++)
            {
                var ele = _list[i];
                if(value  == _list[i][0] - 1)
                {
                    _list[i][0] = value;
                    return;
                }
                else if( value == _list[i][1] +1)
                {
                    if(i+1< _list.Count && _list[i + 1][0] == value + 1)
                    {
                        _list[i][1] = _list[i + 1][1];
                        _list.RemoveAt(i + 1);
                        return;
                    }
                    else
                    {
                        _list[i][1] = value;
                        return;
                    }
                }else if( value >=ele[0] && value <= ele[1])
                {
                    return;
                }

            }

            _list.Add(new int[] { value, value });
            _list.Sort((a, b) => { return a[0] - b[0]; });
        }

        public int[][] GetIntervals()
        {
            return _list.ToArray();
        }
        #endregion

    }
}
