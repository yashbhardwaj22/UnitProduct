using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitProduct.Models
{
    public class TotalSum
    {
        public IEnumerable<ArticleDetails> TotalProduct { get; set; }
        public int GrandTotal { get; set; }
        public int TotalDiscount { get; set; }
    }
}
