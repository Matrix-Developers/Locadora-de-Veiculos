﻿using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculos>
    {
        //Nota: nome da tabela "TBGRUPOVEICULO" é incosistente com o nome das outras tabelas do banco.
        //      - talvez considerar renomear "TBGRUPOVEICULO" para "TBGRUPODEVEICULOS"
        private const string sqlInserirGrupoDeVeiculos =
                @"INSERT INTO TBGRUPOVEICULO
                (
	                [NOME],
	                [TAXAPLANODIARIO],
	                [TAXAKMCONTROLADO],
	                [TAXAKMLIVRE],
	                [QUANTIDADEQUILOMETROSKMCONTROLADO]
                )
                VALUES
                (
	                @NOME,
	                @TAXAPLANODIARIO,
	                @TAXAKMCONTROLADO,
	                @TAXAKMLIVRE,
	                @QUANTIDADEQUILOMETROSKMCONTROLADO
                );";

        private const string sqlEditarGrupoDeVeiculos =
                @"UPDATE TBGRUPOVEICULO 
                SET
	                [NOME] = @NOME,
	                [TAXAPLANODIARIO] = @TAXAPLANODIARIO,
	                [TAXAKMCONTROLADO] = @TAXAKMCONTROLADO,
	                [TAXAKMLIVRE] = @TAXAKMLIVRE,
	                [QUANTIDADEQUILOMETROSKMCONTROLADO] = @QUANTIDADEQUILOMETROSKMCONTROLADO
                WHERE [ID] = @ID;";

        private const string sqlExcluirGrupoDeVeiculos =
                @"DELETE FROM TBGRUPOVEICULO  WHERE [ID] = @ID;";

        private const string sqlSelecionarGrupoDeVeiculosPorId =
                @"SELECT * FROM TBGRUPOVEICULO WHERE [ID] = @ID;";

        private const string sqlSelecionarTodosGrupoDeVeiculoss =
                @"SELECT * FROM TBGRUPOVEICULO;";

        private const string sqlExisteGrupoDeVeiculos =
                @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBGRUPOVEICULO]
                WHERE 
                    [ID] = @ID";

        public override string InserirNovo(GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculos> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculos grupo in grupoDeVeiculosRegistrados)
            {
                if (registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculos> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculos grupo in grupoDeVeiculosRegistrados)
            {
                if (id != grupo.Id && registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoDeVeiculos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override GrupoDeVeiculos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoDeVeiculosPorId, ConverterEmGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override List<GrupoDeVeiculos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoDeVeiculoss, ConverterEmGrupoDeVeiculos);
        }

        private Dictionary<string, object> ObtemParametrosGrupoDeVeiculos(GrupoDeVeiculos grupoDeVeiculos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", grupoDeVeiculos.Id);
            parametros.Add("NOME", grupoDeVeiculos.Nome);
            parametros.Add("TAXAPLANODIARIO", grupoDeVeiculos.TaxaPlanoDiario);
            parametros.Add("TAXAKMCONTROLADO", grupoDeVeiculos.TaxaKmControlado);
            parametros.Add("TAXAKMLIVRE", grupoDeVeiculos.TaxaKmLivre);
            parametros.Add("QUANTIDADEQUILOMETROSKMCONTROLADO", grupoDeVeiculos.QuantidadeQuilometrosKmControlado);

            return parametros;
        }

        private GrupoDeVeiculos ConverterEmGrupoDeVeiculos(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]); ;
            string nome = Convert.ToString(reader["NOME"]); ;
            double taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            double taxaKmControlado = Convert.ToDouble(reader["TAXAKMCONTROLADO"]);
            double taxaKmLivre = Convert.ToDouble(reader["TAXAKMLIVRE"]);
            int quantidadeQuilometrosKmControlado = Convert.ToInt32(reader["QUANTIDADEQUILOMETROSKMCONTROLADO"]);

            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(id, nome, taxaPlanoDiario, taxaKmControlado, taxaKmLivre, quantidadeQuilometrosKmControlado);

            return grupoDeVeiculos;
        }
    }
}
