using CadastroVeiculo.Aplicacao.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo.Aplicacao.Interface
{
    public interface IProprietarioService
    {
        Task<(List<ProprietarioDTO> proprietariosQuePossuo, bool conseguiPegar, List<string> mensagensParaRetornar)> PegaTodosProprietariosAsync();
    }
}
