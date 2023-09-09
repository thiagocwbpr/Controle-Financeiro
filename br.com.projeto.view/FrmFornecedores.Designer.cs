namespace Controle_de_Vendas.br.com.projeto.view
{
    partial class FrmFornecedores
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
            tabPage2 = new TabPage();
            btnPesquisarCep = new Button();
            TxtCidade = new TextBox();
            label16 = new Label();
            CbUf = new ComboBox();
            TxtComp = new TextBox();
            label14 = new Label();
            label13 = new Label();
            TxtBairro = new TextBox();
            label12 = new Label();
            TxtNumero = new TextBox();
            label11 = new Label();
            TxtEndereco = new TextBox();
            label10 = new Label();
            TxtCep = new MaskedTextBox();
            label9 = new Label();
            TxtCelular = new MaskedTextBox();
            label8 = new Label();
            TxtTelefone = new MaskedTextBox();
            label7 = new Label();
            TxtCnpj = new MaskedTextBox();
            label5 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            TxtNome = new TextBox();
            label3 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            tabPage1 = new TabPage();
            BtnPesquisa = new Button();
            TxtPesquisa = new TextBox();
            label19 = new Label();
            TabFornecedores = new DataGridView();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            BtnSalvar = new Button();
            BtnNovo = new Button();
            panel1.SuspendLayout();
            TabelaFornecedores.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabFornecedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 99);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Fornecedores";
            label1.Click += label1_Click;
            // 
            // TabelaFornecedores
            // 
            TabelaFornecedores.Controls.Add(tabPage2);
            TabelaFornecedores.Controls.Add(tabPage1);
            TabelaFornecedores.Location = new Point(0, 105);
            TabelaFornecedores.Name = "TabelaFornecedores";
            TabelaFornecedores.SelectedIndex = 0;
            TabelaFornecedores.Size = new Size(900, 344);
            TabelaFornecedores.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnPesquisarCep);
            tabPage2.Controls.Add(TxtCidade);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(CbUf);
            tabPage2.Controls.Add(TxtComp);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(TxtBairro);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(TxtNumero);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(TxtEndereco);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(TxtCep);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(TxtCelular);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(TxtTelefone);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(TxtCnpj);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtEmail);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtNome);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(TxtCodigo);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(892, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados Pessoais";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.BackColor = Color.Blue;
            btnPesquisarCep.ForeColor = Color.White;
            btnPesquisarCep.Location = new Point(673, 5);
            btnPesquisarCep.Margin = new Padding(4, 3, 4, 3);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(142, 32);
            btnPesquisarCep.TabIndex = 35;
            btnPesquisarCep.Text = "Pesquisar CEP";
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(541, 209);
            TxtCidade.Margin = new Padding(4, 3, 4, 3);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(308, 26);
            TxtCidade.TabIndex = 56;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Highlight;
            label16.Location = new Point(470, 212);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 55;
            label16.Text = "Cidade:";
            // 
            // CbUf
            // 
            CbUf.FormattingEnabled = true;
            CbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            CbUf.Location = new Point(540, 249);
            CbUf.Margin = new Padding(4, 3, 4, 3);
            CbUf.Name = "CbUf";
            CbUf.Size = new Size(211, 28);
            CbUf.TabIndex = 54;
            // 
            // TxtComp
            // 
            TxtComp.Location = new Point(612, 134);
            TxtComp.Margin = new Padding(4, 3, 4, 3);
            TxtComp.Name = "TxtComp";
            TxtComp.Size = new Size(75, 26);
            TxtComp.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(470, 137);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(118, 20);
            label14.TabIndex = 52;
            label14.Text = "Complemento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(496, 252);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 20);
            label13.TabIndex = 51;
            label13.Text = "UF:";
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(543, 173);
            TxtBairro.Margin = new Padding(4, 3, 4, 3);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(157, 26);
            TxtBairro.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(472, 176);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 49;
            label12.Text = "Bairro:";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(515, 92);
            TxtNumero.Margin = new Padding(4, 3, 4, 3);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(64, 26);
            TxtNumero.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(472, 95);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 47;
            label11.Text = "Nº:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(562, 43);
            TxtEndereco.Margin = new Padding(4, 3, 4, 3);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(326, 26);
            TxtEndereco.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(472, 46);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 45;
            label10.Text = "Endereço:";
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(529, 8);
            TxtCep.Margin = new Padding(4, 3, 4, 3);
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(123, 26);
            TxtCep.TabIndex = 44;
            TxtCep.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(472, 8);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 43;
            label9.Text = "CEP:";
            // 
            // TxtCelular
            // 
            TxtCelular.Location = new Point(88, 227);
            TxtCelular.Margin = new Padding(4, 3, 4, 3);
            TxtCelular.Mask = "(##) #####.####";
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(157, 26);
            TxtCelular.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(11, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 41;
            label8.Text = "Celular:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(89, 187);
            TxtTelefone.Margin = new Padding(4, 3, 4, 3);
            TxtTelefone.Mask = "(##) #####.####";
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(157, 26);
            TxtTelefone.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(9, 190);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 39;
            label7.Text = "Telefone:";
            // 
            // TxtCnpj
            // 
            TxtCnpj.Location = new Point(86, 104);
            TxtCnpj.Margin = new Padding(4, 3, 4, 3);
            TxtCnpj.Mask = "##.###.###/####-##";
            TxtCnpj.Name = "TxtCnpj";
            TxtCnpj.Size = new Size(157, 26);
            TxtCnpj.TabIndex = 36;
            TxtCnpj.TextAlign = HorizontalAlignment.Center;
            TxtCnpj.MaskInputRejected += TxtCnpj_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(18, 107);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 34;
            label5.Text = "CNPJ:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(86, 146);
            TxtEmail.Margin = new Padding(4, 3, 4, 3);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(159, 26);
            TxtEmail.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(18, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 32;
            label4.Text = "E-mail:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(86, 59);
            TxtNome.Margin = new Padding(4, 3, 4, 3);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(365, 26);
            TxtNome.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(16, 61);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 30;
            label3.Text = "Nome:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(86, 11);
            TxtCodigo.Margin = new Padding(4, 3, 4, 3);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(98, 26);
            TxtCodigo.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(10, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 28;
            label2.Text = "Código:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnPesquisa);
            tabPage1.Controls.Add(TxtPesquisa);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(TabFornecedores);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(892, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
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
            BtnPesquisa.Click += BtnPesquisa_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(91, 20);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(428, 26);
            TxtPesquisa.TabIndex = 2;
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Highlight;
            label19.Location = new Point(28, 23);
            label19.Name = "label19";
            label19.Size = new Size(57, 20);
            label19.TabIndex = 1;
            label19.Text = "Nome:";
            // 
            // TabFornecedores
            // 
            TabFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabFornecedores.Location = new Point(8, 92);
            TabFornecedores.Name = "TabFornecedores";
            TabFornecedores.RowHeadersWidth = 51;
            TabFornecedores.RowTemplate.Height = 29;
            TabFornecedores.Size = new Size(876, 216);
            TabFornecedores.TabIndex = 0;
            TabFornecedores.CellClick += TabFornecedores_CellClick;
            TabFornecedores.CellContentClick += TabFornecedores_CellContentClick;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = SystemColors.Highlight;
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(646, 455);
            BtnExcluir.Margin = new Padding(4, 3, 4, 3);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(131, 45);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(474, 455);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(131, 45);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = SystemColors.Highlight;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(303, 455);
            BtnSalvar.Margin = new Padding(4, 3, 4, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(131, 45);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = SystemColors.Highlight;
            BtnNovo.ForeColor = Color.White;
            BtnNovo.Location = new Point(130, 455);
            BtnNovo.Margin = new Padding(4, 3, 4, 3);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(131, 45);
            BtnNovo.TabIndex = 10;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 511);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnNovo);
            Controls.Add(TabelaFornecedores);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmFornecedores";
            Text = "Cadastro de Fornecedores";
            Load += FrmFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabelaFornecedores.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabFornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TabelaFornecedores;
        private TabPage tabPage2;
        private Button btnPesquisarCep;
        private TextBox TxtCidade;
        private Label label16;
        private ComboBox CbUf;
        private TextBox TxtComp;
        private Label label14;
        private Label label13;
        private TextBox TxtBairro;
        private Label label12;
        private TextBox TxtNumero;
        private Label label11;
        private TextBox TxtEndereco;
        private Label label10;
        private MaskedTextBox TxtCep;
        private Label label9;
        private MaskedTextBox TxtCelular;
        private Label label8;
        private MaskedTextBox TxtTelefone;
        private Label label7;
        private MaskedTextBox TxtCnpj;
        private Label label5;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtNome;
        private Label label3;
        private TextBox TxtCodigo;
        private Label label2;
        private TabPage tabPage1;
        private Button BtnPesquisa;
        private TextBox TxtPesquisa;
        private Label label19;
        private DataGridView TabFornecedores;
        private Button BtnExcluir;
        private Button BtnEditar;
        private Button BtnSalvar;
        private Button BtnNovo;
    }
}