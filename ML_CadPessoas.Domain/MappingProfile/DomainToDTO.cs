using AutoMapper;
using ML_CadPessoas.Domain.DTOs;
using ML_CadPessoas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ML_CadPessoas.Domain.MappingProfile
{
    public class DomainToDTO: Profile
    {
        public DomainToDTO()
        {
            CreateMap<Cliente, ClienteDTO>()
                .ForMember(x => x.Id, o => o.MapFrom(src => src.Id));
        }
    }
}
