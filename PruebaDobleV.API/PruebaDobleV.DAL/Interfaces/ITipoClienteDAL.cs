using PruebaDobleV.Entities.DevLabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDobleV.DAL.Interfaces
{
    public interface ITipoClienteDAL
    {
        public Task<List<EntityCatTipoCliente>> GetAllTipoClientesAsync();
        public Task<EntityCatTipoCliente> GetTipoClienteByIdAsync(int idTipoCliente);
        public Task CreateTipoClienteAsync(EntityCatTipoCliente entity);
        public Task UpdateTipoClienteAsync(EntityCatTipoCliente entity);
    }
}
