using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.App.Dto;
using VarcalSysCliente.Domain.Collections;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.App.Contracts
{
    public interface IClienteAppService
    {
        void Registrar(ClienteDto clienteDto);
        void Alterar(ClienteDto clienteDto);
        Cliente BuscarPorId(int id);
        ClienteCollection BuscarTodos();
        ClienteCollection BuscarTodosAtivos();
    }
}
