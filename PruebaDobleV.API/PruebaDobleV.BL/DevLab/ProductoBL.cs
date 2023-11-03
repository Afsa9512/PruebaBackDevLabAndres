using PruebaDobleV.BL.Interfaces;
using PruebaDobleV.DAL.DevLab;
using PruebaDobleV.DAL.Interfaces;
using PruebaDobleV.Entities.DevLabEntity;
using PruebaDobleV.Entities.ViewModels;
using PruebaDobleV.Utility;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace PruebaDobleV.BL.DevLab
{
    public class ProductoBL : IProductoBL
    {
        private readonly IProductoDAL productoDAL;
        public ProductoBL(IProductoDAL productoDAL)
        {
            this.productoDAL = productoDAL;
        }

        public async Task<EntityResult<List<EntityCatProducto>>> GetAllProductosAsync()
        {
            try
            {
                List<EntityCatProducto> result = await productoDAL.GetAllProductosAsync();

                if (result != null)
                    return EntityResult<List<EntityCatProducto>>.SuccessResult(true, System.Net.HttpStatusCode.OK, result, string.Empty);
                else
                    return EntityResult<List<EntityCatProducto>>.WrongResult(System.Net.HttpStatusCode.NotFound, Utilidades.GetNotFoundListError());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EntityResult<ProductoViewModel>> GetProductoByIdAsync(int idProducto)
        {
            try
            {
                ProductoViewModel result = await productoDAL.GetProductoByIdAsync(idProducto);



                if (result != null)
                    return EntityResult<ProductoViewModel>.SuccessResult(true, System.Net.HttpStatusCode.OK, result, string.Empty);
                else
                    return EntityResult<ProductoViewModel>.WrongResult(System.Net.HttpStatusCode.NotFound, Utilidades.GetNotFoundListError());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string CreateProductoAsync(EntityCatProducto dto, byte[] imagen)
        {
            try
            {
                var result = productoDAL.CreateProductoAsync(dto ,imagen);

                return "Producto creado con exito.!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string UpdateProductoAsync(EntityCatProducto dto)
        {
            try
            {
                var result = productoDAL.UpdateProductoAsync(dto);

                return "Producto actualizado con exito.!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public System.Drawing.Image Bytes_A_Imagen(Byte[] ImgBytes)
        {

            Bitmap imagen = null;

            Byte[] bytes = (Byte[])(ImgBytes);

            MemoryStream ms = new MemoryStream(bytes);

            imagen = new Bitmap(ms);

            return imagen;

        }
    }
}
