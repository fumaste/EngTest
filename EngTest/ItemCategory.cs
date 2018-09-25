using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngTest
{
    public class ItemCategory
    {
        private string _Name;
        private double _salesTax;

        public ItemCategory(string name, double salesTaxes)
        {
            _Name = name;
            _salesTax = salesTaxes;
        }

        public string GetName()
        {
            return _Name;
        }

        public double GetSalesTax()
        {
            return _salesTax;
        }
    }
}
