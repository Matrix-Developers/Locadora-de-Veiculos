﻿using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.VeiculoModule
{
    public class Veiculo : EntidadeBase
    {
        public string modelo;
        public string grupoVeiculos;
        public string placa;
        public string chassi;
        public string marca;
        public string cor;
        public string tipoCombustivel;
        public string capacidadeTanque;
        public int ano;
        public double kilometragem;
        public int numeroPortas;
        public int capacidadePessoas;
        public string tamanhoPortaMala;
        public bool temArCondicionado;
        public bool temDirecaoHidraulica;
        public bool temFreiosAbs;

        public Veiculo(int id,string modelo, string grupoVeiculos, string placa, string chassi, string marca, string cor, string tipoCombustivel, string capacidadeTanque, int ano, double kilometragem, int numeroPortas, int capacidadePessoas, string tamanhoPortaMala)
        {
            this.id = id;
            this.modelo = modelo;
            this.grupoVeiculos = grupoVeiculos;
            this.placa = placa;
            this.chassi = chassi;
            this.marca = marca;
            this.cor = cor;
            this.tipoCombustivel = tipoCombustivel;
            this.capacidadeTanque = capacidadeTanque;
            this.ano = ano;
            this.kilometragem = kilometragem;
            this.numeroPortas = numeroPortas;
            this.capacidadePessoas = capacidadePessoas;
            this.tamanhoPortaMala = tamanhoPortaMala;
        }

        public override string Validar()
        {
            int seZeroehValido = 0;
            string resultadoValidacao = "";

            if (this.modelo.Length <= 0)
            {
                resultadoValidacao = "O campo modelo não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (this.grupoVeiculos.Length <= 0)
            {
                resultadoValidacao += "O campo grupo de veículos não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (this.placa.Length <= 0)
            {
                resultadoValidacao += "O campo placa não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.chassi.Length <= 0)
            {
                resultadoValidacao += "O campo chassi não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.marca.Length <= 0)
            {
                resultadoValidacao += "O campo marca não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.cor.Length <= 0)
            {
                resultadoValidacao += "O campo cor não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.tipoCombustivel.Length <= 0)
            {
                resultadoValidacao += "O campo tipo de combústivel não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.capacidadeTanque.Length <= 0)
            {
                resultadoValidacao += "O campo capacidade de tanque não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.ano <= 0)
            {
                resultadoValidacao += "O campo ano não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.kilometragem <= 0)
            {
                resultadoValidacao += "O campo kilometragem não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.numeroPortas <= 0)
            {
                resultadoValidacao += "O campo numero de portas não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.capacidadePessoas <= 0)
            {
                resultadoValidacao += "O campo capacidades de pessoas não pode ser vazio!\n";
                seZeroehValido++;
            }

            if (this.tamanhoPortaMala.Length <= 0)
            {
                resultadoValidacao += "O campo tamanho do porta mala não pode ser vazio!\n";
                seZeroehValido++;
            }
            if (seZeroehValido == 0)
            {
                resultadoValidacao = "VALIDO";
            }
                return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return obj is Veiculo veiculo &&
                   id == veiculo.id &&
                   modelo == veiculo.modelo &&
                   grupoVeiculos == veiculo.grupoVeiculos &&
                   placa == veiculo.placa &&
                   chassi == veiculo.chassi &&
                   marca == veiculo.marca &&
                   cor == veiculo.cor &&
                   tipoCombustivel == veiculo.tipoCombustivel &&
                   capacidadeTanque == veiculo.capacidadeTanque &&
                   ano == veiculo.ano &&
                   kilometragem == veiculo.kilometragem &&
                   numeroPortas == veiculo.numeroPortas &&
                   capacidadePessoas == veiculo.capacidadePessoas &&
                   tamanhoPortaMala == veiculo.tamanhoPortaMala &&
                   temArCondicionado == veiculo.temArCondicionado &&
                   temDirecaoHidraulica == veiculo.temDirecaoHidraulica &&
                   temFreiosAbs == veiculo.temFreiosAbs;
        }

        public override int GetHashCode()
        {
            int hashCode = -1048936057;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(modelo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(grupoVeiculos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(placa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(chassi);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(marca);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipoCombustivel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(capacidadeTanque);
            hashCode = hashCode * -1521134295 + ano.GetHashCode();
            hashCode = hashCode * -1521134295 + kilometragem.GetHashCode();
            hashCode = hashCode * -1521134295 + numeroPortas.GetHashCode();
            hashCode = hashCode * -1521134295 + capacidadePessoas.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tamanhoPortaMala);
            hashCode = hashCode * -1521134295 + temArCondicionado.GetHashCode();
            hashCode = hashCode * -1521134295 + temDirecaoHidraulica.GetHashCode();
            hashCode = hashCode * -1521134295 + temFreiosAbs.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Veiculo = [{id}, {modelo}, {grupoVeiculos}, {placa}, {chassi}, {marca}, {cor}, {tipoCombustivel}, {capacidadeTanque}, {ano}, {kilometragem}, {numeroPortas}, {capacidadePessoas}, {tamanhoPortaMala}]";
        }
    }
 
}
