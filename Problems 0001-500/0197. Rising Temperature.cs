using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0197
    {
        #region 06/11/2024
        /*
    SELECT current_day.id
FROM Weather AS current_day
WHERE EXISTS (
    SELECT 1
    FROM Weather AS yesterday
    WHERE current_day.temperature > yesterday.temperature
    AND current_day.recordDate = DATEADD(day, 1, yesterday.recordDate)
);



        SELECT 
w2.id
FROM 
    Weather w1
JOIN 
    Weather w2
ON 
    DATEDIFF(day,w1.recordDate, w2.recordDate) = 1
WHERE 
    w2.temperature > w1.temperature;

         */
        #endregion
    }
}
