using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.App.Contracts;
using VarcalSysCliente.App.Dto;
using VarcalSysCliente.Domain.Collections;
using VarcalSysCliente.Domain.Contracts.Services;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.App.Services
{
    public class ClienteAppService: IClienteAppService
    {
        private readonly IClienteDomainService _clienteDomainService;
        private readonly IPessoaFisicaDomainService _pessoaFisicaDomainService;
        private readonly IPessoaJuridicaDomainService _pessoaJuridicaDomainService;
        private readonly IEnderecoDomainService _enderecoDomainService;
        private readonly IContatoDomainService _contatoDomainService;
        private readonly IPlanoHostDomainService _planoHostDomainService;

        public ClienteAppService(IClienteDomainService clienteDomainService, IPessoaFisicaDomainService pessoaFisicaDomainService, IPessoaJuridicaDomainService pessoaJuridicaDomainService, IEnderecoDomainService enderecoDomainService, IContatoDomainService contatoDomainService, IPlanoHostDomainService planoHostDomainService)
        {
            _clienteDomainService = clienteDomainService;
            _pessoaFisicaDomainService = pessoaFisicaDomainService;
            _pessoaJuridicaDomainService = pessoaJuridicaDomainService;
            _enderecoDomainService = enderecoDomainService;
            _contatoDomainService = contatoDomainService;
            _planoHostDomainService = planoHostDomainService;
        }

        public void Registrar(ClienteDto clienteDto)
        {
            try
            {
                
                var endereco = new Endereco(clienteDto.Logradouro, clienteDto.Cidade, (Uf) clienteDto.UfId,clienteDto.Bairro);
                var contato = new Contato(clienteDto.Email, clienteDto.EmailCobranca, clienteDto.Telefone,
                    clienteDto.Celular);
                var planoHost = _planoHostDomainService.Get(clienteDto.PlanoHostId);

                if (clienteDto.PessoaTipo.Equals(PessoaTipo.Fisica))
                {
                    var pessoaFisica = new PessoaFisica(planoHost, clienteDto.Dominio, clienteDto.NomeRazaoSocial,
                        clienteDto.CpfCnpj, clienteDto.PessoaTipo, endereco, contato, clienteDto.RgInscEst);
                    _clienteDomainService.Add(pessoaFisica.Cliente);                   
                    _pessoaFisicaDomainService.Add(pessoaFisica);
                }
                else
                {
                    var pessoaJuridica = new PessoaJuridica(planoHost, clienteDto.Dominio, clienteDto.NomeRazaoSocial,
                        clienteDto.CpfCnpj, clienteDto.NomeResponsavel, clienteDto.PessoaTipo, endereco, contato, clienteDto.RgInscEst, clienteDto.NomeFantasia);
                    _clienteDomainService.Add(pessoaJuridica.Cliente);
                    _pessoaJuridicaDomainService.Add(pessoaJuridica);
                }

                _clienteDomainService.Commit();

            } 
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }

        public void Alterar(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ClienteCollection BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public ClienteCollection BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
