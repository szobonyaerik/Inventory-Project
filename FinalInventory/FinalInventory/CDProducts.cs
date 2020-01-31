using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class CDProduct : Product
    {
        public int numoftracks;

        public int NumOfTrack
        {
            get
            {
                return numoftracks;
            }
            set
            {
                numoftracks = value;
            }
        }

        public CDProduct() { }

        public CDProduct(string Name, int Price, int Tracks)
        {
            this._name = Name;
            this._price = Price;
            this.numoftracks = Tracks;
        }
    }
}