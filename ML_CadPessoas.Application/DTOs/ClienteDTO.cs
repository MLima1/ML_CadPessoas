using System;
using System.Collections.Generic;
using System.Text;

namespace ML_CadPessoas.Application.DTOs
{
    public class ClienteDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
