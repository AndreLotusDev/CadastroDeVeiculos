using AutoMapper;
using CadastroDeVeiculo.Dominio.Modelos;
using CadastroVeiculo.Aplicacao.Mapeamentos;

namespace CadastroVeiculo.Aplicacao.Perfil
{
    public class Mapeamentos : Profile
    {
        public Mapeamentos()
        {
            CreateMap<Proprietario, ProprietarioDTO>();
            CreateMap<ProprietarioDTO, Proprietario>();
        }
    }
}
