namespace Reconquista
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.pnlDadosPessoais = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblFone1 = new System.Windows.Forms.Label();
            this.rbtnPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbtnPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.mtxtCpfCnpjCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfCnpjCli = new System.Windows.Forms.Label();
            this.mtxtRGIECli = new System.Windows.Forms.MaskedTextBox();
            this.lblRGIECli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDtaVigencia = new System.Windows.Forms.Label();
            this.dtpDtaVigencia = new System.Windows.Forms.DateTimePicker();
            this.btnAttBemSegurado = new System.Windows.Forms.Button();
            this.btnDeleteBemSegurado = new System.Windows.Forms.Button();
            this.btnAddBemSegurado = new System.Windows.Forms.Button();
            this.lblCodBemSegurado = new System.Windows.Forms.Label();
            this.txtCodBemSegurado = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.rtxtObs = new System.Windows.Forms.RichTextBox();
            this.mtxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtBemSegurado = new System.Windows.Forms.TextBox();
            this.lblBemSegurado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet = new Reconquista.DataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Reconquista.DataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Reconquista.DataSetTableAdapters.TableAdapterManager();
            this.bemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bemTableAdapter = new Reconquista.DataSetTableAdapters.BemTableAdapter();
            this.cliente_BemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente_BemTableAdapter = new Reconquista.DataSetTableAdapters.Cliente_BemTableAdapter();
            this.pnlDadosPessoais.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_BemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosPessoais
            // 
            this.pnlDadosPessoais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosPessoais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosPessoais.Controls.Add(this.txtEmail);
            this.pnlDadosPessoais.Controls.Add(this.lblEmail);
            this.pnlDadosPessoais.Controls.Add(this.mtxtTel2);
            this.pnlDadosPessoais.Controls.Add(this.mtxtTel1);
            this.pnlDadosPessoais.Controls.Add(this.lblTel2);
            this.pnlDadosPessoais.Controls.Add(this.lblFone1);
            this.pnlDadosPessoais.Controls.Add(this.rbtnPessoaFisica);
            this.pnlDadosPessoais.Controls.Add(this.rbtnPessoaJuridica);
            this.pnlDadosPessoais.Controls.Add(this.mtxtCpfCnpjCli);
            this.pnlDadosPessoais.Controls.Add(this.lblCpfCnpjCli);
            this.pnlDadosPessoais.Controls.Add(this.mtxtRGIECli);
            this.pnlDadosPessoais.Controls.Add(this.lblRGIECli);
            this.pnlDadosPessoais.Controls.Add(this.lblNomeCli);
            this.pnlDadosPessoais.Controls.Add(this.txtNomeCli);
            this.pnlDadosPessoais.Controls.Add(this.txtCodCli);
            this.pnlDadosPessoais.Controls.Add(this.lblCodCli);
            this.pnlDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDadosPessoais.Location = new System.Drawing.Point(16, 28);
            this.pnlDadosPessoais.Name = "pnlDadosPessoais";
            this.pnlDadosPessoais.Size = new System.Drawing.Size(819, 100);
            this.pnlDadosPessoais.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email_cli", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(442, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 23);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(439, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 17);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E - mail:";
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTel2.Location = new System.Drawing.Point(336, 69);
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(100, 23);
            this.mtxtTel2.TabIndex = 30;
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTel1.Location = new System.Drawing.Point(230, 69);
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(100, 23);
            this.mtxtTel1.TabIndex = 29;
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel2.Location = new System.Drawing.Point(333, 52);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(72, 17);
            this.lblTel2.TabIndex = 28;
            this.lblTel2.Text = "Tel. / Cel.:";
            // 
            // lblFone1
            // 
            this.lblFone1.AutoSize = true;
            this.lblFone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone1.Location = new System.Drawing.Point(227, 53);
            this.lblFone1.Name = "lblFone1";
            this.lblFone1.Size = new System.Drawing.Size(72, 17);
            this.lblFone1.TabIndex = 27;
            this.lblFone1.Text = "Tel. / Cel.:";
            // 
            // rbtnPessoaFisica
            // 
            this.rbtnPessoaFisica.AutoSize = true;
            this.rbtnPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPessoaFisica.Location = new System.Drawing.Point(658, 26);
            this.rbtnPessoaFisica.Name = "rbtnPessoaFisica";
            this.rbtnPessoaFisica.Size = new System.Drawing.Size(113, 21);
            this.rbtnPessoaFisica.TabIndex = 26;
            this.rbtnPessoaFisica.Text = "Pessoa Física";
            this.rbtnPessoaFisica.UseVisualStyleBackColor = true;
            this.rbtnPessoaFisica.CheckedChanged += new System.EventHandler(this.rbtnPessoaFisica_CheckedChanged);
            // 
            // rbtnPessoaJuridica
            // 
            this.rbtnPessoaJuridica.AutoSize = true;
            this.rbtnPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPessoaJuridica.Location = new System.Drawing.Point(658, 69);
            this.rbtnPessoaJuridica.Name = "rbtnPessoaJuridica";
            this.rbtnPessoaJuridica.Size = new System.Drawing.Size(126, 21);
            this.rbtnPessoaJuridica.TabIndex = 25;
            this.rbtnPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbtnPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbtnPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbtnPessoaJuridica_CheckedChanged);
            // 
            // mtxtCpfCnpjCli
            // 
            this.mtxtCpfCnpjCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF_CNPJ_cli", true));
            this.mtxtCpfCnpjCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCpfCnpjCli.Location = new System.Drawing.Point(88, 69);
            this.mtxtCpfCnpjCli.Name = "mtxtCpfCnpjCli";
            this.mtxtCpfCnpjCli.Size = new System.Drawing.Size(133, 23);
            this.mtxtCpfCnpjCli.TabIndex = 24;
            // 
            // lblCpfCnpjCli
            // 
            this.lblCpfCnpjCli.AutoSize = true;
            this.lblCpfCnpjCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpjCli.Location = new System.Drawing.Point(85, 53);
            this.lblCpfCnpjCli.Name = "lblCpfCnpjCli";
            this.lblCpfCnpjCli.Size = new System.Drawing.Size(38, 17);
            this.lblCpfCnpjCli.TabIndex = 23;
            this.lblCpfCnpjCli.Text = "CPF:";
            // 
            // mtxtRGIECli
            // 
            this.mtxtRGIECli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG_IE_cli", true));
            this.mtxtRGIECli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRGIECli.Location = new System.Drawing.Point(3, 69);
            this.mtxtRGIECli.Name = "mtxtRGIECli";
            this.mtxtRGIECli.Size = new System.Drawing.Size(79, 23);
            this.mtxtRGIECli.TabIndex = 22;
            // 
            // lblRGIECli
            // 
            this.lblRGIECli.AutoSize = true;
            this.lblRGIECli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGIECli.Location = new System.Drawing.Point(0, 52);
            this.lblRGIECli.Name = "lblRGIECli";
            this.lblRGIECli.Size = new System.Drawing.Size(41, 17);
            this.lblRGIECli.TabIndex = 21;
            this.lblRGIECli.Text = "R.G.:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(89, 6);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(70, 17);
            this.lblNomeCli.TabIndex = 20;
            this.lblNomeCli.Text = "Segurado";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome_cli", true));
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(88, 26);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(556, 23);
            this.txtNomeCli.TabIndex = 19;
            // 
            // txtCodCli
            // 
            this.txtCodCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ID_cli", true));
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(3, 26);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(79, 23);
            this.txtCodCli.TabIndex = 18;
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCli.Location = new System.Drawing.Point(3, 6);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(52, 17);
            this.lblCodCli.TabIndex = 17;
            this.lblCodCli.Text = "Código";
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPessoais.Location = new System.Drawing.Point(40, 15);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(110, 17);
            this.lblDadosPessoais.TabIndex = 21;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDtaVigencia);
            this.panel2.Controls.Add(this.dtpDtaVigencia);
            this.panel2.Controls.Add(this.btnAttBemSegurado);
            this.panel2.Controls.Add(this.btnDeleteBemSegurado);
            this.panel2.Controls.Add(this.btnAddBemSegurado);
            this.panel2.Controls.Add(this.lblCodBemSegurado);
            this.panel2.Controls.Add(this.txtCodBemSegurado);
            this.panel2.Controls.Add(this.lblObs);
            this.panel2.Controls.Add(this.rtxtObs);
            this.panel2.Controls.Add(this.mtxtPlaca);
            this.panel2.Controls.Add(this.lblPlaca);
            this.panel2.Controls.Add(this.txtBemSegurado);
            this.panel2.Controls.Add(this.lblBemSegurado);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 204);
            this.panel2.TabIndex = 22;
            // 
            // lblDtaVigencia
            // 
            this.lblDtaVigencia.AutoSize = true;
            this.lblDtaVigencia.Location = new System.Drawing.Point(603, 5);
            this.lblDtaVigencia.Name = "lblDtaVigencia";
            this.lblDtaVigencia.Size = new System.Drawing.Size(116, 17);
            this.lblDtaVigencia.TabIndex = 27;
            this.lblDtaVigencia.Text = "Data de Vigência";
            // 
            // dtpDtaVigencia
            // 
            this.dtpDtaVigencia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cliente_BemBindingSource, "Dta_vigencia", true));
            this.dtpDtaVigencia.Enabled = false;
            this.dtpDtaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtaVigencia.Location = new System.Drawing.Point(606, 25);
            this.dtpDtaVigencia.Name = "dtpDtaVigencia";
            this.dtpDtaVigencia.Size = new System.Drawing.Size(101, 23);
            this.dtpDtaVigencia.TabIndex = 26;
            // 
            // btnAttBemSegurado
            // 
            this.btnAttBemSegurado.Image = ((System.Drawing.Image)(resources.GetObject("btnAttBemSegurado.Image")));
            this.btnAttBemSegurado.Location = new System.Drawing.Point(725, 150);
            this.btnAttBemSegurado.Name = "btnAttBemSegurado";
            this.btnAttBemSegurado.Size = new System.Drawing.Size(89, 44);
            this.btnAttBemSegurado.TabIndex = 25;
            this.btnAttBemSegurado.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBemSegurado
            // 
            this.btnDeleteBemSegurado.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBemSegurado.Image")));
            this.btnDeleteBemSegurado.Location = new System.Drawing.Point(725, 80);
            this.btnDeleteBemSegurado.Name = "btnDeleteBemSegurado";
            this.btnDeleteBemSegurado.Size = new System.Drawing.Size(89, 45);
            this.btnDeleteBemSegurado.TabIndex = 24;
            this.btnDeleteBemSegurado.UseVisualStyleBackColor = true;
            // 
            // btnAddBemSegurado
            // 
            this.btnAddBemSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBemSegurado.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBemSegurado.Image")));
            this.btnAddBemSegurado.Location = new System.Drawing.Point(725, 14);
            this.btnAddBemSegurado.Name = "btnAddBemSegurado";
            this.btnAddBemSegurado.Size = new System.Drawing.Size(89, 45);
            this.btnAddBemSegurado.TabIndex = 23;
            this.btnAddBemSegurado.UseVisualStyleBackColor = true;
            this.btnAddBemSegurado.Click += new System.EventHandler(this.btnAddBemSegurado_Click);
            // 
            // lblCodBemSegurado
            // 
            this.lblCodBemSegurado.AutoSize = true;
            this.lblCodBemSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBemSegurado.Location = new System.Drawing.Point(3, 5);
            this.lblCodBemSegurado.Name = "lblCodBemSegurado";
            this.lblCodBemSegurado.Size = new System.Drawing.Size(52, 17);
            this.lblCodBemSegurado.TabIndex = 22;
            this.lblCodBemSegurado.Text = "Código";
            // 
            // txtCodBemSegurado
            // 
            this.txtCodBemSegurado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bemBindingSource, "ID_bem", true));
            this.txtCodBemSegurado.Enabled = false;
            this.txtCodBemSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBemSegurado.Location = new System.Drawing.Point(6, 25);
            this.txtCodBemSegurado.Name = "txtCodBemSegurado";
            this.txtCodBemSegurado.Size = new System.Drawing.Size(77, 23);
            this.txtCodBemSegurado.TabIndex = 21;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(3, 60);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(92, 17);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Observações";
            // 
            // rtxtObs
            // 
            this.rtxtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bemBindingSource, "Obs_bem", true));
            this.rtxtObs.Enabled = false;
            this.rtxtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtObs.Location = new System.Drawing.Point(3, 80);
            this.rtxtObs.Name = "rtxtObs";
            this.rtxtObs.Size = new System.Drawing.Size(716, 114);
            this.rtxtObs.TabIndex = 19;
            this.rtxtObs.Text = "";
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bemBindingSource, "Placa_bem", true));
            this.mtxtPlaca.Enabled = false;
            this.mtxtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPlaca.Location = new System.Drawing.Point(541, 25);
            this.mtxtPlaca.Mask = "AAA-0000";
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(59, 23);
            this.mtxtPlaca.TabIndex = 3;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(541, 5);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(43, 17);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa";
            // 
            // txtBemSegurado
            // 
            this.txtBemSegurado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bemBindingSource, "Nome_bem", true));
            this.txtBemSegurado.Enabled = false;
            this.txtBemSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBemSegurado.Location = new System.Drawing.Point(88, 25);
            this.txtBemSegurado.Name = "txtBemSegurado";
            this.txtBemSegurado.Size = new System.Drawing.Size(447, 23);
            this.txtBemSegurado.TabIndex = 1;
            // 
            // lblBemSegurado
            // 
            this.lblBemSegurado.AutoSize = true;
            this.lblBemSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemSegurado.Location = new System.Drawing.Point(89, 5);
            this.lblBemSegurado.Name = "lblBemSegurado";
            this.lblBemSegurado.Size = new System.Drawing.Size(102, 17);
            this.lblBemSegurado.TabIndex = 0;
            this.lblBemSegurado.Text = "Bem Segurado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem(ns) Segurado(s)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(916, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 689);
            this.panel1.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(20, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(20, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(20, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 225);
            this.dataGridView1.TabIndex = 24;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnexoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BemTableAdapter = this.bemTableAdapter;
            this.tableAdapterManager.Cliente_BemTableAdapter = this.cliente_BemTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.TelefoneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Reconquista.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bemBindingSource
            // 
            this.bemBindingSource.DataMember = "Bem";
            this.bemBindingSource.DataSource = this.dataSet;
            // 
            // bemTableAdapter
            // 
            this.bemTableAdapter.ClearBeforeFill = true;
            // 
            // cliente_BemBindingSource
            // 
            this.cliente_BemBindingSource.DataMember = "Cliente_Bem";
            this.cliente_BemBindingSource.DataSource = this.dataSet;
            // 
            // cliente_BemTableAdapter
            // 
            this.cliente_BemTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDadosPessoais);
            this.Controls.Add(this.pnlDadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.Shown += new System.EventHandler(this.FrmCadastroCliente_Shown);
            this.pnlDadosPessoais.ResumeLayout(false);
            this.pnlDadosPessoais.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_BemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDadosPessoais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblFone1;
        private System.Windows.Forms.RadioButton rbtnPessoaFisica;
        private System.Windows.Forms.RadioButton rbtnPessoaJuridica;
        private System.Windows.Forms.MaskedTextBox mtxtCpfCnpjCli;
        private System.Windows.Forms.Label lblCpfCnpjCli;
        private System.Windows.Forms.MaskedTextBox mtxtRGIECli;
        private System.Windows.Forms.Label lblRGIECli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtxtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtBemSegurado;
        private System.Windows.Forms.Label lblBemSegurado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodBemSegurado;
        private System.Windows.Forms.TextBox txtCodBemSegurado;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox rtxtObs;
        private System.Windows.Forms.Button btnAddBemSegurado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAttBemSegurado;
        private System.Windows.Forms.Button btnDeleteBemSegurado;
        private System.Windows.Forms.Label lblDtaVigencia;
        private System.Windows.Forms.DateTimePicker dtpDtaVigencia;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.BemTableAdapter bemTableAdapter;
        private System.Windows.Forms.BindingSource bemBindingSource;
        private DataSetTableAdapters.Cliente_BemTableAdapter cliente_BemTableAdapter;
        private System.Windows.Forms.BindingSource cliente_BemBindingSource;
    }
}