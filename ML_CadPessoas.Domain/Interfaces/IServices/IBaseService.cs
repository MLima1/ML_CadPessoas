
using System.Collections.Generic;

namespace ML_CadPessoas.Domain.Interfaces.IServices
{
    public interface IBaseService<T> where T : class
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);
    }
}
