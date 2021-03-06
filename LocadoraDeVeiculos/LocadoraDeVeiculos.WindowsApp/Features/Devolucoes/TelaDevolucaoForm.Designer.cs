
namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    partial class TelaDevolucaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.brnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxLocacao = new System.Windows.Forms.GroupBox();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.lblServicosSelecionados = new System.Windows.Forms.Label();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.cLBoxServicosSelecionados = new System.Windows.Forms.CheckedListBox();
            this.txtDataDevolucao = new System.Windows.Forms.TextBox();
            this.txtDataLocacao = new System.Windows.Forms.TextBox();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblDataLocacao = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.gBoxDevolucao = new System.Windows.Forms.GroupBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.lblEncerrar = new System.Windows.Forms.Label();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.rBtn01 = new System.Windows.Forms.RadioButton();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.rBtn11 = new System.Windows.Forms.RadioButton();
            this.rBtn34 = new System.Windows.Forms.RadioButton();
            this.rBtn12 = new System.Windows.Forms.RadioButton();
            this.rBtn14 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.btnSelecionarServicos = new System.Windows.Forms.Button();
            this.lblQtdTanque = new System.Windows.Forms.Label();
            this.cBoxQtdTanque = new System.Windows.Forms.ComboBox();
            this.lblValorCombustivel = new System.Windows.Forms.Label();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.gBoxLocacao.SuspendLayout();
            this.gBoxDevolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(357, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Devolução de Veículo";
            // 
            // brnConfirmar
            // 
            this.brnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.brnConfirmar.Location = new System.Drawing.Point(729, 408);
            this.brnConfirmar.Name = "brnConfirmar";
            this.brnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.brnConfirmar.TabIndex = 22;
            this.brnConfirmar.Text = "Confirmar";
            this.brnConfirmar.UseVisualStyleBackColor = true;
            this.brnConfirmar.Click += new System.EventHandler(this.BrnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(810, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gBoxLocacao
            // 
            this.gBoxLocacao.Controls.Add(this.txtKmInicial);
            this.gBoxLocacao.Controls.Add(this.lblServicosSelecionados);
            this.gBoxLocacao.Controls.Add(this.lblKmInicial);
            this.gBoxLocacao.Controls.Add(this.cLBoxServicosSelecionados);
            this.gBoxLocacao.Controls.Add(this.txtDataDevolucao);
            this.gBoxLocacao.Controls.Add(this.txtDataLocacao);
            this.gBoxLocacao.Controls.Add(this.txtCondutor);
            this.gBoxLocacao.Controls.Add(this.txtCliente);
            this.gBoxLocacao.Controls.Add(this.txtPlano);
            this.gBoxLocacao.Controls.Add(this.txtVeiculo);
            this.gBoxLocacao.Controls.Add(this.txtFuncionario);
            this.gBoxLocacao.Controls.Add(this.lblPlano);
            this.gBoxLocacao.Controls.Add(this.lblVeiculo);
            this.gBoxLocacao.Controls.Add(this.lblDataDevolucao);
            this.gBoxLocacao.Controls.Add(this.lblDataLocacao);
            this.gBoxLocacao.Controls.Add(this.lblCondutor);
            this.gBoxLocacao.Controls.Add(this.lblCliente);
            this.gBoxLocacao.Controls.Add(this.lblFuncionario);
            this.gBoxLocacao.Controls.Add(this.lblId);
            this.gBoxLocacao.Controls.Add(this.txtId);
            this.gBoxLocacao.Enabled = false;
            this.gBoxLocacao.Location = new System.Drawing.Point(12, 83);
            this.gBoxLocacao.Name = "gBoxLocacao";
            this.gBoxLocacao.Size = new System.Drawing.Size(433, 312);
            this.gBoxLocacao.TabIndex = 20;
            this.gBoxLocacao.TabStop = false;
            this.gBoxLocacao.Text = "Dados da locação";
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKmInicial.Enabled = false;
            this.txtKmInicial.Location = new System.Drawing.Point(284, 19);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(141, 20);
            this.txtKmInicial.TabIndex = 25;
            // 
            // lblServicosSelecionados
            // 
            this.lblServicosSelecionados.AutoSize = true;
            this.lblServicosSelecionados.Location = new System.Drawing.Point(35, 204);
            this.lblServicosSelecionados.Name = "lblServicosSelecionados";
            this.lblServicosSelecionados.Size = new System.Drawing.Size(48, 13);
            this.lblServicosSelecionados.TabIndex = 31;
            this.lblServicosSelecionados.Text = "Serviços";
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Location = new System.Drawing.Point(226, 22);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(52, 13);
            this.lblKmInicial.TabIndex = 24;
            this.lblKmInicial.Text = "Km Inicial";
            // 
            // cLBoxServicosSelecionados
            // 
            this.cLBoxServicosSelecionados.FormattingEnabled = true;
            this.cLBoxServicosSelecionados.Location = new System.Drawing.Point(89, 204);
            this.cLBoxServicosSelecionados.Name = "cLBoxServicosSelecionados";
            this.cLBoxServicosSelecionados.Size = new System.Drawing.Size(338, 79);
            this.cLBoxServicosSelecionados.TabIndex = 30;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Location = new System.Drawing.Point(284, 175);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(143, 20);
            this.txtDataDevolucao.TabIndex = 25;
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Location = new System.Drawing.Point(89, 175);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(121, 20);
            this.txtDataLocacao.TabIndex = 29;
            // 
            // txtCondutor
            // 
            this.txtCondutor.Location = new System.Drawing.Point(89, 149);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(338, 20);
            this.txtCondutor.TabIndex = 28;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(89, 123);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(338, 20);
            this.txtCliente.TabIndex = 27;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(89, 97);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(338, 20);
            this.txtPlano.TabIndex = 26;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(89, 71);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(338, 20);
            this.txtVeiculo.TabIndex = 25;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(89, 45);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(338, 20);
            this.txtFuncionario.TabIndex = 16;
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(49, 100);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 13;
            this.lblPlano.Text = "Plano";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(39, 74);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lblVeiculo.TabIndex = 12;
            this.lblVeiculo.Text = "Veículo";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(230, 178);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(48, 13);
            this.lblDataDevolucao.TabIndex = 11;
            this.lblDataDevolucao.Text = "Previsao";
            // 
            // lblDataLocacao
            // 
            this.lblDataLocacao.AutoSize = true;
            this.lblDataLocacao.Location = new System.Drawing.Point(34, 178);
            this.lblDataLocacao.Name = "lblDataLocacao";
            this.lblDataLocacao.Size = new System.Drawing.Size(49, 13);
            this.lblDataLocacao.TabIndex = 10;
            this.lblDataLocacao.Text = "Locação";
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Location = new System.Drawing.Point(33, 152);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(50, 13);
            this.lblCondutor.TabIndex = 9;
            this.lblCondutor.Text = "Condutor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(44, 126);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(21, 48);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 7;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(65, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "0";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(327, 278);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 17;
            this.txtValorTotal.Text = "0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(215, 278);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(116, 16);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Preço Total: R$";
            // 
            // gBoxDevolucao
            // 
            this.gBoxDevolucao.Controls.Add(this.txtValorInicial);
            this.gBoxDevolucao.Controls.Add(this.lblValorInicial);
            this.gBoxDevolucao.Controls.Add(this.lblEncerrar);
            this.gBoxDevolucao.Controls.Add(this.dtDevolucao);
            this.gBoxDevolucao.Controls.Add(this.rBtn01);
            this.gBoxDevolucao.Controls.Add(this.lblFull);
            this.gBoxDevolucao.Controls.Add(this.lblEmpty);
            this.gBoxDevolucao.Controls.Add(this.rBtn11);
            this.gBoxDevolucao.Controls.Add(this.rBtn34);
            this.gBoxDevolucao.Controls.Add(this.rBtn12);
            this.gBoxDevolucao.Controls.Add(this.rBtn14);
            this.gBoxDevolucao.Controls.Add(this.pictureBox1);
            this.gBoxDevolucao.Controls.Add(this.lblKmFinal);
            this.gBoxDevolucao.Controls.Add(this.txtKmFinal);
            this.gBoxDevolucao.Controls.Add(this.lblServicos);
            this.gBoxDevolucao.Controls.Add(this.btnSelecionarServicos);
            this.gBoxDevolucao.Controls.Add(this.lblQtdTanque);
            this.gBoxDevolucao.Controls.Add(this.cBoxQtdTanque);
            this.gBoxDevolucao.Controls.Add(this.lblValorCombustivel);
            this.gBoxDevolucao.Controls.Add(this.txtValorCombustivel);
            this.gBoxDevolucao.Controls.Add(this.txtValorTotal);
            this.gBoxDevolucao.Controls.Add(this.lblValorTotal);
            this.gBoxDevolucao.Location = new System.Drawing.Point(451, 83);
            this.gBoxDevolucao.Name = "gBoxDevolucao";
            this.gBoxDevolucao.Size = new System.Drawing.Size(433, 312);
            this.gBoxDevolucao.TabIndex = 24;
            this.gBoxDevolucao.TabStop = false;
            this.gBoxDevolucao.Text = "Devolução";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorInicial.Enabled = false;
            this.txtValorInicial.Location = new System.Drawing.Point(327, 252);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(100, 20);
            this.txtValorInicial.TabIndex = 35;
            this.txtValorInicial.Text = "0";
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(215, 254);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(117, 16);
            this.lblValorInicial.TabIndex = 34;
            this.lblValorInicial.Text = "Valor Inicial: R$";
            // 
            // lblEncerrar
            // 
            this.lblEncerrar.AutoSize = true;
            this.lblEncerrar.Location = new System.Drawing.Point(8, 217);
            this.lblEncerrar.Name = "lblEncerrar";
            this.lblEncerrar.Size = new System.Drawing.Size(59, 13);
            this.lblEncerrar.TabIndex = 33;
            this.lblEncerrar.Text = "Devolução";
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDevolucao.Location = new System.Drawing.Point(73, 214);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(129, 20);
            this.dtDevolucao.TabIndex = 32;
            this.dtDevolucao.ValueChanged += new System.EventHandler(this.DtDevolucao_ValueChanged);
            // 
            // rBtn01
            // 
            this.rBtn01.AutoSize = true;
            this.rBtn01.Location = new System.Drawing.Point(112, 158);
            this.rBtn01.Name = "rBtn01";
            this.rBtn01.Size = new System.Drawing.Size(14, 13);
            this.rBtn01.TabIndex = 25;
            this.rBtn01.TabStop = true;
            this.rBtn01.UseVisualStyleBackColor = true;
            this.rBtn01.CheckedChanged += new System.EventHandler(this.RBtn01_CheckedChanged);
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFull.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFull.Location = new System.Drawing.Point(295, 185);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(17, 16);
            this.lblFull.TabIndex = 31;
            this.lblFull.Text = "F";
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(139, 185);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(18, 16);
            this.lblEmpty.TabIndex = 30;
            this.lblEmpty.Text = "E";
            // 
            // rBtn11
            // 
            this.rBtn11.AutoSize = true;
            this.rBtn11.Location = new System.Drawing.Point(324, 158);
            this.rBtn11.Name = "rBtn11";
            this.rBtn11.Size = new System.Drawing.Size(14, 13);
            this.rBtn11.TabIndex = 29;
            this.rBtn11.TabStop = true;
            this.rBtn11.UseVisualStyleBackColor = true;
            this.rBtn11.CheckedChanged += new System.EventHandler(this.RBtn11_CheckedChanged);
            // 
            // rBtn34
            // 
            this.rBtn34.AutoSize = true;
            this.rBtn34.Location = new System.Drawing.Point(279, 117);
            this.rBtn34.Name = "rBtn34";
            this.rBtn34.Size = new System.Drawing.Size(14, 13);
            this.rBtn34.TabIndex = 28;
            this.rBtn34.TabStop = true;
            this.rBtn34.UseVisualStyleBackColor = true;
            this.rBtn34.CheckedChanged += new System.EventHandler(this.RBtn34_CheckedChanged);
            // 
            // rBtn12
            // 
            this.rBtn12.AutoSize = true;
            this.rBtn12.Location = new System.Drawing.Point(218, 102);
            this.rBtn12.Name = "rBtn12";
            this.rBtn12.Size = new System.Drawing.Size(14, 13);
            this.rBtn12.TabIndex = 27;
            this.rBtn12.TabStop = true;
            this.rBtn12.UseVisualStyleBackColor = true;
            this.rBtn12.CheckedChanged += new System.EventHandler(this.RBtn12_CheckedChanged);
            // 
            // rBtn14
            // 
            this.rBtn14.AutoSize = true;
            this.rBtn14.Location = new System.Drawing.Point(158, 117);
            this.rBtn14.Name = "rBtn14";
            this.rBtn14.Size = new System.Drawing.Size(14, 13);
            this.rBtn14.TabIndex = 26;
            this.rBtn14.TabStop = true;
            this.rBtn14.UseVisualStyleBackColor = true;
            this.rBtn14.CheckedChanged += new System.EventHandler(this.RBtn14_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraDeVeiculos.WindowsApp.Properties.Resources.FuelGauge1;
            this.pictureBox1.Location = new System.Drawing.Point(122, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.Location = new System.Drawing.Point(8, 47);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(58, 13);
            this.lblKmFinal.TabIndex = 25;
            this.lblKmFinal.Text = "Km rodado";
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(72, 45);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(141, 20);
            this.txtKmFinal.TabIndex = 24;
            this.txtKmFinal.Text = "0";
            this.txtKmFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKmFinal_KeyPress);
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(240, 47);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(99, 13);
            this.lblServicos.TabIndex = 23;
            this.lblServicos.Text = "Serviços Adicionais";
            // 
            // btnSelecionarServicos
            // 
            this.btnSelecionarServicos.Location = new System.Drawing.Point(344, 43);
            this.btnSelecionarServicos.Name = "btnSelecionarServicos";
            this.btnSelecionarServicos.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarServicos.TabIndex = 22;
            this.btnSelecionarServicos.Text = "Selecionar";
            this.btnSelecionarServicos.UseVisualStyleBackColor = true;
            this.btnSelecionarServicos.Click += new System.EventHandler(this.BtnSelecionarServicos_Click);
            // 
            // lblQtdTanque
            // 
            this.lblQtdTanque.AutoSize = true;
            this.lblQtdTanque.Location = new System.Drawing.Point(272, 80);
            this.lblQtdTanque.Name = "lblQtdTanque";
            this.lblQtdTanque.Size = new System.Drawing.Size(67, 13);
            this.lblQtdTanque.TabIndex = 21;
            this.lblQtdTanque.Text = "Qtd. Tanque";
            // 
            // cBoxQtdTanque
            // 
            this.cBoxQtdTanque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQtdTanque.FormattingEnabled = true;
            this.cBoxQtdTanque.Items.AddRange(new object[] {
            "0/1",
            "1/4",
            "1/2",
            "3/4",
            "1/1"});
            this.cBoxQtdTanque.Location = new System.Drawing.Point(344, 80);
            this.cBoxQtdTanque.Name = "cBoxQtdTanque";
            this.cBoxQtdTanque.Size = new System.Drawing.Size(75, 21);
            this.cBoxQtdTanque.TabIndex = 20;
            this.cBoxQtdTanque.SelectedIndexChanged += new System.EventHandler(this.CBoxQtdTanque_SelectedIndexChanged);
            // 
            // lblValorCombustivel
            // 
            this.lblValorCombustivel.AutoSize = true;
            this.lblValorCombustivel.Location = new System.Drawing.Point(8, 80);
            this.lblValorCombustivel.Name = "lblValorCombustivel";
            this.lblValorCombustivel.Size = new System.Drawing.Size(123, 13);
            this.lblValorCombustivel.TabIndex = 19;
            this.lblValorCombustivel.Text = "Valor do Combustivel R$";
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.Location = new System.Drawing.Point(136, 80);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(75, 20);
            this.txtValorCombustivel.TabIndex = 18;
            this.txtValorCombustivel.Text = "0";
            this.txtValorCombustivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorCombustivel_KeyPress);
            // 
            // TelaDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 443);
            this.Controls.Add(this.gBoxDevolucao);
            this.Controls.Add(this.brnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gBoxLocacao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDevolucaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Locadora de Veículo";
            this.gBoxLocacao.ResumeLayout(false);
            this.gBoxLocacao.PerformLayout();
            this.gBoxDevolucao.ResumeLayout(false);
            this.gBoxDevolucao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button brnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gBoxLocacao;
        private System.Windows.Forms.Label lblServicosSelecionados;
        private System.Windows.Forms.CheckedListBox cLBoxServicosSelecionados;
        private System.Windows.Forms.TextBox txtDataDevolucao;
        private System.Windows.Forms.TextBox txtDataLocacao;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblDataLocacao;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.GroupBox gBoxDevolucao;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Button btnSelecionarServicos;
        private System.Windows.Forms.Label lblQtdTanque;
        private System.Windows.Forms.ComboBox cBoxQtdTanque;
        private System.Windows.Forms.Label lblValorCombustivel;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.Label lblKmFinal;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.RadioButton rBtn01;
        private System.Windows.Forms.RadioButton rBtn14;
        private System.Windows.Forms.RadioButton rBtn12;
        private System.Windows.Forms.RadioButton rBtn34;
        private System.Windows.Forms.RadioButton rBtn11;
        private System.Windows.Forms.Label lblEncerrar;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.TextBox txtValorInicial;
    }
}