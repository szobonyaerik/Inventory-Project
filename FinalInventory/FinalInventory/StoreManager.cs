using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryProject
{
    public class StoreManager
    {
        private IStorageCapable _storage;

        public void AddStorage(IStorageCapable storage)
        {
            _storage = storage;
        }

        public void AddCDProduct(string name, int price, int tracks)
        {
            _storage.StoreCdProduct(name, price, tracks);
        }

        public void AddBookProduct(string name, int price, int pages)
        {
            _storage.StoreCdProduct(name, price, pages);
        }
    }
}

