using System;
using VarcalSysClient.App.Contracts;
using VarcalSysClient.App.Dto;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.App
{
    public class ClienteAppService: IClienteAppService
    {
        private readonly IClienteDomainService _clienteDomainService;
        private readonly IPessoaDomainService _pessoaDomainService;
        private readonly IPessoaFisicaDomainService _pessoaFisicaDomainService;
        private readonly IPessoaJuridicaDomainService _pessoaJuridicaDomainService;

        public ClienteAppService(IClienteDomainService clienteDomainService, IPessoaDomainService pessoaDomainService, IPessoaFisicaDomainService pessoaFisicaDomainService, IPessoaJuridicaDomainService pessoaJuridicaDomainService)
        {
            _clienteDomainService = clienteDomainService;
            _pessoaDomainService = pessoaDomainService;
            _pessoaFisicaDomainService = pessoaFisicaDomainService;
            _pessoaJuridicaDomainService = pessoaJuridicaDomainService;
        }

        public void Resgistrar(ClienteDto clienteDto)
        {
            try
            {
                var cliente = new Cliente
                {
                    Pessoa = clienteDto.Pessoa,
                    PlanosHost = clienteDto.PlanosHost
                };

                _clienteDomainService.Add(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
