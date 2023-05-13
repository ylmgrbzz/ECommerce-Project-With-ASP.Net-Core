using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Merhaba";
        }
        //private IProductService _productService;
        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}
        //public IActionResult Get()
        //{
        //    var result = _productService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //public IActionResult Get(int id)
        //{
        //    var result = _productService.GetById(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //public IActionResult Add(Product product)
        //{
        //    var result = _productService.Add(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //public IActionResult Update(Product product)
        //{
        //    var result = _productService.Update(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //public IActionResult Delete(Product product)
        //{
        //    var result = _productService.Delete(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //} 

    }
}
