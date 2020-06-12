﻿namespace Empresa
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel_endereco = new System.Windows.Forms.Panel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.panel_bairro = new System.Windows.Forms.Panel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.panel_cidade = new System.Windows.Forms.Panel();
            this.panel_number = new System.Windows.Forms.Panel();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel_telefone = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel_senha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel_comfirmsenha = new System.Windows.Forms.Panel();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.gpxFormaPagamento = new System.Windows.Forms.GroupBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.panel_uf = new System.Windows.Forms.Panel();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.erroP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gpxFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(816, 482);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(169, 57);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(69, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 57);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel_nome
            // 
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(69, 144);
            this.panel_nome.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(399, 4);
            this.panel_nome.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(69, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 39);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.Nome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.Nome_Leave);
            // 
            // panel_endereco
            // 
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(69, 204);
            this.panel_endereco.Margin = new System.Windows.Forms.Padding(4);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(399, 4);
            this.panel_endereco.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(69, 170);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(400, 39);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.Endereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.Endereco_Leave);
            // 
            // panel_bairro
            // 
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(68, 263);
            this.panel_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(399, 4);
            this.panel_bairro.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(68, 229);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(400, 39);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.Bairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.Bairro_Leave);
            // 
            // panel_cidade
            // 
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(66, 373);
            this.panel_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(399, 4);
            this.panel_cidade.TabIndex = 18;
            // 
            // panel_number
            // 
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(67, 314);
            this.panel_number.Margin = new System.Windows.Forms.Padding(4);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(399, 4);
            this.panel_number.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(66, 339);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(400, 39);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.Cidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.Cidade_Leave);
            // 
            // panel_telefone
            // 
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(585, 144);
            this.panel_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(399, 4);
            this.panel_telefone.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(67, 280);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(400, 39);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.number_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.number_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.HideSelection = false;
            this.txtTelefone.Location = new System.Drawing.Point(585, 105);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(400, 39);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.Telefone_Enter);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.Telefone_Leave);
            // 
            // panel_senha
            // 
            this.panel_senha.BackColor = System.Drawing.Color.Silver;
            this.panel_senha.Location = new System.Drawing.Point(587, 267);
            this.panel_senha.Margin = new System.Windows.Forms.Padding(4);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(399, 4);
            this.panel_senha.TabIndex = 22;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtSenha.Location = new System.Drawing.Point(587, 233);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(400, 39);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.Senha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.Senha_Leave);
            // 
            // panel_usuario
            // 
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(585, 205);
            this.panel_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(399, 4);
            this.panel_usuario.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(585, 170);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(400, 39);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // panel_comfirmsenha
            // 
            this.panel_comfirmsenha.BackColor = System.Drawing.Color.Silver;
            this.panel_comfirmsenha.Location = new System.Drawing.Point(586, 330);
            this.panel_comfirmsenha.Margin = new System.Windows.Forms.Padding(4);
            this.panel_comfirmsenha.Name = "panel_comfirmsenha";
            this.panel_comfirmsenha.Size = new System.Drawing.Size(399, 4);
            this.panel_comfirmsenha.TabIndex = 24;
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.BackColor = System.Drawing.Color.White;
            this.txtConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirmSenha.Location = new System.Drawing.Point(586, 296);
            this.txtConfirmSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.Size = new System.Drawing.Size(400, 39);
            this.txtConfirmSenha.TabIndex = 10;
            this.txtConfirmSenha.Text = "Confirmar Senha";
            this.txtConfirmSenha.Enter += new System.EventHandler(this.ComfirmSenha_Enter);
            this.txtConfirmSenha.Leave += new System.EventHandler(this.ComfirmSenha_Leave);
            // 
            // gpxFormaPagamento
            // 
            this.gpxFormaPagamento.Controls.Add(this.chkDinheiro);
            this.gpxFormaPagamento.Controls.Add(this.chkCredito);
            this.gpxFormaPagamento.Controls.Add(this.chkDebito);
            this.gpxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxFormaPagamento.Location = new System.Drawing.Point(584, 352);
            this.gpxFormaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Name = "gpxFormaPagamento";
            this.gpxFormaPagamento.Padding = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Size = new System.Drawing.Size(399, 101);
            this.gpxFormaPagamento.TabIndex = 11;
            this.gpxFormaPagamento.TabStop = false;
            this.gpxFormaPagamento.Text = "Aceita";
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(257, 41);
            this.chkDinheiro.Margin = new System.Windows.Forms.Padding(4);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(126, 33);
            this.chkDinheiro.TabIndex = 14;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredito.Location = new System.Drawing.Point(131, 41);
            this.chkCredito.Margin = new System.Windows.Forms.Padding(4);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(114, 33);
            this.chkCredito.TabIndex = 13;
            this.chkCredito.Text = "Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebito.Location = new System.Drawing.Point(12, 41);
            this.chkDebito.Margin = new System.Windows.Forms.Padding(4);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(106, 33);
            this.chkDebito.TabIndex = 12;
            this.chkDebito.Text = "Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // panel_uf
            // 
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(67, 434);
            this.panel_uf.Margin = new System.Windows.Forms.Padding(4);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(399, 4);
            this.panel_uf.TabIndex = 27;
            // 
            // txtUF
            // 
            this.txtUF.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.txtUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUF.BackColor = System.Drawing.Color.White;
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.Silver;
            this.txtUF.Location = new System.Drawing.Point(67, 399);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(400, 39);
            this.txtUF.TabIndex = 6;
            this.txtUF.Text = "UF";
            this.txtUF.Enter += new System.EventHandler(this.Uf_Enter);
            this.txtUF.Leave += new System.EventHandler(this.Uf_Leave);
            // 
            // erroP
            // 
            this.erroP.BlinkRate = 0;
            this.erroP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erroP.ContainerControl = this;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel_uf);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.gpxFormaPagamento);
            this.Controls.Add(this.panel_comfirmsenha);
            this.Controls.Add(this.txtConfirmSenha);
            this.Controls.Add(this.panel_senha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel_usuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel_cidade);
            this.Controls.Add(this.panel_number);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.panel_telefone);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.panel_bairro);
            this.Controls.Add(this.panel_endereco);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.panel_nome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpxFormaPagamento.ResumeLayout(false);
            this.gpxFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel_endereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Panel panel_bairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel panel_cidade;
        private System.Windows.Forms.Panel panel_number;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel_telefone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel_senha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel_comfirmsenha;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.GroupBox gpxFormaPagamento;
        private System.Windows.Forms.Panel panel_uf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.ErrorProvider erroP;
    }
}