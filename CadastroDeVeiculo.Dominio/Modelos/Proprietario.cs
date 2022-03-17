using CadastroDeVeiculo.Dominio.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Dominio.Modelos
{
    public class Proprietario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public EStatus Status { get; set; }

        public override async Task<(bool valido, List<string> mensagensParaRetornar)> ValidarModeloAsync()
        {

            return await Task.Run(() =>
            {

                const bool VALIDO = true;
                const bool INVALIDO = false;
                List<string> mensagensParaRetornar = new();

                if (string.IsNullOrWhiteSpace(Nome))
                {
                    mensagensParaRetornar.Add("Nome não pode ser vazio!");
                    return (INVALIDO, mensagensParaRetornar);
                }

                mensagensParaRetornar.Add("Tudo ok!");
                return (VALIDO, mensagensParaRetornar);
            });


        }
    }
}
