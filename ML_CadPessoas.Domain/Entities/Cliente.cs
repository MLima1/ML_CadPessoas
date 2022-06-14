
namespace ML_CadPessoas.Domain.Entities
{
    public  class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
