namespace gdc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recolonizarMovimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.dgvMovimentos = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblVerificacao = new System.Windows.Forms.Label();
            this.btnInserirMovimento = new System.Windows.Forms.Button();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDadosMovimento = new System.Windows.Forms.Label();
            this.bntRefreshClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcumuladoCredito = new System.Windows.Forms.TextBox();
            this.txtAcumuladoDebito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizarMovimento = new System.Windows.Forms.Button();
            this.btnListarDatas = new System.Windows.Forms.Button();
            this.btnListarMesCorrente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.eliminarMovimentoToolStripMenuItem,
            this.recolonizarMovimentosToolStripMenuItem,
            this.balanceteToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.movimentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentosToolStripMenuItem.Image")));
            this.movimentosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.movimentosToolStripMenuItem.Text = "Movimentos";
            this.movimentosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // eliminarMovimentoToolStripMenuItem
            // 
            this.eliminarMovimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarEntreDatasToolStripMenuItem,
            this.eliminarEntreDatasToolStripMenuItem1});
            this.eliminarMovimentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.eliminarMovimentoToolStripMenuItem.Name = "eliminarMovimentoToolStripMenuItem";
            this.eliminarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(144, 23);
            this.eliminarMovimentoToolStripMenuItem.Text = "Eliminar Movimento";
            // 
            // eliminarEntreDatasToolStripMenuItem
            // 
            this.eliminarEntreDatasToolStripMenuItem.Name = "eliminarEntreDatasToolStripMenuItem";
            this.eliminarEntreDatasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.eliminarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.eliminarEntreDatasToolStripMenuItem.Text = "Eliminar Movimento";
            this.eliminarEntreDatasToolStripMenuItem.Click += new System.EventHandler(this.eliminarEntreDatasToolStripMenuItem_Click);
            // 
            // eliminarEntreDatasToolStripMenuItem1
            // 
            this.eliminarEntreDatasToolStripMenuItem1.Name = "eliminarEntreDatasToolStripMenuItem1";
            this.eliminarEntreDatasToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.eliminarEntreDatasToolStripMenuItem1.Text = "Eliminar entre datas";
            this.eliminarEntreDatasToolStripMenuItem1.Click += new System.EventHandler(this.eliminarEntreDatasToolStripMenuItem1_Click);
            // 
            // recolonizarMovimentosToolStripMenuItem
            // 
            this.recolonizarMovimentosToolStripMenuItem.Name = "recolonizarMovimentosToolStripMenuItem";
            this.recolonizarMovimentosToolStripMenuItem.Size = new System.Drawing.Size(150, 23);
            this.recolonizarMovimentosToolStripMenuItem.Text = "Recolonizar Movimentos";
            this.recolonizarMovimentosToolStripMenuItem.Click += new System.EventHandler(this.recolonizarMovimentosToolStripMenuItem_Click);
            // 
            // balanceteToolStripMenuItem
            // 
            this.balanceteToolStripMenuItem.AutoToolTip = true;
            this.balanceteToolStripMenuItem.CheckOnClick = true;
            this.balanceteToolStripMenuItem.DoubleClickEnabled = true;
            this.balanceteToolStripMenuItem.Name = "balanceteToolStripMenuItem";
            this.balanceteToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.balanceteToolStripMenuItem.Text = "Balancete";
            this.balanceteToolStripMenuItem.ToolTipText = "Movimentos Totais do Mês Corrente";
            this.balanceteToolStripMenuItem.Click += new System.EventHandler(this.balanceteToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.ajudaToolStripMenuItem.Text = "Ajuda F1";
            // 
            // txtFiltro
            // 
            this.txtFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtFiltro.Location = new System.Drawing.Point(21, 55);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(209, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(21, 108);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(209, 225);
            this.lstClientes.TabIndex = 2;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientesAoClicar);
            // 
            // dgvMovimentos
            // 
            this.dgvMovimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentos.Location = new System.Drawing.Point(250, 43);
            this.dgvMovimentos.Name = "dgvMovimentos";
            this.dgvMovimentos.Size = new System.Drawing.Size(589, 289);
            this.dgvMovimentos.TabIndex = 10;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(32, 37);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(188, 15);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Escrever nome para filtrar Cliente";
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(76, 85);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(106, 17);
            this.lblListaClientes.TabIndex = 5;
            this.lblListaClientes.Text = "Lista Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCredito);
            this.panel1.Controls.Add(this.lblDebito);
            this.panel1.Controls.Add(this.lblVerificacao);
            this.panel1.Controls.Add(this.btnInserirMovimento);
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.txtDebito);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDadosMovimento);
            this.panel1.Location = new System.Drawing.Point(21, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 74);
            this.panel1.TabIndex = 6;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(457, 12);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(90, 15);
            this.lblCredito.TabIndex = 8;
            this.lblCredito.Text = "Valor Crédito";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.Location = new System.Drawing.Point(354, 12);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(86, 15);
            this.lblDebito.TabIndex = 7;
            this.lblDebito.Text = "Valor Débito";
            // 
            // lblVerificacao
            // 
            this.lblVerificacao.AutoSize = true;
            this.lblVerificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacao.Location = new System.Drawing.Point(214, 12);
            this.lblVerificacao.Name = "lblVerificacao";
            this.lblVerificacao.Size = new System.Drawing.Size(80, 17);
            this.lblVerificacao.TabIndex = 6;
            this.lblVerificacao.Text = "Descrição";
            // 
            // btnInserirMovimento
            // 
            this.btnInserirMovimento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInserirMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirMovimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserirMovimento.Location = new System.Drawing.Point(578, 9);
            this.btnInserirMovimento.Name = "btnInserirMovimento";
            this.btnInserirMovimento.Size = new System.Drawing.Size(156, 52);
            this.btnInserirMovimento.TabIndex = 6;
            this.btnInserirMovimento.Text = "Inserir Movimento";
            this.btnInserirMovimento.UseVisualStyleBackColor = false;
            this.btnInserirMovimento.Click += new System.EventHandler(this.btnInserirMovimento_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(454, 32);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 20);
            this.txtCredito.TabIndex = 5;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(348, 32);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(100, 20);
            this.txtDebito.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(178, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(164, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDadosMovimento
            // 
            this.lblDadosMovimento.AutoSize = true;
            this.lblDadosMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosMovimento.Location = new System.Drawing.Point(6, 6);
            this.lblDadosMovimento.Name = "lblDadosMovimento";
            this.lblDadosMovimento.Size = new System.Drawing.Size(178, 17);
            this.lblDadosMovimento.TabIndex = 0;
            this.lblDadosMovimento.Text = "Dados Novo Movimento";
            // 
            // bntRefreshClientes
            // 
            this.bntRefreshClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntRefreshClientes.FlatAppearance.BorderSize = 0;
            this.bntRefreshClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRefreshClientes.Image = ((System.Drawing.Image)(resources.GetObject("bntRefreshClientes.Image")));
            this.bntRefreshClientes.Location = new System.Drawing.Point(202, 81);
            this.bntRefreshClientes.Name = "bntRefreshClientes";
            this.bntRefreshClientes.Size = new System.Drawing.Size(28, 24);
            this.bntRefreshClientes.TabIndex = 11;
            this.bntRefreshClientes.UseVisualStyleBackColor = false;
            this.bntRefreshClientes.Click += new System.EventHandler(this.bntRefreshClientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAcumuladoCredito);
            this.panel2.Controls.Add(this.txtAcumuladoDebito);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(519, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 69);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crédito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Débito";
            // 
            // txtAcumuladoCredito
            // 
            this.txtAcumuladoCredito.Location = new System.Drawing.Point(126, 33);
            this.txtAcumuladoCredito.Name = "txtAcumuladoCredito";
            this.txtAcumuladoCredito.Size = new System.Drawing.Size(82, 20);
            this.txtAcumuladoCredito.TabIndex = 2;
            this.txtAcumuladoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcumuladoDebito
            // 
            this.txtAcumuladoDebito.Location = new System.Drawing.Point(14, 33);
            this.txtAcumuladoDebito.Name = "txtAcumuladoDebito";
            this.txtAcumuladoDebito.Size = new System.Drawing.Size(87, 20);
            this.txtAcumuladoDebito.TabIndex = 1;
            this.txtAcumuladoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcumuladoDebito.TextChanged += new System.EventHandler(this.txtAcumuladoDebito_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acumulados ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimePicker3);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Location = new System.Drawing.Point(22, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 69);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Fim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Inicio";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(134, 37);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // btnAtualizarMovimento
            // 
            this.btnAtualizarMovimento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAtualizarMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarMovimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizarMovimento.Location = new System.Drawing.Point(778, 444);
            this.btnAtualizarMovimento.Name = "btnAtualizarMovimento";
            this.btnAtualizarMovimento.Size = new System.Drawing.Size(82, 74);
            this.btnAtualizarMovimento.TabIndex = 14;
            this.btnAtualizarMovimento.Text = "Atualizar Movimento";
            this.btnAtualizarMovimento.UseVisualStyleBackColor = false;
            this.btnAtualizarMovimento.Click += new System.EventHandler(this.btnAtualizarMovimento_Click);
            // 
            // btnListarDatas
            // 
            this.btnListarDatas.BackColor = System.Drawing.Color.DarkCyan;
            this.btnListarDatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDatas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarDatas.Location = new System.Drawing.Point(379, 351);
            this.btnListarDatas.Name = "btnListarDatas";
            this.btnListarDatas.Size = new System.Drawing.Size(134, 31);
            this.btnListarDatas.TabIndex = 15;
            this.btnListarDatas.Text = "Listar entre Datas";
            this.btnListarDatas.UseVisualStyleBackColor = false;
            this.btnListarDatas.Click += new System.EventHandler(this.btnListarDatas_Click);
            // 
            // btnListarMesCorrente
            // 
            this.btnListarMesCorrente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnListarMesCorrente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarMesCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMesCorrente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarMesCorrente.Location = new System.Drawing.Point(379, 388);
            this.btnListarMesCorrente.Name = "btnListarMesCorrente";
            this.btnListarMesCorrente.Size = new System.Drawing.Size(134, 31);
            this.btnListarMesCorrente.TabIndex = 16;
            this.btnListarMesCorrente.Text = "Listar Mês Corrente";
            this.btnListarMesCorrente.UseVisualStyleBackColor = false;
            this.btnListarMesCorrente.Click += new System.EventHandler(this.btnListarMesCorrente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 530);
            this.Controls.Add(this.btnListarMesCorrente);
            this.Controls.Add(this.btnListarDatas);
            this.Controls.Add(this.btnAtualizarMovimento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bntRefreshClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvMovimentos);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplicação Gestão Débitos e Créditos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMovimentoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.DataGridView dgvMovimentos;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label lblVerificacao;
        private System.Windows.Forms.Button btnInserirMovimento;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDadosMovimento;
        private System.Windows.Forms.ToolStripMenuItem recolonizarMovimentosToolStripMenuItem;
        private System.Windows.Forms.Button bntRefreshClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcumuladoCredito;
        private System.Windows.Forms.TextBox txtAcumuladoDebito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntreDatasToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAtualizarMovimento;
        private System.Windows.Forms.Button btnListarDatas;
        private System.Windows.Forms.Button btnListarMesCorrente;
        private System.Windows.Forms.ToolStripMenuItem balanceteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}

