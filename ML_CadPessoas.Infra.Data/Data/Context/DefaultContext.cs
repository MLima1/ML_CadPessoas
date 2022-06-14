using Microsoft.EntityFrameworkCore;
using ML_CadPessoas.Domain.Entities;


namespace ML_CadPessoas.Infraestructure.Context
{
    public class DefaultContext : DbContext 
    {
        public DefaultContext()
        {
        }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Tbl_Cliente { get; set; }

    }
}
