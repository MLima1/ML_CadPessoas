using System;
using System.Collections.Generic;
using System.Text;

namespace ML_CadPessoas.Domain.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);
    }
}
