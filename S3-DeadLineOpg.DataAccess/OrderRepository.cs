using S3_DeadLineOpg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_DeadLineOpg.DataAccess
{
    public class OrderRepository: RepositoryBase<Orders>
    {
        /// <summary>
        /// Gets all products & the associated supplier
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Orders> GetAll()
        {
            return context.Orders;
        }
    }
}
