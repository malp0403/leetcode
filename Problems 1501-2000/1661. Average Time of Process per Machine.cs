using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1651_1700
{
    //SQL
    internal class _1661
    {
        #region 09/19/2023
        //select a1.machine_id, Round(AVG(a2.timestamp - a1.timestamp),3)  as processing_time from Activity a1
        //    join activity a2 on a1.machine_id = a2.machine_id
        //    on a1.process_id = a2.process_id
        //    on a1.timestamp < a2.timestamp
        //        group by a1.machine_id
        #endregion
        #region 09/23/2023
        /*
         select a1.machine_id,Round(Avg(a2.timestamp - a1.timestamp),3) as processing_time from activity a1 
        join activity a2 on a1.process_id = a2.process_id
        and a1.machine_id = a2.machine_id
        and a1.timestamp < a2.timestamp
        group by a1.machine_id
         */
        #endregion
    }
}
