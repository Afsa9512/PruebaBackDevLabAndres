using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface IClienteDAL
    {
        public Task<List<EntityCliente>> GetAllClientesAsync();
        public Task<EntityCliente> GetClienteByIdAsync(int idCliente);
        public Task CreateClienteAsync(EntityCliente entity);
        public Task UpdateClienteAsync(EntityCliente entity);
    }
}
