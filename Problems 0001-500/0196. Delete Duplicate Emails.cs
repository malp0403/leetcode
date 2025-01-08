using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0196
    {
        #region 06/11/2024
        /*
         * 
         * 
         *      delete p1 
                from Person p1, Person p2
                where p1.Email = p2.Email 
                and p1.id>p2.Id;
         * 
         * 
         * 
          with cte as(
            select ROW_NUMBER() over (PARTITION  by email order by id) as rowno,* from Person 
        
          )
        delete from Person  where id in (
            select id from cte where rowno >=2
        )
         */
        #endregion
    }
}
