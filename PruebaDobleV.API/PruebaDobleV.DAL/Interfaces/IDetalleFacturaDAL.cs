using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface IDetalleFacturaDAL
    {
        public Task CreateDetalleFacturaAsync(EntityDetallesFactura entity);
    }
}
