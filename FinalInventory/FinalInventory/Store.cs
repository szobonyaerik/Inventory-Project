using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace InventoryProject
{
    [XmlRoot("Products")]
    [XmlInclude(typeof(PersistentStore))]
    [XmlInclude(typeof(BookProduct))]
    [XmlInclude(typeof(CDProduct))]

    public abstract class Store : IStorageCapable
    {
        protected List<Product> _products;
        public List<Product> ProductList { get { return _products; } set { _products = value; } }


        public Store()
        {
            _products = new List<Product>();
        }

        private void SaveToXml(Product product)
        {
            string filename = "Storage.xml";
            using (var stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Store));
                xml.Serialize(stream, this);
            }
            //write to xml file
        }

        public abstract void StoreProduct(Product product);


        protected Product CreateProduct(string type, string name, int price, int size)
        {
            Product resultProduct;
            switch (type)
            {
                case "CD":
                    resultProduct = new CDProduct(name, price, size);
                    break;

                case "Book":
                    resultProduct = new CDProduct(name, price, size);
                    break;

                default:
                    throw new Exception("Wrong type");



            }
            return resultProduct;
        }
        public void StoreMethod(Product product)
        {
            SaveToXml(product);
            StoreProduct(product);
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            Product resultProduct = CreateProduct("Book", name, price, pages);
            StoreMethod(resultProduct);
        }

        public void StoreCdProduct(string name, int price, int tracks)
        {
            Product resultProduct = CreateProduct("Book", name, price, tracks);
            StoreMethod(resultProduct);
        }
    }
}
