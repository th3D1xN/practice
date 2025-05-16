using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using zadanie1.Interfaces;
using zadanie1.Models;

namespace zadanie1.Share
{
    internal class XmlDocumentWorker : IXmlWorker
    {
        public List<Product> LoadProducts(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден", filePath);

            var doc = XDocument.Load(filePath);

            if (doc.Root == null || doc.Root.Name != "Products")
                throw new InvalidOperationException("Неверный формат XML файла. Ожидается корневой элемент 'Products'");

            return doc.Root.Elements("Product")
                .Select(p => new Product
                {
                    Name = p.Element("Name")?.Value ?? "Не указано",
                    ExpiryDate = p.Element("ExpiryDate")?.Value ?? "Не указано",
                    Price = decimal.TryParse(p.Element("Price")?.Value, out decimal price) ? price : 0
                })
                .ToList();
        }
        public void AddProduct(string filePath, Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден", filePath);

            var doc = XDocument.Load(filePath);

            if (doc.Root == null)
                doc.Add(new XElement("Products"));

            XElement newProduct = new XElement("Product",
                new XElement("Name", product.Name),
                new XElement("ExpiryDate", product.ExpiryDate),
                new XElement("Price", product.Price)
            );

            doc.Root.Add(newProduct);
            doc.Save(filePath);
        }
    }
}
