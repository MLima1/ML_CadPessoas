using Microsoft.EntityFrameworkCore;
using ML_CadPessoas.Domain.Interfaces.IRepositories;
using ML_CadPessoas.Infraestructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace ML_CadPessoas.Infraestructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DefaultContext _context;

        public BaseRepository(DefaultContext context)
        {
            _context = context;
        }
        public void Inserir(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }
        public void Alterar(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Excluir(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }
        public T BuscarPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _context.Set<T>().ToList();
        }

        

        
    }
}
