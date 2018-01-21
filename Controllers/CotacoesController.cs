using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteAPIRESTDapper.Data;

namespace TesteAPIRESTDapper.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        [HttpGet("{id}")]
        public Cotacao Get([FromServices]CotacoesDAO cotacoesDAO,string id)
        {
            return cotacoesDAO.Obter(id);
        }
    }
}