using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } // ProductName isimli bir property tanımladık.
        public decimal UnitPrice { get; set; } // UnitPrice isimli bir property tanımladık.
        public short UnitsInStock { get; set; } // UnitsInStock isimli bir property tanımladık.
    }
}
