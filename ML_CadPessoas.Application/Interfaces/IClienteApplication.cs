using ML_CadPessoas.Application.DTOs;
using System.Collections.Generic;

namespace ML_CadPessoas.Application.Interfaces
{
    internal interface IClienteApplication
    {
        void Inserir(ClienteDTO clienteDTO);
        void Alterar(ClienteDTO clienteDTO);
        void Remover(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> BuscarTodos();
        ClienteDTO BuscarPorId(int id);
    }
}
