using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // Global değişkenler alt çizgi ile başlar.

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{CategoryId=2,ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{CategoryId=3,ProductId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{CategoryId=4,ProductId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{CategoryId=5,ProductId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1}

        };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null; // Referans tip olduğu için null ataması yapılır.
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // LINQ - Language Integrated Query

            _products.Remove(productToDelete);

            //_products[product.CategoryId] = product;
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // Where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
            return _products.Where(p => p.CategoryId == categoryId).ToList(); // LINQ - Language Integrated Query
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // LINQ - Language Integrated Query
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
