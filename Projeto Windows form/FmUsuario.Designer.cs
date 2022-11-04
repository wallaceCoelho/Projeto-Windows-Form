namespace Projeto_Windows_form
{
    partial class FmUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            this.cadastroDataSet = new Projeto_Windows_form.CadastroDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new Projeto_Windows_form.CadastroDataSetTableAdapters.tbUsuarioTableAdapter();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarioLabel.Location = new System.Drawing.Point(72, 96);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(64, 18);
            cd_usuarioLabel.TabIndex = 1;
            cd_usuarioLabel.Text = "Código:";
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_usuarioLabel.Location = new System.Drawing.Point(72, 130);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(54, 18);
            nm_usuarioLabel.TabIndex = 3;
            nm_usuarioLabel.Text = "Nome:";
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_nivelLabel.Location = new System.Drawing.Point(72, 165);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(45, 18);
            sg_nivelLabel.TabIndex = 5;
            sg_nivelLabel.Text = "Nível:";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_loginLabel.Location = new System.Drawing.Point(72, 200);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(51, 18);
            nm_loginLabel.TabIndex = 7;
            nm_loginLabel.Text = "Login:";
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_senhaLabel.Location = new System.Drawing.Point(72, 234);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(57, 18);
            cd_senhaLabel.TabIndex = 9;
            cd_senhaLabel.Text = "Senha:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(152, 94);
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(41, 20);
            this.cd_usuarioTextBox.TabIndex = 2;
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(152, 129);
            this.nm_usuarioTextBox.MaxLength = 100;
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(334, 20);
            this.nm_usuarioTextBox.TabIndex = 4;
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Location = new System.Drawing.Point(152, 163);
            this.sg_nivelTextBox.MaxLength = 1;
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(24, 20);
            this.sg_nivelTextBox.TabIndex = 6;
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Location = new System.Drawing.Point(152, 197);
            this.nm_loginTextBox.MaxLength = 15;
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(154, 20);
            this.nm_loginTextBox.TabIndex = 8;
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Location = new System.Drawing.Point(152, 231);
            this.cd_senhaTextBox.MaxLength = 15;
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(154, 20);
            this.cd_senhaTextBox.TabIndex = 10;
            this.cd_senhaTextBox.UseSystemPasswordChar = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(75, 346);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 30);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(217, 346);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(89, 30);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(359, 346);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 30);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(501, 346);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(643, 346);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(75, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(217, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(359, 393);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(501, 393);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(643, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
            this.Name = "FmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private CadastroDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
    }
}