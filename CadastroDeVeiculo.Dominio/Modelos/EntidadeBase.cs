using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Dominio.Modelos
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract Task<(bool valido, List<string> mensagensParaRetornar)> ValidarModeloAsync();
    }
}
