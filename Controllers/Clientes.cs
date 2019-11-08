using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTienda.Modelos;
using BackendTienda.Negocio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendTienda.Controllers
{
    [Route("api/[controller]")]
    public class Clientes : Controller
    {
        //metodo para login
        [HttpGet("ClientLogin")]
        public JsonResult LoginClient(string email, string pass)
        {
            ClientesModel InfClientesLgn = new ClientesModel();
            InfClientesLgn = Clientes_Business.LoginClientes(email, pass);
            return Json(InfClientesLgn);
        }
        //metodo para registrar un nuevo cliente
        [HttpPost("Registrar")]
        public JsonResult RegistrarCliente(ClientesModel regisCliente)
        {
            Clientes_Business.Registrar(regisCliente);
            return Json(regisCliente);
        }
    }
}
