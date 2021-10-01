using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet]
        public IActionResult getAll()
        {
            using (ShopContext db = new ShopContext())
            {
                var result = db.Venta.ToList();
            return Ok(result);
            }
        }
    }
}