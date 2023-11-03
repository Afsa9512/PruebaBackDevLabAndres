using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface IProductoDAL
    {
        public Task<List<EntityCatProducto>> GetAllProductosAsync();
        public Task<EntityCatProducto> GetProductoByIdAsync(int idProducto);
        public Task CreateProductoAsync(EntityCatProducto entity, byte[] imagen);
        public Task UpdateProductoAsync(EntityCatProducto entity);
    }
}
