using CadastroDeVeiculo.Data.RepositorioConcreto;
using CadastroDeVeiculo.Dominio.Interface;
using CadastroDeVeiculo.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Data.Repositorio
{
    public class ProprietarioRepository : GenericoAsyncRepositorio<Proprietario>, IProprietarioRepository
    {
        const bool DEU_CERTO = true;
        List<string> mensagensARetornar = new();

        public ProprietarioRepository(Contexto.Banco contexto) : base(contexto)
        {

        }

        public async Task<(Proprietario proprietarioCriado, bool criadoComSucesso, List<string> mensagensParaRetornar)> 
            CriaProprietarioAsync(Proprietario proprietarioAInserirNoBanco)
        {
            await AdicionaAsync(proprietarioAInserirNoBanco);

            mensagensARetornar.Add("Deu certo!");
            return (proprietarioAInserirNoBanco, DEU_CERTO, mensagensARetornar);
        }

        public async Task<(List<Proprietario> proprietariosQuePossuo, bool conseguiPegar, List<string> mensagensParaRetornar)> PegaTodosProprietariosAsync()
        {
            var proprietarios = await Entidade.ToListAsync();

            return (proprietarios, DEU_CERTO, mensagensARetornar);
        }
    }
}
