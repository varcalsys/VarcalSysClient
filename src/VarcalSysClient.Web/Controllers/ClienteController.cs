using System;
using System.Web.Mvc;
using VarcalSysClient.App.Contracts;
using VarcalSysClient.App.Dto;

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
            try
            {
                _clienteAppService.Resgistrar(new ClienteDto());

                return RedirectToAction("Index", "TicketTipo");
            }
            catch (Exception)
            {
                
                throw;
            }          
        }
    }
}