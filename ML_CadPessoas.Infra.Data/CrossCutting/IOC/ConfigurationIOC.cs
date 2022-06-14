using Autofac;
using AutoMapper;
using ML_CadPessoas.Domain.Interfaces.IRepositories;
using ML_CadPessoas.Domain.Interfaces.IServices;
using ML_CadPessoas.Domain.MappingProfile;
using ML_CadPessoas.Infraestructure.Repositories;
using ML_CadPessoas.Services;

namespace ML_CadPessoas.Infraestructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();

            builder.RegisterType<ClienteService>().As<IClienteService>();


            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToDTO());
            });
        }
    }
}
