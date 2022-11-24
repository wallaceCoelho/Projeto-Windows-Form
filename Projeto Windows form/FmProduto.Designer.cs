namespace Projeto_Windows_form
{
    partial class FmProduto
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
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label sg_unidadeLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label cd_fornecedorLabel1;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new Projeto_Windows_form.CadastroDataSet();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.sg_unidadeTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.tbProdutoTableAdapter = new Projeto_Windows_form.CadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.tableAdapterManager = new Projeto_Windows_form.CadastroDataSetTableAdapters.TableAdapterManager();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            sg_unidadeLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Location = new System.Drawing.Point(68, 44);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(64, 18);
            cd_produtoLabel.TabIndex = 40;
            cd_produtoLabel.Text = "Código:";
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Location = new System.Drawing.Point(68, 86);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(54, 18);
            nm_produtoLabel.TabIndex = 42;
            nm_produtoLabel.Text = "Nome:";
            // 
            // sg_unidadeLabel
            // 
            sg_unidadeLabel.AutoSize = true;
            sg_unidadeLabel.Location = new System.Drawing.Point(68, 127);
            sg_unidadeLabel.Name = "sg_unidadeLabel";
            sg_unidadeLabel.Size = new System.Drawing.Size(79, 18);
            sg_unidadeLabel.TabIndex = 44;
            sg_unidadeLabel.Text = "Unidades:";
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Location = new System.Drawing.Point(68, 167);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(117, 18);
            vl_custoLabel.TabIndex = 46;
            vl_custoLabel.Text = "Preço de custo:";
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Location = new System.Drawing.Point(68, 209);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(118, 18);
            vl_vendaLabel.TabIndex = 48;
            vl_vendaLabel.Text = "Preço de venda";
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Location = new System.Drawing.Point(68, 252);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(119, 18);
            qt_estoqueLabel.TabIndex = 50;
            qt_estoqueLabel.Text = "Quant. Estoque:";
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Location = new System.Drawing.Point(16, 246);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(0, 18);
            cd_fornecedorLabel.TabIndex = 52;
            // 
            // cd_fornecedorLabel1
            // 
            cd_fornecedorLabel1.AutoSize = true;
            cd_fornecedorLabel1.Location = new System.Drawing.Point(68, 293);
            cd_fornecedorLabel1.Name = "cd_fornecedorLabel1";
            cd_fornecedorLabel1.Size = new System.Drawing.Size(131, 18);
            cd_fornecedorLabel1.TabIndex = 52;
            cd_fornecedorLabel1.Text = "Cód. Fornecedor:";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(636, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(494, 385);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 30);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(352, 385);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(210, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(68, 385);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(636, 338);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(494, 338);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 30);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(352, 338);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 30);
            this.btnNovo.TabIndex = 33;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(210, 338);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(89, 30);
            this.btnProximo.TabIndex = 32;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(68, 338);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 30);
            this.btnAnterior.TabIndex = 31;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(201, 41);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(40, 26);
            this.cd_produtoTextBox.TabIndex = 41;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(201, 83);
            this.nm_produtoTextBox.MaxLength = 50;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(524, 26);
            this.nm_produtoTextBox.TabIndex = 43;
            // 
            // sg_unidadeTextBox
            // 
            this.sg_unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "sg_unidade", true));
            this.sg_unidadeTextBox.Location = new System.Drawing.Point(201, 124);
            this.sg_unidadeTextBox.MaxLength = 2;
            this.sg_unidadeTextBox.Name = "sg_unidadeTextBox";
            this.sg_unidadeTextBox.Size = new System.Drawing.Size(81, 26);
            this.sg_unidadeTextBox.TabIndex = 45;
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_custo", true));
            this.vl_custoTextBox.Location = new System.Drawing.Point(201, 164);
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(165, 26);
            this.vl_custoTextBox.TabIndex = 47;
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_venda", true));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(201, 206);
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(165, 26);
            this.vl_vendaTextBox.TabIndex = 49;
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(201, 249);
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(165, 26);
            this.qt_estoqueTextBox.TabIndex = 51;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(201, 290);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(81, 26);
            this.cd_fornecedorTextBox.TabIndex = 53;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = this.tbProdutoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Windows_form.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(cd_fornecedorLabel1);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(sg_unidadeLabel);
            this.Controls.Add(this.sg_unidadeTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Controls.Add(cd_fornecedorLabel);
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
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private CadastroDataSet cadastroDataSet;
        private CadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox sg_unidadeTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
    }
}