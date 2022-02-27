using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Models
{
    public class MostVisitedProduct
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Visit { get; set; }
    }
}