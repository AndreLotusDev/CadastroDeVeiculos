using CadastroDeVeiculo.Dominio.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo.Aplicacao.Mapeamentos
{
    /// <summary>
    /// Essa classe nao possui documento para proteger o usuario pela LGPD
    /// </summary>
    public class ProprietarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public EStatus Status { get; set; }
    }
}
