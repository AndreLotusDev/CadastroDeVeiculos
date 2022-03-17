using CadastroDeVeiculo.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Dominio.Interface
{
    public interface IProprietarioRepository
    {
        Task<(Proprietario proprietarioCriado, bool criadoComSucesso, List<string> mensagensParaRetornar)> CriaProprietarioAsync(Proprietario proprietarioAInserirNoBanco);
        Task<(List<Proprietario> proprietariosQuePossuo, bool conseguiPegar, List<string> mensagensParaRetornar)> PegaTodosProprietariosAsync();
    }
}
