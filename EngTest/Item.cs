using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngTest
{
    class Item
    {
        private String _name;
        private ItemCategory _category;
        private double _price;
        private Boolean _imported;

        public Item(String name,ItemCategory category, double price,Boolean imported)
        {
            _name = name;
            _category = category;
            _price = price;
            _imported = imported;
        }

        public String GetName() { return _name; }
        public ItemCategory GetCategory() { return _category; }
        public double GetPrice() { return _price; }
        public bool GetImported() { return _imported; }

    }
}
