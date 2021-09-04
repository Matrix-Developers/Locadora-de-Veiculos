﻿using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Tests.ParceiroModule
{
    [TestClass]
    public class ParceiroControladorTest
    {
        ControladorParceiro controlador = null;
        Parceiro parceiro;
        public ParceiroControladorTest()
        {
            controlador = new ControladorParceiro();

            Db.Update("DELETE FROM [TBCUPOM_DESCONTO]");
            Db.Update("DELETE FROM [TBPARCEIRO]");
            Db.Update("DBCC CHECKIDENT('TBCUPOM_DESCONTO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBPARCEIRO', RESEED, 0)");
        }

        [TestMethod]
        public void DeveInserirUmParceiro()
        {
            //arrange
            parceiro = new Parceiro(0, "Nome Teste");

            //action
            controlador.InserirNovo(parceiro);

            //assert
            var parceiroEncontrado = controlador.SelecionarPorId(parceiro.Id);
            parceiroEncontrado.Should().Be(parceiro);
        }

        [TestMethod]
        public void DeveSelecionarDoisParceiros()
        {
            //arrange
            parceiro = new Parceiro(0, "Nome Teste");

            //action
            controlador.InserirNovo(parceiro);
            controlador.InserirNovo(parceiro);

            //assert
            List<Parceiro> parceiroEncontrado = controlador.SelecionarTodos();
            parceiroEncontrado.Count.Should().Be(2);
        }

        [TestMethod]
        public void DeveEditarUmParceiro()
        {
            //arrange
            parceiro = new Parceiro(0, "Nome Teste");
            Parceiro parceiroEditado = new Parceiro(0, "Nome Alterado");

            //action
            controlador.InserirNovo(parceiro);
            controlador.Editar(parceiro.Id, parceiroEditado);

            //assert
            Parceiro parceiroEncontrado = controlador.SelecionarPorId(parceiro.Id);
            parceiroEncontrado.Should().Be(parceiroEditado);
        }

        [TestMethod]
        public void DeveExcluirUmParceiro()
        {
            //arrange
            parceiro = new Parceiro(0, "Nome Teste");

            //action
            controlador.InserirNovo(parceiro);
            List<Parceiro> parceiroInserido = controlador.SelecionarTodos();
            controlador.Excluir(parceiro.Id);

            //assert
            List<Parceiro> bancoAposExclusao = controlador.SelecionarTodos();
            bancoAposExclusao.Count.Should().NotBe(parceiroInserido.Count);
        }
    }
}