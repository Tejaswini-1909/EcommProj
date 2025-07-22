using System;
using System.Collections.Generic;

namespace EcommProj.Models
{
    public partial class RevaTransactionMst
    {
        public string Email { get; set; }
        public decimal? CategoryId { get; set; }
        public decimal? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public decimal? TransactionId { get; set; }
        public DateTime? TansactionDate { get; set; }
        public bool Status { get; set; }
    }
}
