using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 475. Heaters
Medium
2K
1.1K
company
Amazon
company
Nutanix
company
Google
Winter is coming! During the contest, your first job is to design a standard heater with a fixed warm radius to warm all the houses.

Every house can be warmed, as long as the house is within the heater's warm radius range. 

Given the positions of houses and heaters on a horizontal line, return the minimum radius standard of heaters so that those heaters could cover all houses.

Notice that all the heaters follow your radius standard, and the warm radius will the same.

 

Example 1:

Input: houses = [1,2,3], heaters = [2]
Output: 1
Explanation: The only heater was placed in the position 2, and if we use the radius 1 standard, then all the houses can be warmed.
Example 2:

Input: houses = [1,2,3,4], heaters = [1,4]
Output: 1
Explanation: The two heaters were placed at positions 1 and 4. We need to use a radius 1 standard, then all the houses can be warmed.
Example 3:

Input: houses = [1,5], heaters = [2]
Output: 3
 

Constraints:

1 <= houses.length, heaters.length <= 3 * 104
1 <= houses[i], heaters[i] <= 109
 */
#endregion

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0475
    {
        #region 11/27/2023  two looops
        public int FindRadius(int[] houses, int[] heaters)
        {
            int min = int.MinValue;

            foreach (int house in houses)
            {
                int ans = int.MaxValue;
                foreach (var item in heaters)
                {
                    ans = Math.Min(Math.Abs(item - house), ans);
                }
                min = Math.Max(min, ans);
            }

            return min;
        }
        #endregion
    }
}
