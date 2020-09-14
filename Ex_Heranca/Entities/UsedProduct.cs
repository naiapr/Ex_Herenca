using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag(string name, double price)
        {
            return "Manufacture date:" + ManufactureDate;
        }
    }
}
