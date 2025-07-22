using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommProj.Models;

namespace EcommProj.Models
{
    public class REVAVM
    {
        public RevaUserMst RevaUserMstObj { get; set; }
        public List<RevaUserMst> RevaUserMstList { get; set; }

        public RevaWishlistMst RevaWishlistObj { get; set; }
        public List<RevaWishlistMst> RevaWishlistMstList { get; set; }

        public RevaTransactionMst RevaTransactionMstObj { get; set; }
        public List<RevaTransactionMst> RevaTransactionMstList { get; set; }

        public RevaProductMst RevaProductMstObj { get; set; }
        public List<RevaProductMst> RevaProductMstList { get; set; }

        public RevaCategoryMst RevaCategoryMstObj { get; set; }
        public List<RevaCategoryMst> RevaCategoryMstList { get; set; }

        public RevaCartMst RevaCartMstObj { get; set; }
        public List<RevaCartMst> RevaCartMstList { get; set; }

       
    }
}