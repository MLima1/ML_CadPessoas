using ML_CadPessoas.Domain.Entities;
using ML_CadPessoas.Domain.Interfaces.IRepositories;
using ML_CadPessoas.Domain.Interfaces.IServices;

namespace ML_CadPessoas.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
