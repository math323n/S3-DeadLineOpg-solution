using System;
using System.Collections.Generic;

namespace S3_DeadLineOpg.Entities
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
