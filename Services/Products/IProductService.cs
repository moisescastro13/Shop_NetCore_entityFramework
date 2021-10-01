using System.Collections.Generic;
using Models.Entities;
using Models.Request;
using Services.Common;

namespace Services.Products
{
    public interface IProductService: ICrudTemplate<Producto,ProductoDto>
    {
    }
}