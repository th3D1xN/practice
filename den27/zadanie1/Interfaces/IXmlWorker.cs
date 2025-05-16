using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1.Models;

namespace zadanie1.Interfaces
{
    public interface IXmlWorker
    {
        List<Product> LoadProducts(string filePath);
        void AddProduct(string filePath, Product product);
    }
}
