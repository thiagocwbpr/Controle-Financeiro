namespace Controle_de_Vendas.br.com.projeto.view
{
    partial class FrmClientes
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
            TabClientes = new TabControl();
            tabPage1 = new TabPage();
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
            TxtCpf = new MaskedTextBox();
            label6 = new Label();
            TxtRg = new MaskedTextBox();
            label5 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            TxtNome = new TextBox();
            label3 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            TabelaCliente = new DataGridView();
            BtnPesquisar = new Button();
            TxtPesquisa = new TextBox();
            label15 = new Label();
            BtnNovo = new Button();
            BtnSalvar = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            panel1.SuspendLayout();
            TabClientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaCliente).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // TabClientes
            // 
            TabClientes.Controls.Add(tabPage1);
            TabClientes.Controls.Add(tabPage2);
            TabClientes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TabClientes.Location = new Point(0, 103);
            TabClientes.Margin = new Padding(4, 3, 4, 3);
            TabClientes.Multiline = true;
            TabClientes.Name = "TabClientes";
            TabClientes.RightToLeft = RightToLeft.No;
            TabClientes.SelectedIndex = 0;
            TabClientes.Size = new Size(900, 307);
            TabClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPesquisarCep);
            tabPage1.Controls.Add(TxtCidade);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(CbUf);
            tabPage1.Controls.Add(TxtComp);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(TxtBairro);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(TxtNumero);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(TxtEndereco);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(TxtCep);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(TxtCelular);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(TxtTelefone);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(TxtCpf);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(TxtRg);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TxtEmail);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(TxtNome);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(TxtCodigo);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(892, 274);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage2_Click;
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.BackColor = Color.Blue;
            btnPesquisarCep.ForeColor = Color.White;
            btnPesquisarCep.Location = new Point(601, 18);
            btnPesquisarCep.Margin = new Padding(4, 3, 4, 3);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(126, 32);
            btnPesquisarCep.TabIndex = 6;
            btnPesquisarCep.Text = "Pesquisar CEP";
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(486, 178);
            TxtCidade.Margin = new Padding(4, 3, 4, 3);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(274, 26);
            TxtCidade.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Highlight;
            label16.Location = new Point(423, 181);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 26;
            label16.Text = "Cidade:";
            // 
            // CbUf
            // 
            CbUf.FormattingEnabled = true;
            CbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            CbUf.Location = new Point(462, 222);
            CbUf.Margin = new Padding(4, 3, 4, 3);
            CbUf.Name = "CbUf";
            CbUf.Size = new Size(188, 28);
            CbUf.TabIndex = 25;
            // 
            // TxtComp
            // 
            TxtComp.Location = new Point(660, 96);
            TxtComp.Margin = new Padding(4, 3, 4, 3);
            TxtComp.Name = "TxtComp";
            TxtComp.Size = new Size(67, 26);
            TxtComp.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(534, 99);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(118, 20);
            label14.TabIndex = 23;
            label14.Text = "Complemento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(423, 225);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 20);
            label13.TabIndex = 22;
            label13.Text = "UF:";
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(486, 141);
            TxtBairro.Margin = new Padding(4, 3, 4, 3);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(140, 26);
            TxtBairro.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(423, 144);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 20;
            label12.Text = "Bairro:";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(461, 96);
            TxtNumero.Margin = new Padding(4, 3, 4, 3);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(57, 26);
            TxtNumero.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(423, 99);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(30, 20);
            label11.TabIndex = 18;
            label11.Text = "Nº:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(503, 56);
            TxtEndereco.Margin = new Padding(4, 3, 4, 3);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(377, 26);
            TxtEndereco.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(423, 59);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 16;
            label10.Text = "Endereço:";
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(473, 21);
            TxtCep.Margin = new Padding(4, 3, 4, 3);
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(110, 26);
            TxtCep.TabIndex = 15;
            TxtCep.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(423, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 14;
            label9.Text = "CEP:";
            // 
            // TxtCelular
            // 
            TxtCelular.Location = new Point(81, 222);
            TxtCelular.Margin = new Padding(4, 3, 4, 3);
            TxtCelular.Mask = "(##) #####.####";
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(140, 26);
            TxtCelular.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(8, 227);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 12;
            label8.Text = "Celular:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(81, 190);
            TxtTelefone.Margin = new Padding(4, 3, 4, 3);
            TxtTelefone.Mask = "(##) #####.####";
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(140, 26);
            TxtTelefone.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(5, 196);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Telefone:";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(79, 122);
            TxtCpf.Margin = new Padding(4, 3, 4, 3);
            TxtCpf.Mask = "###.###.###-##";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(140, 26);
            TxtCpf.TabIndex = 9;
            TxtCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(19, 122);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "CPF:";
            // 
            // TxtRg
            // 
            TxtRg.Location = new Point(79, 90);
            TxtRg.Margin = new Padding(4, 3, 4, 3);
            TxtRg.Mask = "##.###.###-##";
            TxtRg.Name = "TxtRg";
            TxtRg.Size = new Size(140, 26);
            TxtRg.TabIndex = 7;
            TxtRg.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(19, 93);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "R.G:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(79, 156);
            TxtEmail.Margin = new Padding(4, 3, 4, 3);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(142, 26);
            TxtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(17, 159);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "E-mail:";
            label4.Click += label4_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(79, 56);
            TxtNome.Margin = new Padding(4, 3, 4, 3);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(325, 26);
            TxtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(17, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(79, 24);
            TxtCodigo.Margin = new Padding(4, 3, 4, 3);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(88, 26);
            TxtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TabelaCliente);
            tabPage2.Controls.Add(BtnPesquisar);
            tabPage2.Controls.Add(TxtPesquisa);
            tabPage2.Controls.Add(label15);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(892, 274);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage1_Click;
            // 
            // TabelaCliente
            // 
            TabelaCliente.AllowUserToAddRows = false;
            TabelaCliente.AllowUserToDeleteRows = false;
            TabelaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaCliente.Location = new Point(10, 72);
            TabelaCliente.Margin = new Padding(4, 3, 4, 3);
            TabelaCliente.Name = "TabelaCliente";
            TabelaCliente.ReadOnly = true;
            TabelaCliente.RowHeadersWidth = 51;
            TabelaCliente.RowTemplate.Height = 25;
            TabelaCliente.Size = new Size(869, 188);
            TabelaCliente.TabIndex = 7;
            TabelaCliente.CellClick += TabelaCliente_CellClick;
            TabelaCliente.CellContentClick += TabelaCliente_CellContentClick;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = SystemColors.Highlight;
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(521, 7);
            BtnPesquisar.Margin = new Padding(4, 3, 4, 3);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(121, 37);
            BtnPesquisar.TabIndex = 6;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(88, 10);
            TxtPesquisa.Margin = new Padding(4, 3, 4, 3);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(411, 26);
            TxtPesquisa.TabIndex = 5;
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
            TxtPesquisa.KeyPress += TxtPesquisa_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(10, 13);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 4;
            label15.Text = "Nome:";
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = SystemColors.Highlight;
            BtnNovo.ForeColor = Color.White;
            BtnNovo.Location = new Point(116, 417);
            BtnNovo.Margin = new Padding(4, 3, 4, 3);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(131, 45);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = SystemColors.Highlight;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(289, 417);
            BtnSalvar.Margin = new Padding(4, 3, 4, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(131, 45);
            BtnSalvar.TabIndex = 3;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(460, 417);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(131, 45);
            BtnEditar.TabIndex = 4;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = SystemColors.Highlight;
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(632, 417);
            BtnExcluir.Margin = new Padding(4, 3, 4, 3);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(131, 45);
            BtnExcluir.TabIndex = 5;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 475);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnNovo);
            Controls.Add(TabClientes);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += FrmClientes_Load;
            Click += FrmClientes_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabClientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TabClientes;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label label2;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtNome;
        private Label label3;
        private TextBox TxtCodigo;
        private Label label5;
        private MaskedTextBox TxtRg;
        private MaskedTextBox TxtCpf;
        private Label label6;
        private MaskedTextBox TxtCelular;
        private Label label8;
        private MaskedTextBox TxtTelefone;
        private Label label7;
        private TextBox TxtEndereco;
        private Label label10;
        private MaskedTextBox TxtCep;
        private Label label9;
        private Label label13;
        private TextBox TxtBairro;
        private Label label12;
        private TextBox TxtNumero;
        private Label label11;
        private TextBox TxtComp;
        private Label label14;
        private ComboBox CbUf;
        private Button BtnNovo;
        private Button BtnSalvar;
        private Button BtnEditar;
        private Button BtnExcluir;
        private DataGridView TabelaCliente;
        private Button BtnPesquisar;
        private TextBox TxtPesquisa;
        private Label label15;
        private TextBox TxtCidade;
        private Label label16;
        private Button btnPesquisarCep;
    }
}