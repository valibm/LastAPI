using API.Common;
using Business.Services;
using Entity.Entities;
using Exceptions.EntityExceptions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]"), ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<Product> products;

        try
        {
            products = await _productService.GetAll();
            return Ok(products);
        }
        catch (EntityCouldNotBeFoundException)
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response(4151, "Data could not be found"));
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status404NotFound, new Response(4151, "Data could not be found"));
        }
    }
}
