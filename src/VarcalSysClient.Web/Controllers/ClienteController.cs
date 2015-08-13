using System;
using System.Web.Mvc;
using VarcalSysClient.App.Contracts;
using VarcalSysClient.App.Dto;
using VarcalSysClient.Web.Models;

namespace VarcalSysClient.Web.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(ClienteViewModelRegister model)
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                
                throw;
            }          
        }
    }
}