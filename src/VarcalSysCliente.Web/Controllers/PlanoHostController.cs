using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VarcalSysCliente.Domain.Contracts.Services;

namespace VarcalSysCliente.Web.Controllers
{
    public class PlanoHostController : Controller
    {
        private IPlanoHostDomainService _planoHostDomainService;

        public PlanoHostController(IPlanoHostDomainService planoHostDomainService)
        {
            _planoHostDomainService = planoHostDomainService;
        }

        // GET: PlanoHost
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetJson()
        {

            var planosHost = _planoHostDomainService.GetAsNoTracking();
            if (planosHost.Any())
            {
                return Json(planosHost, JsonRequestBehavior.AllowGet);
            }

            return null;
        }
    }
}