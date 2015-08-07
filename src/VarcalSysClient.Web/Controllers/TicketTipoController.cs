using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Web.Controllers
{
    public class TicketTipoController : Controller
    {
        private readonly ITicketTipoDomainService _ticketTipoDomainService;

        public TicketTipoController(ITicketTipoDomainService ticketTipoDomainService)
        {
            _ticketTipoDomainService = ticketTipoDomainService;
        }

        // GET: TicketTipo
        public ActionResult Index()
        {
            var tp = _ticketTipoDomainService.GetAll();

            if (!tp.Any())
            {
                return View("Index", tp);
            }

            return View(tp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TicketTipo model)
        {
            
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                _ticketTipoDomainService.Add(model);
                _ticketTipoDomainService.Commit();

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                
                ViewBag.Error = exception.Message;
                return View(model);
            }
        }
    }
}