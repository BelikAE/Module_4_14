using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_14
{
    public enum ProductCategory
    {
        Food,
        HouseholdAppliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategory Category { get; set; }

    }
}
