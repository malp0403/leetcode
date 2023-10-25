using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.

The operation of drinking a full water bottle turns it into an empty bottle.

Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.

 

Example 1:


Input: numBottles = 9, numExchange = 3
Output: 13
Explanation: You can exchange 3 empty bottles to get 1 full water bottle.
Number of water bottles you can drink: 9 + 3 + 1 = 13.
Example 2:


Input: numBottles = 15, numExchange = 4
Output: 19
Explanation: You can exchange 4 empty bottles to get 1 full water bottle. 
Number of water bottles you can drink: 15 + 3 + 1 = 19.
 */
#endregion

namespace leetcode.Problems_1501_2000._1501_1550
{
    internal class _1518
    {
        #region 10/22/2023
        public int NumWaterBottles_20231022(int numBottles, int numExchange)
        {
            int sum = 0;
            sum += numBottles;
            int fullBottles = numBottles;
            int empty = 0;
            while(true)
            {
                int temp = fullBottles;
                fullBottles = (temp + empty) / numExchange;
                empty = (temp + empty) % numExchange;

                sum += fullBottles;

                if (fullBottles + empty < numExchange) break;
            }
            return sum;
        }
        #endregion

    }
}
