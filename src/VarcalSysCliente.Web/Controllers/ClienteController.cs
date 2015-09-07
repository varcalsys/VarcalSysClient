using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VarcalSysCliente.App.Contracts;
using VarcalSysCliente.App.Dto;
using VarcalSysCliente.Domain.Contracts.Services;
using VarcalSysCliente.Web.Models;

namespace VarcalSysCliente.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IPlanoHostDomainService _planoHostDomainService;

        public ClienteController(IClienteAppService clienteAppService, IPlanoHostDomainService planoHostDomainService)
        {
            _clienteAppService = clienteAppService;
            _planoHostDomainService = planoHostDomainService;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Registrar(ClienteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Erro ao tentar se registrar!! Tente novamente";
                return View(model);
            }

            try
            {

                var clienteDto = new ClienteDto()
                {
                    Dominio = model.Dominio,
                    PessoaTipo = model.PessoaTipo,
                    NomeRazaoSocial = model.NomeRazaoSocial,
                    CpfCnpj = model.CpfCnpj,
                    RgInscEst = model.RgInscEst,
                    NomeFantasia = model.NomeFantasia,
                    NomeResponsavel = model.NomeResponsavel,
                    Logradouro = model.Logradouro,
                    Bairro = model.Bairro,
                    Cidade = model.Cidade,
                    UfId = (int)model.Uf,
                    Email = model.Email,
                    EmailCobranca = model.EmailCobranca,
                    Telefone = model.Telefone,
                    Celular = model.Celular,
                    Senha = model.Senha,
                    PlanoHostId = model.PlanoHostId
                };

                _clienteAppService.Registrar(clienteDto);

                var planoHost = _planoHostDomainService.Get(model.PlanoHostId);

                return View("Pagamento", new PlanoHostViewModel(planoHost));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }            
        }

        
    }
}