using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0184
    {
        #region 06/10/2024
        /*
         with cte as(
         select  row_number() over (partition by departmentId  order by salary desc) as rowno,* from Employee
        )
        select d.name as Department,c.name as employee,c.salary as Salary from cte c join Department d on d.id = c.departmentid where rowno = 1

         */
        #endregion
    }
}
