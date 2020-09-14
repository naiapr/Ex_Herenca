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
        public double TotalPrice()
        {
            return Price + CustomsFree;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + "(Customs Free : $" + CustomsFree + ")";
        }

        

    }
}
