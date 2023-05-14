using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private const string ResponseMessage = "Hello from ProductsController";
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()

        {

            // return new List<Product>
            //{
            //         new Product { ProductId = 1, ProductName = "Product 1" },
            //         new Product { ProductId = 2, ProductName = "Product 2" }
            // };
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
