using System;

namespace InventoryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreManager mainStoreManager = new StoreManager();
            IStorageCapable storage = new PersistentStore();
            mainStoreManager.AddStorage(storage);
            mainStoreManager.AddBookProduct("Harry Potter ", 3000, 420);
            mainStoreManager.AddBookProduct("Vadonjáró Tanítványa", 2000, 230);
            mainStoreManager.AddBookProduct("Lord of the Ring", 4000, 523);
            mainStoreManager.AddCDProduct("KHKMR", 1000, 20);
            mainStoreManager.AddCDProduct("Timmy Trumpet", 1000, 18);
            mainStoreManager.AddCDProduct("AK26", 500, 10);
        }
    }
}
