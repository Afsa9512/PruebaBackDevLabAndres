using PruebaDobleV.Entities.DevLabEntity;

namespace PruebaDobleV.BL.Interfaces
{
    public interface IClienteBL
    {
        public Task<EntityResult<List<EntityCliente>>> GetAllClientesAsync();
        public Task<EntityResult<EntityCliente>> GetClienteByIdAsync(int idCliente);
        public string CreateClienteAsync(EntityCliente dto);
        public string UpdateClienteAsync(EntityCliente dto);
    }
}
