using CadastroDeVeiculo.Data.Contexto;
using CadastroDeVeiculo.Data.Repositorio;
using CadastroDeVeiculo.Dominio.Modelos;
using CadastroDeVeiculo.Dominio.Modelos.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace CadastroDeVeiculo.Teste
{
    public class Tests
    {
        private ProprietarioRepository _proprietarioRepository;
        private Banco _banco;

        [SetUp]
        public void Setup()
        {
            var servicos = new ServiceCollection();

            var nomeDoBancoDeDados = "meu_banco_" + DateTime.Now.ToFileTimeUtc();

            var bancoEmMemoria = new DbContextOptionsBuilder<Banco>()
                            .UseInMemoryDatabase(databaseName: nomeDoBancoDeDados)
                            .Options;

            servicos.AddDbContext<Banco>(options =>
            {
                options.UseInMemoryDatabase(databaseName: nomeDoBancoDeDados);
            });

            var construido = servicos.BuildServiceProvider();
            _banco = construido.GetService<Banco>();

            _proprietarioRepository = new ProprietarioRepository(construido.GetService<Banco>());
        }

        [Test]
        public async Task Teste_De_Integracao_E_Adicao()
        {
            //Arrange
            const int HA_ENTIDADE_NO_BANCO = 1;

            Proprietario andre = new()
            { Nome = "Andre", Endereco = "Teste", Documento = "aaaaaa", Email = "andr@yahoo.com", Status = EStatus.ATIVO};

            //Act
            await _proprietarioRepository.AdicionaAsync(andre);
            await _banco.SaveChangesAsync();


            var quantidade = await _proprietarioRepository.CountTotalAsync();

            //Assert
            Assert.AreEqual(quantidade, HA_ENTIDADE_NO_BANCO);
        }
    }
}