using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1901_1950
{
    internal class _1904
    {
        #region 10/10/2023
        public int NumberOfRounds(string loginTime,string logoutTime)
        {
            string[] login = loginTime.Split(":");
            string[] logout = logoutTime.Split(":");

            

            int hours = 0;
            if (int.Parse(login[0]) < int.Parse(logout[0]) || (int.Parse(login[0]) == int.Parse(logout[0]) && (int.Parse(login[1]) <=int.Parse(logout[1]))) )
            {
                hours = int.Parse(logout[0]) - int.Parse(login[0]);
            }
            else
            {
                hours = int.Parse(logout[0]) - int.Parse(login[0]) + 24;
            }

            int loginMin = 0;
            if(int.Parse(login[1]) ==0)
            {
                loginMin = 0;
            } else if(int.Parse(login[1]) <= 15)
            {
                loginMin = 15;
            }
            else if(int.Parse(login[1]) <= 30)
            {
                loginMin = 30;
            }else if(int.Parse(login[1]) <= 45)
            {
                loginMin = 45;
            }
            else
            {
                loginMin = 60;
            }

            int logoutMin = 0;
            if (int.Parse(logout[1]) <= 14)
            {
                logoutMin = 0;
            }
            else if (int.Parse(logout[1]) <= 29)
            {
                logoutMin = 15;
            }
            else if (int.Parse(logout[1]) <= 44)
            {
                logoutMin = 30;
            }
            else
            {
                logoutMin = 45;
            }

            int total = hours * 60 - loginMin + logoutMin;
            if (total <= 0) return 0;
            int rounds = (total) /15;
            return rounds;
        }
        #endregion

        #region Solution2 100% speed
        public int NumberOfRounds_solution2(string loginTime, string logoutTime)
        {
            string[] login = loginTime.Split(":");
            string[] logout = logoutTime.Split(":");

            int loginHour = int.Parse(login[0]) *60;
            int logoutHour = int.Parse(logout[0]) * 60;

            int divide = int.Parse(login[1]) / 15;
            int remaing = int.Parse(login[1]) % 15;
            int loginMin = (divide + (remaing !=0?1:0))*15;

            int divide2 = int.Parse(logout[1]) / 15;
            int remaing2 = int.Parse(logout[1]) % 15;
            int logoutMin = divide2 *15;

            int mins = 0;
            if(loginHour + int.Parse(login[1]) > (logoutHour + int.Parse(logout[1])))
            {
                mins = logoutHour + logoutMin - loginHour - loginMin + 24 * 60;
            }
            else
            {
                mins = logoutHour + logoutMin - loginHour - loginMin;
            }
            if (mins <= 0) return 0;

            return mins/15;
        }
        #endregion

    }
}
