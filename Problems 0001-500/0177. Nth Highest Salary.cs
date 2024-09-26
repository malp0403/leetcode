using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0177
    {
        #region 04/16/2024
        /*
         CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
   RETURN (
      select top 1 salary from (
        select salary,Dense_rank() over(order by salary desc) as rnk from employee
        ) as T
        where rnk = @N

    );
END
         **/
        #endregion
    }
}
