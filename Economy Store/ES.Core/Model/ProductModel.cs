using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Core.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public decimal SalePrice { get; set; }
        public string Thumbnail { get; set; }
        public string Category { get; set; }
        public string Warehouse { get; set; }
        public int TotalStockQuantity { get; set; }
        public int MinStockQuantity { get; set; }
        public bool IsAllowNegative { get; set; }
    }
}
