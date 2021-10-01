using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Request
{
    public class VentaDto
    {
        [Required]
        public int IdCliente { get; set; }
        public decimal Total { get; set; }
        [Required]
        public List<ConceptoDto> Conceptos { get; set; }

        public VentaDto()
        {
            this.Conceptos = new List<ConceptoDto>();
        }
    }
}