using System;
using System.Collections.Generic;

namespace EcommProj.Models
{
    public partial class RevaWishlistMst
    {
        public string Email { get; set; }
        public decimal? CategoryId { get; set; }
        public decimal? ProductId { get; set; }
        public bool Status { get; set; }
    }
}
