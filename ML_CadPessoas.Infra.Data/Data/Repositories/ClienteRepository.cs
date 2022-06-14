using ML_CadPessoas.Domain.Entities;
using ML_CadPessoas.Domain.Interfaces.IRepositories;
using ML_CadPessoas.Infraestructure.Context;

namespace ML_CadPessoas.Infraestructure.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DefaultContext _context;

        public ClienteRepository(DefaultContext context) : base(context)
        {
            _context = context;
        }
    }
}
