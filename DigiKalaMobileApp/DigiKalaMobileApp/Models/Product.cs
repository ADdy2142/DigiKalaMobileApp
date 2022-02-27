using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public DateTime? DiscountEndDate { get; set; }
        public int Visit { get; set; }
        public double Score { get; set; }
        public int Qty { get; set; }

        public double FinalPrice => Price - (Price * Discount / 100);
        public bool HasDiscount => Discount > 0;
        public bool HasQty => Qty > 0;
    }
}