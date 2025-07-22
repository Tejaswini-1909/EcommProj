using System;
using System.Collections.Generic;

namespace EcommProj.Models
{
    public partial class RevaProductMst
    {
        public decimal CategoryId { get; set; }
        public decimal? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public bool Status { get; set; }
    }
}
