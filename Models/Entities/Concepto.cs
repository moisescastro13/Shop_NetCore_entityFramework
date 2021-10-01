using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Entities
{
    public partial class Concepto
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public int IdProduct { get; set; }

        public virtual Producto IdProductNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
