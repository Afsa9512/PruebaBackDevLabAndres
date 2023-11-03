using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface IProductoDAL
    {
        public Task<List<EntityCatProducto>> GetAllProductosAsync();
        public Task<EntityCatProducto> GetProductoByIdAsync(int idProducto);
        public Task CreateProductoAsync(EntityCatProducto entity);
        public Task UpdateProductoAsync(EntityCatProducto entity);
    }
}
