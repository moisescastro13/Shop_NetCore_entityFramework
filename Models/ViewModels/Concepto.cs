using System;

namespace Models.viewModels
{
    public class Concepto
    {
        
        public int Id { get; set; }
        public Venta IdVenta { get; set; }
        public int Cantidad { get; set; }
        public Decimal PrecioUnitario { get; set; }
    }
}