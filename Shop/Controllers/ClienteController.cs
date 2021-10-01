using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Respose;
using Models.viewModels;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            /* Status res = new Status();
            try
            {
                using (ShopContext db = new ShopContext())
                {
                    res.Data = db.Clientes.OrderBy(e => e.Id).ToList();
                    res.Exito = 1;
                    return Ok(res);
                }
            }
            catch (Exception e)
            {
                res.Message = e.Message;
                return Ok(res);
            }*/
            return Ok();
        }
        [HttpPost]
        public IActionResult NewClient([FromBody] ClienteViewModel newClient)
        {
          /*  Status res = new Status();
            try
            {
                using (ShopContext db = new ShopContext())
                {
                    Cliente client = new Cliente();
                    client.Nombre = newClient.Nombre;
                    db.Clientes.Add(client);
                    db.SaveChanges();
                    res.Data = client;
                    res.Exito = 1;
                }
            }
            catch (Exception e)
            {
                res.Message = e.Message;
            }*/
            return Ok();
        }
        [HttpPatch("{id}")]
        public IActionResult EditClient(int id,[FromBody] ClienteViewModel updateClient)
        {
            /*Status res = new Status();
            try
            {
                using (ShopContext db = new ShopContext())
                {
                    var client = db.Clientes.Find(id);
                    client.Nombre = updateClient.Nombre;
                    db.Entry(client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    res.Data = client;
                    res.Exito = 1;
                }
            }
            catch (Exception e)
            {
                res.Message = e.Message;
            }*/
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            /*
            Status res = new Status();
            try
            {
                using (ShopContext db = new ShopContext())
                {
                    var clientExist = db.Clientes.Find(id);
                    //if (clientExist == null) BadRequest(); 
                    db.Clientes.Remove(clientExist);
                    db.SaveChanges();
                    res.Exito = 1;
                }
            }
            catch (Exception e)
            {
                res.Message = e.Message;
            }*/

            return Ok();
        }
    }
}