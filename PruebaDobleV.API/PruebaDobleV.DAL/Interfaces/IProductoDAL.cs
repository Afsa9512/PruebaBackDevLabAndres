using PruebaDobleV.Entities.DevLabEntity;
using PruebaDobleV.Entities.ViewModels;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface IProductoDAL
    {
        public Task<List<EntityCatProducto>> GetAllProductosAsync();
        public Task<ProductoViewModel> GetProductoByIdAsync(int idProducto);
        public Task CreateProductoAsync(EntityCatProducto entity, byte[] imagen);
        public Task UpdateProductoAsync(EntityCatProducto entity);
    }
}
