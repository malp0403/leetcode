using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0185
    {
        #region 06/11/2024
        /*
         with cte as (
         select DENSE_RANK() over(partition by e.departmentId order by e.salary desc) as rowNo,e.* from Employee e)

        select d.name as Department, c.name as Employee,c.salary from cte c join department d on d.id = c.departmentId
        where c.rowNo <=3 
         */
        #endregion
    }
}
