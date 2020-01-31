using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace InventoryProject
{
    public interface IStorageCapable
    {
        List<Product> GetAllProducts();

        void StoreCdProduct(string name, int price, int tracks);
        void StoreBookProduct(string name, int price, int pages);
    }
}

