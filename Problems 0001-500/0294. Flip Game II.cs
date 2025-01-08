using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0294
    {
        #region 07/15/2024
        public bool CanWin(string currentState)
        {

            List<string> list = new List<string>();
            for(int i = 0; i < currentState.Length - 1; i++)
            {
                if (currentState[i] == '+' && currentState[i + 1] == '+')
                {
                    list.Add(currentState.Substring(0, i) + "--" + currentState.Substring(i + 2, currentState.Length - i - 2));
                }
            }

            foreach (var item in list)
            {
                if (!CanWin(item))
                {
                    return true;
                }
            }

            return false;









        }
            #endregion
        }
    }
