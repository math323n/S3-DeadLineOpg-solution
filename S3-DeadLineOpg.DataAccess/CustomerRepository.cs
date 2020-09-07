using S3_DeadLineOpg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_DeadLineOpg.DataAccess
{
    public class CustomerRepository: RepositoryBase<Customers>
    {



        /// <summary>
        /// Gets all products & the associated supplier
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Customers> GetAll()
        {
            return context.Customers;
        }

    }
}