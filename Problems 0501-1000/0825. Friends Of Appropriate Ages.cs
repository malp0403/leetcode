using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0825
    {
        public int NumFriendRequests(int[] ages)
        {
            int count = 0;
            int[] agesArr = Enumerable.Repeat(0, 121).ToArray();

            foreach(int age in ages)
            {
                agesArr[age]++;
            }

            for(int i =agesArr.Length -1; i >=0; i--)
            {
                
                if (agesArr[i] > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if(agesArr[j] >0 && FriendRequest(i, j))
                        {
                            count += agesArr[j] * agesArr[i];
                        }
                     
                    }
                    if(FriendRequest(i, i))
                    {
                        count += agesArr[i] * (agesArr[i] - 1);
                    }
                }
            }
            return count;

        }

        public bool FriendRequest(int x,int y)
        {
            if (x >= y && x < 2 * (y - 7) && !(y > 100 && x < 100)) return true;
            return false;
        }
    }
}
