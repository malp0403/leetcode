using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Write a program to count the number of days between two dates.

The two dates are given as strings, their format is YYYY-MM-DD as shown in the examples.

 

Example 1:

Input: date1 = "2019-06-29", date2 = "2019-06-30"
Output: 1
Example 2:

Input: date1 = "2020-01-15", date2 = "2019-12-31"
Output: 15
 

Constraints:

The given dates are valid dates between the years 1971 and 2100.
 */
#endregion

#region Test
/*
             var obj2 = new _1360() { };
            obj2.DaysBetweenDates("2020-01-15", "2019-12-31");
 */
#endregion

namespace leetcode.Problems_1001_1500._1351_1400
{
    internal class _1360
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            string[] arr1= date1.Split('-');
            string[] arr2= date2.Split("-");
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            foreach (var item in arr1)
            {
                l1.Add(int.Parse(item));
            }
            foreach (var item in arr2)
            {
                l2.Add(int.Parse(item));
            }
            if(new DateTime(l1[0], l1[1], l1[2]) >new DateTime(l2[0], l2[1], l2[2]))
            {
                List<int> temp = l1.Select(x=>x).ToList();
                l1 = l2;
                l2 = temp;
            }

            Dictionary<int,int> months = new Dictionary<int, int>();
            months.Add(1, 31);
            months.Add(2, 28);
            months.Add(3, 31);
            months.Add(4, 30);
            months.Add(5, 31);
            months.Add(6, 30);
            months.Add(7, 31);
            months.Add(8, 31);
            months.Add(9, 30);
            months.Add(10, 31);
            months.Add(11, 30);
            months.Add(12, 31);

            int days = 0;
            for(int i = l1[0];i < l2[0]; i++)
            {

                if (DateTime.IsLeapYear(i))
                {
                    days += 366;
                }
                else
                {
                    days += 365;
                }
            }

            for(int i =1; i< l1[1]; i++)
            {
                if(i != 2)
                {
                    days -= months[i];
                }
                else
                {
                    if (DateTime.IsLeapYear(l1[0]))
                    {
                        days -= 29;
                    }
                    else
                    {
                        days -= 28;
                    }
                }
            }
            days -= l1[2];

            for(int i =1; i < l2[1]; i++)
            {
                if (i != 2)
                {
                    days += months[i];
                }
                else
                {
                    if (DateTime.IsLeapYear(l2[0]))
                    {
                        days += 29;
                    }
                    else
                    {
                        days += 28;
                    }
                }
            }
            days += l2[2];

            return days;








        }
    }
}
