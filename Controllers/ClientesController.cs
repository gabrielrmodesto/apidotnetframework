using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIProject.Models;

namespace APIProject.Controllers
{
    public class ClientesController : ApiController
    {
        // Metodo de listagem de clientes
        private static List<Cliente> clientes = new List<Cliente>();

        // [HttpGet]
        public List<Cliente> Get()
        {
            return clientes;
        }

        // [FromBody]
        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
