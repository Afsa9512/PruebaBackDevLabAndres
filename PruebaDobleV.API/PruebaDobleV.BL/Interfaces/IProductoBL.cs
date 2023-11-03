using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.BL.Interfaces
{
    public interface IProductoBL
    {
        public Task<EntityResult<List<EntityCatProducto>>> GetAllProductosAsync();
        public Task<EntityResult<EntityCatProducto>> GetProductoByIdAsync(int idProducto);
        public string CreateProductoAsync(EntityCatProducto dto, byte[] imagen);
        public string UpdateProductoAsync(EntityCatProducto dto);
    }
}
