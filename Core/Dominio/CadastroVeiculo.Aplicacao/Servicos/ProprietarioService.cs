using AutoMapper;
using CadastroDeVeiculo.Dominio.Interface;
using CadastroVeiculo.Aplicacao.Interface;
using CadastroVeiculo.Aplicacao.Mapeamentos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroVeiculo.Aplicacao.Servicos
{
    public class ProprietarioService : IProprietarioService
    {
        private readonly IProprietarioRepository _proprietarioRepository;
        private readonly IMapper _mapper;

        public ProprietarioService(IProprietarioRepository proprietarioRepository, IMapper mapper)
        {
            _proprietarioRepository = proprietarioRepository;
            _mapper = mapper;
        }

        public async Task<(List<ProprietarioDTO> proprietariosQuePossuo, bool conseguiPegar, List<string> mensagensParaRetornar)> PegaTodosProprietariosAsync()
        {
            var proprietarios = await _proprietarioRepository.PegaTodosProprietariosAsync();
            var proprietariosMapeados = _mapper.Map<List<ProprietarioDTO>>(proprietarios.proprietariosQuePossuo);

            return (proprietariosMapeados, true, new List<string>());
        }
    }
}
