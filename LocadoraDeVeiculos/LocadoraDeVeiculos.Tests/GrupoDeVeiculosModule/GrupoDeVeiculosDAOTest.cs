﻿using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.IntegrationTests.GrupoDeVeiculosModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class GrupoDeVeiculosDAOTest
    {
        private GrupoDeVeiculosAppService GrupoDeVeiculosAppService;
        private GrupoDeVeiculo grupoDeVeiculos;
        private string nome;
        private string nomeEditado;
        private double taxaPlanoDiario;
        private double taxaKmDiario;
        private double taxaPlanoControlado;
        private int limiteKmControlado;
        private double taxaKmExcedidoControlado;
        private double taxaPlanoLivre;

        [TestInitialize]
        public void Setup()
        {
            Configuracao();
            GrupoDeVeiculosAppService = new GrupoDeVeiculosAppService(new GrupoDeVeiculosRepository());
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserir_GrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
                .ComNome(nome)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
           .ComNome(nome)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
           .ComNome(nomeEditado)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);
            GrupoDeVeiculosAppService.EditarGrupoDeVeiculo(grupoDeVeiculos.Id, grupoDeVeiculosEditado);

            //assert
            var grupoDeVeiculosAtualizado = GrupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(grupoDeVeiculosEditado);
        }

        [TestMethod]
        public void DeveExcluir_GrupoDeVeiculos()
        {
            //action
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
          .ComNome(nome)
          .ComTaxaPlanoDiario(taxaPlanoDiario)
          .ComTaxaPorKmDiario(taxaKmDiario)
          .ComTaxaPlanoControlado(taxaPlanoControlado)
          .ComLimiteKmControlado(limiteKmControlado)
          .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
          .ComTaxaPlanoLivre(taxaPlanoLivre)
          .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);
            GrupoDeVeiculosAppService.ExcluirGrupoDeVeiculo(grupoDeVeiculos.Id);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculosPorId()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();
            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();
            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
           .ComNome(nomeEditado)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculosEditado);
            var grupoDeVeiculosAgrupado = GrupoDeVeiculosAppService.SelecionarTodosGrupoDeVeiculo();

            //assert
            grupoDeVeiculosAgrupado.Should().HaveCount(2);
            grupoDeVeiculosAgrupado[0].Should().Be(grupoDeVeiculos);
            grupoDeVeiculosAgrupado[1].Should().Be(grupoDeVeiculosEditado);
        }

        [TestMethod]
        public void DeveRetornarTrue_QuandoExisteGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);

            //assert
            bool existeGrupoDeVeiculos = GrupoDeVeiculosAppService.ExisteGrupoDeVeiculo(grupoDeVeiculos.Id);
            existeGrupoDeVeiculos.Should().BeTrue();
        }

        [TestMethod]
        public void DeveRetornarFalse_QuandoNaoExisteGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();

            //action
            bool existeGrupoDeVeiculos = GrupoDeVeiculosAppService.ExisteGrupoDeVeiculo(grupoDeVeiculos.Id);

            //assert
            existeGrupoDeVeiculos.Should().BeFalse();
        }

        [TestMethod]
        public void NaoDeveInserir_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
              .ComNome(nome)
              .ComTaxaPlanoDiario(taxaPlanoDiario)
              .ComTaxaPorKmDiario(taxaKmDiario)
              .ComTaxaPlanoControlado(taxaPlanoControlado)
              .ComLimiteKmControlado(limiteKmControlado)
              .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
              .ComTaxaPlanoLivre(taxaPlanoLivre)
              .Build();
            var grupoDeVeiculosidentico = new GrupoDeVeiculosDataBuilder()
              .ComNome(nome)
              .ComTaxaPlanoDiario(taxaPlanoDiario)
              .ComTaxaPorKmDiario(taxaKmDiario)
              .ComTaxaPlanoControlado(taxaPlanoControlado)
              .ComLimiteKmControlado(limiteKmControlado)
              .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
              .ComTaxaPlanoLivre(taxaPlanoLivre)
              .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);
            string resposta = GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculosidentico);

            //assert
            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }

        [TestMethod]
        public void NaoDeveAtualizar_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
                .ComNome(nome)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
                .ComNome(nomeEditado)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            var grupoDeVeiculosConflitante = new GrupoDeVeiculosDataBuilder()
                .ComNome(nomeEditado)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            //action
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculos);
            GrupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(grupoDeVeiculosEditado);

            //assert
            string resposta = GrupoDeVeiculosAppService.EditarGrupoDeVeiculo(grupoDeVeiculos.Id, grupoDeVeiculosConflitante);
            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }

        private void Configuracao()
        {
            nome = "nome";
            nomeEditado = "emon";
            taxaPlanoDiario = 12.50f;
            taxaKmDiario = 25.73f;
            taxaPlanoControlado = 13.99f;
            limiteKmControlado = 200;
            taxaKmExcedidoControlado = 11f;
            taxaPlanoLivre = 50.5f;
        }
    }
}