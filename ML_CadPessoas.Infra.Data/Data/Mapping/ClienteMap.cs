using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ML_CadPessoas.Domain.Entities;

namespace ML_CadPessoas.Infraestructure.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //builder.ToTable("Tbl_Cliente");

            //builder.HasKey(k => k.Id);

            //builder.Property(x => x.Id).IsRequired().HasColumnName(id_cliente);
            //builder.Property(x => x.Nome).IsRequired().HasMaxLenght(120).HasColumnName(nome_cliente);
            //builder.Property(x => x.Idade).IsRequired().HasColumnName(idade_cliente);
            //builder.Property(x => x.Sexo).IsRequired().HasColumnName(sexo_cliente);
            //builder.Property(x => x.Cidade).IsRequired().HasColumnName(cidade_cliente);
            //builder.Property(x => x.Uf).IsRequired().HasColumnName(uf_cliente);
        }
    }
}
