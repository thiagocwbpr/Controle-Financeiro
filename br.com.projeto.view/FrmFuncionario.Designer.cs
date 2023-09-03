namespace Controle_de_Vendas.br.com.projeto.view
{
    partial class FrmFuncionario
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
            TabelaFuncionarios = new TabControl();
            tabPage2 = new TabPage();
            CbNivelAcesso = new ComboBox();
            label18 = new Label();
            TxtSenha = new TextBox();
            label17 = new Label();
            CbCargo = new ComboBox();
            label15 = new Label();
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
            tabPage1 = new TabPage();
            BtnPesquisa = new Button();
            TxtPesquisa = new TextBox();
            label19 = new Label();
            TabFuncionario = new DataGridView();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            BtnSalvar = new Button();
            BtnNovo = new Button();
            panel1.SuspendLayout();
            TabelaFuncionarios.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabFuncionario).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionários";
            // 
            // TabelaFuncionarios
            // 
            TabelaFuncionarios.Controls.Add(tabPage2);
            TabelaFuncionarios.Controls.Add(tabPage1);
            TabelaFuncionarios.Location = new Point(0, 105);
            TabelaFuncionarios.Name = "TabelaFuncionarios";
            TabelaFuncionarios.SelectedIndex = 0;
            TabelaFuncionarios.Size = new Size(900, 344);
            TabelaFuncionarios.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CbNivelAcesso);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(TxtSenha);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(CbCargo);
            tabPage2.Controls.Add(label15);
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
            tabPage2.Controls.Add(TxtCpf);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(TxtRg);
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
            // CbNivelAcesso
            // 
            CbNivelAcesso.FormattingEnabled = true;
            CbNivelAcesso.Items.AddRange(new object[] { "Administrador", "Usuário" });
            CbNivelAcesso.Location = new Point(428, 275);
            CbNivelAcesso.Name = "CbNivelAcesso";
            CbNivelAcesso.Size = new Size(151, 28);
            CbNivelAcesso.TabIndex = 62;
            CbNivelAcesso.SelectedIndexChanged += CbNivelAcesso_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.Highlight;
            label18.Location = new Point(290, 278);
            label18.Name = "label18";
            label18.Size = new Size(131, 20);
            label18.TabIndex = 61;
            label18.Text = "Nível de Acesso:";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(86, 278);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(157, 26);
            TxtSenha.TabIndex = 60;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Highlight;
            label17.Location = new Point(11, 278);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 59;
            label17.Text = "Senha:";
            // 
            // CbCargo
            // 
            CbCargo.AccessibleName = "";
            CbCargo.FormattingEnabled = true;
            CbCargo.Items.AddRange(new object[] { "Gerente", "Vendedor", "Estagiário" });
            CbCargo.Location = new Point(86, 243);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(157, 28);
            CbCargo.TabIndex = 58;
            CbCargo.SelectedIndexChanged += CbCargo_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(8, 246);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 57;
            label15.Text = "Cargo:";
            label15.Click += label15_Click;
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
            TxtCidade.Location = new Point(543, 165);
            TxtCidade.Margin = new Padding(4, 3, 4, 3);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(308, 26);
            TxtCidade.TabIndex = 56;
            TxtCidade.TextChanged += TxtCidade_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Highlight;
            label16.Location = new Point(472, 168);
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
            CbUf.Location = new Point(516, 209);
            CbUf.Margin = new Padding(4, 3, 4, 3);
            CbUf.Name = "CbUf";
            CbUf.Size = new Size(211, 28);
            CbUf.TabIndex = 54;
            CbUf.SelectedIndexChanged += CbUf_SelectedIndexChanged;
            // 
            // TxtComp
            // 
            TxtComp.Location = new Point(739, 83);
            TxtComp.Margin = new Padding(4, 3, 4, 3);
            TxtComp.Name = "TxtComp";
            TxtComp.Size = new Size(75, 26);
            TxtComp.TabIndex = 53;
            TxtComp.TextChanged += TxtComp_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(597, 86);
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
            label13.Location = new Point(472, 212);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(31, 20);
            label13.TabIndex = 51;
            label13.Text = "UF:";
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(543, 128);
            TxtBairro.Margin = new Padding(4, 3, 4, 3);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(157, 26);
            TxtBairro.TabIndex = 50;
            TxtBairro.TextChanged += TxtBairro_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(472, 131);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 49;
            label12.Text = "Bairro:";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(515, 83);
            TxtNumero.Margin = new Padding(4, 3, 4, 3);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(64, 26);
            TxtNumero.TabIndex = 48;
            TxtNumero.TextChanged += TxtNumero_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(472, 86);
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
            TxtEndereco.TextChanged += TxtEndereco_TextChanged;
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
            TxtCep.MaskInputRejected += TxtCep_MaskInputRejected;
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
            TxtCelular.Location = new Point(88, 209);
            TxtCelular.Margin = new Padding(4, 3, 4, 3);
            TxtCelular.Mask = "(##) #####.####";
            TxtCelular.Name = "TxtCelular";
            TxtCelular.Size = new Size(157, 26);
            TxtCelular.TabIndex = 42;
            TxtCelular.MaskInputRejected += TxtCelular_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(6, 214);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 41;
            label8.Text = "Celular:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(88, 177);
            TxtTelefone.Margin = new Padding(4, 3, 4, 3);
            TxtTelefone.Mask = "(##) #####.####";
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(157, 26);
            TxtTelefone.TabIndex = 40;
            TxtTelefone.MaskInputRejected += TxtTelefone_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(2, 183);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 39;
            label7.Text = "Telefone:";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(86, 109);
            TxtCpf.Margin = new Padding(4, 3, 4, 3);
            TxtCpf.Mask = "###.###.###-##";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(157, 26);
            TxtCpf.TabIndex = 38;
            TxtCpf.TextAlign = HorizontalAlignment.Center;
            TxtCpf.MaskInputRejected += TxtCpf_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(18, 109);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 37;
            label6.Text = "CPF:";
            // 
            // TxtRg
            // 
            TxtRg.Location = new Point(86, 77);
            TxtRg.Margin = new Padding(4, 3, 4, 3);
            TxtRg.Mask = "##.###.###-##";
            TxtRg.Name = "TxtRg";
            TxtRg.Size = new Size(157, 26);
            TxtRg.TabIndex = 36;
            TxtRg.TextAlign = HorizontalAlignment.Center;
            TxtRg.MaskInputRejected += TxtRg_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(18, 80);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 34;
            label5.Text = "R.G:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(86, 143);
            TxtEmail.Margin = new Padding(4, 3, 4, 3);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(159, 26);
            TxtEmail.TabIndex = 33;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(16, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 32;
            label4.Text = "E-mail:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(86, 43);
            TxtNome.Margin = new Padding(4, 3, 4, 3);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(365, 26);
            TxtNome.TabIndex = 31;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(16, 45);
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
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
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
            tabPage1.Controls.Add(TabFuncionario);
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
            // TabFuncionario
            // 
            TabFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabFuncionario.Location = new Point(8, 92);
            TabFuncionario.Name = "TabFuncionario";
            TabFuncionario.RowHeadersWidth = 51;
            TabFuncionario.RowTemplate.Height = 29;
            TabFuncionario.Size = new Size(876, 216);
            TabFuncionario.TabIndex = 0;
            TabFuncionario.CellClick += TabFuncionario_CellClick;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = SystemColors.Highlight;
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(655, 451);
            BtnExcluir.Margin = new Padding(4, 3, 4, 3);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(131, 45);
            BtnExcluir.TabIndex = 9;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = SystemColors.Highlight;
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(483, 451);
            BtnEditar.Margin = new Padding(4, 3, 4, 3);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(131, 45);
            BtnEditar.TabIndex = 8;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = SystemColors.Highlight;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(312, 451);
            BtnSalvar.Margin = new Padding(4, 3, 4, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(131, 45);
            BtnSalvar.TabIndex = 7;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = SystemColors.Highlight;
            BtnNovo.ForeColor = Color.White;
            BtnNovo.Location = new Point(139, 451);
            BtnNovo.Margin = new Padding(4, 3, 4, 3);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(131, 45);
            BtnNovo.TabIndex = 6;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 501);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnNovo);
            Controls.Add(TabelaFuncionarios);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmFuncionario";
            Text = "FrmFuncionario";
            Load += FrmFuncionario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabelaFuncionarios.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TabelaFuncionarios;
        private TabPage tabPage1;
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
        private MaskedTextBox TxtCpf;
        private Label label6;
        private MaskedTextBox TxtRg;
        private Label label5;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtNome;
        private Label label3;
        private TextBox TxtCodigo;
        private Label label2;
        private Label label15;
        private ComboBox CbCargo;
        private TextBox TxtSenha;
        private Label label17;
        private ComboBox CbNivelAcesso;
        private Label label18;
        private DataGridView TabFuncionario;
        private TextBox TxtPesquisa;
        private Label label19;
        private Button BtnPesquisa;
        private Button BtnExcluir;
        private Button BtnEditar;
        private Button BtnSalvar;
        private Button BtnNovo;
    }
}