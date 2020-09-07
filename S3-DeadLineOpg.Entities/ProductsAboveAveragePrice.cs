using System;
using System.Collections.Generic;

namespace S3_DeadLineOpg.Entities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
