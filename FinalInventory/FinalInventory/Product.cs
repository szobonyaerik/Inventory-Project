using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public abstract class Product
    {
        public string _name;
        public int _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
