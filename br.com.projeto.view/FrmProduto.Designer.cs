namespace Controle_de_Vendas.br.com.projeto.view
{
    partial class FrmProduto
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
            panel1 = new Panel();
            label1 = new Label();
            TabelaFornecedores = new TabControl();
            TabProdutos = new TabPage();
            button1 = new Button();
            label4 = new Label();
            CbFornecedor = new ComboBox();
            TxtQuantidade = new TextBox();
            label11 = new Label();
            TxtPreco = new TextBox();
            label10 = new Label();
            TxtDescricao = new TextBox();
            label3 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            BtnPesquisa = new Button();
            TxtPesquisa = new TextBox();
            label19 = new Label();
            TabelaProdutos = new DataGridView();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            BtnSalvar = new Button();
            BtnNovo = new Button();
            panel1.SuspendLayout();
            TabelaFornecedores.SuspendLayout();
            TabProdutos.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaProdutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 99);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            label1.Click += label1_Click;
            // 
            // TabelaFornecedores
            // 
            TabelaFornecedores.Controls.Add(TabProdutos);
            TabelaFornecedores.Controls.Add(tabPage2);
            TabelaFornecedores.Location = new Point(0, 105);
            TabelaFornecedores.Name = "TabelaFornecedores";
            TabelaFornecedores.SelectedIndex = 0;
            TabelaFornecedores.Size = new Size(900, 344);
            TabelaFornecedores.TabIndex = 4;
            // 
            // TabProdutos
            // 
            TabProdutos.Controls.Add(button1);
            TabProdutos.Controls.Add(label4);
            TabProdutos.Controls.Add(CbFornecedor);
            TabProdutos.Controls.Add(TxtQuantidade);
            TabProdutos.Controls.Add(label11);
            TabProdutos.Controls.Add(TxtPreco);
            TabProdutos.Controls.Add(label10);
            TabProdutos.Controls.Add(TxtDescricao);
            TabProdutos.Controls.Add(label3);
            TabProdutos.Controls.Add(TxtCodigo);
            TabProdutos.Controls.Add(label2);
            TabProdutos.Location = new Point(4, 29);
            TabProdutos.Name = "TabProdutos";
            TabProdutos.Size = new Size(892, 311);
            TabProdutos.TabIndex = 1;
            TabProdutos.Text = "Dados Pessoais";
            TabProdutos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(559, 157);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 51;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(19, 157);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 50;
            label4.Text = "Fornecedor:";
            // 
            // CbFornecedor
            // 
            CbFornecedor.FormattingEnabled = true;
            CbFornecedor.Location = new Point(114, 154);
            CbFornecedor.Name = "CbFornecedor";
            CbFornecedor.Size = new Size(412, 28);
            CbFornecedor.TabIndex = 49;
            CbFornecedor.SelectedIndexChanged += CbFornecedor_SelectedIndexChanged;
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(114, 109);
            TxtQuantidade.Margin = new Padding(4, 3, 4, 3);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(98, 27);
            TxtQuantidade.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(16, 112);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 47;
            label11.Text = "Quantidade:";
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(641, 65);
            TxtPreco.Margin = new Padding(4, 3, 4, 3);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(132, 27);
            TxtPreco.TabIndex = 46;
            TxtPreco.TextChanged += TxtEndereco_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(559, 69);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 45;
            label10.Text = "Preço R$:";
            label10.Click += label10_Click;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(114, 66);
            TxtDescricao.Margin = new Padding(4, 3, 4, 3);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(412, 27);
            TxtDescricao.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(16, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 30;
            label3.Text = "Descrição:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(114, 28);
            TxtCodigo.Margin = new Padding(4, 3, 4, 3);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(98, 27);
            TxtCodigo.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(16, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 28;
            label2.Text = "Código:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnPesquisa);
            tabPage2.Controls.Add(TxtPesquisa);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(TabelaProdutos);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(892, 311);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisa
            // 
            BtnPesquisa.BackColor = Color.Blue;
            BtnPesquisa.ForeColor = SystemColors.Control;
            BtnPesquisa.Location = new Point(541, 19);
            BtnPesquisa.Name = "BtnPesquisa";
            BtnPesquisa.Size = new Size(117, 29);
            BtnPesquisa.TabIndex = 3;
            BtnPesquisa.Text = "Pesquisar";
            BtnPesquisa.UseVisualStyleBackColor = false;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(91, 20);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(428, 27);
            TxtPesquisa.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Highlight;
            label19.Location = new Point(28, 23);
            label19.Name = "label19";
            label19.Size = new Size(53, 20);
            label19.TabIndex = 1;
            label19.Text = "Nome:";
            // 
            // TabelaProdutos
            // 
            TabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaProdutos.Location = new Point(8, 92);
            TabelaProdutos.Name = "TabelaProdutos";
            TabelaProdutos.RowHeadersWidth = 51;
            TabelaProdutos.RowTemplate.Height = 29;
            TabelaProdutos.Size = new Size(876, 216);
            TabelaProdutos.TabIndex = 0;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = SystemColors.Highlight;
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(650, 451);
            BtnExcluir.Margin = new Padding(4, 3, 4, 3);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(131, 45);
            BtnExcluir.TabIndex = 17;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(478, 451);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(131, 45);
            BtnEditar.TabIndex = 16;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = SystemColors.Highlight;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(307, 451);
            BtnSalvar.Margin = new Padding(4, 3, 4, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(131, 45);
            BtnSalvar.TabIndex = 15;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = SystemColors.Highlight;
            BtnNovo.ForeColor = Color.White;
            BtnNovo.Location = new Point(134, 451);
            BtnNovo.Margin = new Padding(4, 3, 4, 3);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(131, 45);
            BtnNovo.TabIndex = 14;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 507);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnNovo);
            Controls.Add(TabelaFornecedores);
            Controls.Add(panel1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabelaFornecedores.ResumeLayout(false);
            TabProdutos.ResumeLayout(false);
            TabProdutos.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TabelaFornecedores;
        private TabPage TabProdutos;
        private TextBox TxtQuantidade;
        private Label label11;
        private TextBox TxtPreco;
        private Label label10;
        private TextBox TxtDescricao;
        private Label label3;
        private TextBox TxtCodigo;
        private Label label2;
        private TabPage tabPage2;
        private Button BtnPesquisa;
        private TextBox TxtPesquisa;
        private Label label19;
        private DataGridView TabelaProdutos;
        private Button BtnExcluir;
        private Button BtnEditar;
        private Button BtnSalvar;
        private Button BtnNovo;
        private Label label4;
        private ComboBox CbFornecedor;
        private Button button1;
    }
}