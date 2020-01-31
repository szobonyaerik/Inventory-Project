using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class BookProduct : Product
    {
        public int numofpages;

        public int NumOfPages
        {
            get
            {
                return numofpages;
            }
            set
            {
                numofpages = value;
            }
        }

        public BookProduct() { }

        public BookProduct(string Name, int Price, int Pages)
        {
            this._name = Name;
            this._price = Price;
            this.numofpages = Pages;
        }
    }
}