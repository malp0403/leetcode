using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0281
    {
        #region 07/11/2024

        int l1 = 0;
        int l2 = 0;
        bool isOne = true;
        IList<int> _v1;
        IList<int> _v2
        public _0281(IList<int> v1, IList<int> v2)
        {
            _v1 = v1;
            _v2 = v2;
        }

        public bool HasNext()
        {
            return l1 == _v1.Count && l1 == _v2.Count; 
        }

        public int Next()
        {
            if (isOne)
            {
                if(l1 == _v1.Count)
                {
                    return _v2[l2++];
                }
                else
                {
                    return _v1[l1++];
                }
            }
            else
            {
                if(l2 == _v2.Count)
                {
                    return _v1[l1++];
                }
                else
                {
                    return _v2[l2++];
                }    
            }

            isOne = !isOne;
        }
        #endregion
    }
}
