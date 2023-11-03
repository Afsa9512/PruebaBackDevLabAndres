using PruebaDobleV.DAL.Connection;
using PruebaDobleV.DAL.Interfaces;
using PruebaDobleV.Entities.DevLabEntity;
using System.Data;
using System.Data.SqlClient;

namespace PruebaDobleV.DAL.DevLab
{
    public class ProductoDAL : IProductoDAL
    {
        public async Task<List<EntityCatProducto>> GetAllProductosAsync()
        {
            try
            {
                List<EntityCatProducto> listProductos = new List<EntityCatProducto>();
                AdminConection adminConection = new AdminConection();
                string mensajeDeError = string.Empty;

                DataTable data = adminConection.ObtenerDataTable("DevLab.dbo.GetAllProductos", ref mensajeDeError);

                foreach (DataRow item in data.Rows)
                {
                    EntityCatProducto producto = new EntityCatProducto
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        NombreProducto = item["NombreProducto"].ToString(),
                        ImagenProducto = item["ImagenProducto"].ToString(),
                        PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]),
                        Ext = item["Ext"].ToString(),
                    };
                    listProductos.Add(producto);
                }

                return listProductos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EntityCatProducto> GetProductoByIdAsync(int idProducto)
        {
            try
            {
                EntityCatProducto producto = new EntityCatProducto();
                AdminConection adminConection = new AdminConection();
                string mensajeDeError = string.Empty;

                SqlParameter[] parameters = {
                    new SqlParameter { ParameterName = "IdProducto",Value = idProducto }
                };

                DataTable data = adminConection.ObtenerDataTable("DevLab.dbo.GetProductoById", ref mensajeDeError, parameters);

                foreach (DataRow item in data.Rows)
                {
                    producto = new EntityCatProducto()
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        NombreProducto = item["NombreProducto"].ToString(),
                        ImagenProducto = item["ImagenProducto"].ToString(),
                        PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]),
                        Ext = item["Ext"].ToString()
                    };
                }

                return producto;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Task CreateProductoAsync(EntityCatProducto entity)
        {
            try
            {
                AdminConection adminConection = new AdminConection();
                string mensajeDeError = string.Empty;
                string mensaje = string.Empty;

                SqlParameter[] parameters = {
                    new SqlParameter {ParameterName = "NombreProducto", Value = entity.NombreProducto},
                    new SqlParameter {ParameterName = "ImagenProducto", Value = entity.ImagenProducto},
                    new SqlParameter {ParameterName = "Preciounitario", Value = entity.PrecioUnitario},
                    new SqlParameter {ParameterName = "Ext", Value = entity.Ext},
                };

                DataTable data = adminConection.ObtenerDataTable("DevLab.dbo.CreateProducto", ref mensajeDeError, parameters);

                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task UpdateProductoAsync(EntityCatProducto entity)
        {
            try
            {
                AdminConection adminConection = new AdminConection();
                string mensajeDeError = string.Empty;
                string mensaje = string.Empty;

                SqlParameter[] parameters = {
                    new SqlParameter { ParameterName = "IdProducto", Value = entity.Id},
                    new SqlParameter {ParameterName = "NombreProducto", Value = entity.NombreProducto},
                    new SqlParameter {ParameterName = "ImagenProducto", Value = entity.ImagenProducto},
                    new SqlParameter {ParameterName = "Preciounitario", Value = entity.PrecioUnitario},
                    new SqlParameter {ParameterName = "Ext", Value = entity.Ext},
                };

                DataTable data = adminConection.ObtenerDataTable("DevLab.dbo.UpdateProducto", ref mensajeDeError, parameters);

                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
