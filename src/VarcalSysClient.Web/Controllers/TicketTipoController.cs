using System.Web.Mvc;

namespace VarcalSysClient.Web.Controllers
{
    public class TicketTipoController : Controller
    {
        //private readonly I _ticketTipoDomainService;

        //public TicketTipoController(ITicketTipoDomainService ticketTipoDomainService)
        //{
        //    _ticketTipoDomainService = ticketTipoDomainService;
        //}

        //// GET: TicketTipo
        //public ActionResult Index()
        //{
        //    var tp = _ticketTipoDomainService.GetAll();

        //    if (!tp.Any())
        //    {
        //        return View("Index", tp);
        //    }

        //    return View(tp);
        //}

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(TicketTipoViewModel model)
        //{
            
        //    try
        //    {

        //        if (!ModelState.IsValid)
        //        {
        //            return View(model);
        //        }

        //        var ticketTipo = new TicketTipo
        //        {
        //            Descricao = model.Descricao
        //        };

        //        _ticketTipoDomainService.Add(ticketTipo);
        //        _ticketTipoDomainService.Commit();

        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception exception)
        //    {
                
        //        ViewBag.Error = exception.Message;
        //        return View(model);
        //    }
        //}
    }
}