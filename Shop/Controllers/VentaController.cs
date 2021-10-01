using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Request;
using Models.Respose;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(VentaDto ventaDto)
        {
            Status status =new Status();
            return Ok(status);
        }
    }
}