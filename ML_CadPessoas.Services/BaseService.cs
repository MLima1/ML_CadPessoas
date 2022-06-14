using ML_CadPessoas.Domain.Interfaces.IRepositories;
using ML_CadPessoas.Domain.Interfaces.IServices;
using System.Collections.Generic;

namespace ML_CadPessoas.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public void Alterar(T obj)
        {
            _repository.Alterar(obj);
        }

        public T BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public void Excluir(T obj)
        {
            _repository.Excluir(obj);
        }

        public void Inserir(T obj)
        {
            _repository.Inserir(obj);
        }
    }
}
