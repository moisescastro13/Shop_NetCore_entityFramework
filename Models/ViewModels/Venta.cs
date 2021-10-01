using System;
using System.Numerics;

namespace Models.viewModels
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Total { get; set; }
    }
}