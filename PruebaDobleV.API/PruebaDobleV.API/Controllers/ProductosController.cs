using Microsoft.AspNetCore.Mvc;
using PruebaDobleV.BL.Interfaces;
using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IProductoBL _actionBL_Producto;
        private IConfiguration _configuration;

        public ProductosController(IProductoBL actionBL_Producto, IConfiguration configuration)
        {
            _actionBL_Producto = actionBL_Producto;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<List<EntityCatProducto>> GetAllProductos()
        {
            var productos = await _actionBL_Producto.GetAllProductosAsync();

            return productos.Data;
        }

        [HttpGet("GetProductoById")]
        public async Task<EntityCatProducto> GetProductoById(int idProducto)
        {
            var producto = await _actionBL_Producto.GetProductoByIdAsync(idProducto);

            return producto.Data;
        }

        [HttpPost]
        public async Task<JsonResult> CreateProducto(EntityCatProducto dto)
        {
            var result = _actionBL_Producto.CreateProductoAsync(dto);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<JsonResult> UpdateProducto(EntityCatProducto dto)
        {
            var result = _actionBL_Producto.UpdateProductoAsync(dto);

            return new JsonResult(result);
        }

    }
}
