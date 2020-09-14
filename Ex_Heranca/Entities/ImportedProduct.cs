using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree): base (name, price)
        {
            CustomsFree = customsFree;
        }
        public double TotalPrice(double price, double customsFree)
        {
            return price + customsFree;
        }
        public override string PriceTag(string name, double price)
        {
            return "Customs Free :" + CustomsFree;
        }

        

    }
}
