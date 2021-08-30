﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.WindowsApp.Features.Veiculos;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Veiculos;

namespace LocadoraDeVeiculos.WindowsApp.Features.ImagemVeiculo
{
    public partial class ImagemVeiculoForm : Form
    {
        private const long doisMB = 2097152;
        private const int voltar = -1;
        private const int avancar = 1;
        private int imagemAtual = 0;
        public List<Dominio.ImagemVeiculoModule.ImagemVeiculo> imagens;
        private readonly VeiculoForm telaBase;
        public ImagemVeiculoForm(VeiculoForm telaBase)
        {
            this.telaBase = telaBase;
            if (telaBase.imagensVeiculo == null)
                imagens = new List<Dominio.ImagemVeiculoModule.ImagemVeiculo>();
            else
                imagens = telaBase.imagensVeiculo;
            InitializeComponent();
            if (imagens.Count != 0)
                pctBoxImagem.Image = imagens[0].imagem;

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog()  == DialogResult.OK)
                {
                var imagem = openFileDialog.FileName;
                var tamanho = new FileInfo(imagem).Length;
                if (tamanho <= doisMB)
                {

                    imagens.Add(new Dominio.ImagemVeiculoModule.ImagemVeiculo(0, 0, (Bitmap)Image.FromFile(imagem)));
                    if (imagens.Count == 1)
                        AtualizarImagem();
                    else
                    {
                        MudarImagemAtual((imagens.Count() - 1));
                    }
                }
                else
                    MessageBox.Show("A imagem deve ser no máximo de 2MB!","Locadora de Veículos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MudarImagemAtual(int indice)
        {
            if (imagemAtual == 0 && indice == voltar) //<=======================|ir    para    a   ultima
                imagemAtual = imagens.Count() - 1;
            else if (imagemAtual + 1 == imagens.Count() && indice == avancar) //|ir    para   a  primeira
                imagemAtual = 0;
            else if (indice != 1 && indice != -1) //<===========================| vai  para  o   index  0
                imagemAtual = indice;
            else //<============================================================| só move no meio da list
                imagemAtual = imagemAtual + indice;

            AtualizarImagem();
        }

        private void AtualizarImagem()
        {
            if (imagens.Count != 0)
                pctBoxImagem.Image = imagens[imagemAtual].imagem;
            else
                pctBoxImagem.Image = default;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (imagens.Count() != 0)
                MudarImagemAtual(voltar);
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (imagens.Count() != 0)
                MudarImagemAtual(avancar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a imagem?", "Locadora de veículos",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (imagens.Count() != 0)
                {
                    imagens.RemoveAt(imagemAtual);
                    MudarImagemAtual(0);
                }
                else
                {
                    pctBoxImagem.Image = default;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                telaBase.AtualizarListaDeFotos(imagens);
            this.Close();
        }
    }
}