namespace gdc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnRecolonizarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClientes.Location = new System.Drawing.Point(102, 105);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(587, 260);
            this.dgvClientes.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(21, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtMarcador
            // 
            this.txtMarcador.Location = new System.Drawing.Point(315, 46);
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(100, 20);
            this.txtMarcador.TabIndex = 2;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(421, 46);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 3;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInserirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserirCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirCliente.Image")));
            this.btnInserirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirCliente.Location = new System.Drawing.Point(558, 10);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(167, 58);
            this.btnInserirCliente.TabIndex = 4;
            this.btnInserirCliente.Text = "Inserir Cliente";
            this.btnInserirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirCliente.UseVisualStyleBackColor = false;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblRef);
            this.panel1.Controls.Add(this.lblMarcador);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnInserirCliente);
            this.panel1.Controls.Add(this.txtMarcador);
            this.panel1.Controls.Add(this.txtRef);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 78);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dados Novo Cliente";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(430, 27);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(78, 15);
            this.lblRef.TabIndex = 7;
            this.lblRef.Text = "Ref Interna";
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(329, 26);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(68, 15);
            this.lblMarcador.TabIndex = 6;
            this.lblMarcador.Text = "Marcador";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(20, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 15);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome Completo";
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizarCliente.Location = new System.Drawing.Point(133, 376);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(167, 51);
            this.btnAtualizarCliente.TabIndex = 5;
            this.btnAtualizarCliente.Text = "Atualizar Cliente";
            this.btnAtualizarCliente.UseVisualStyleBackColor = false;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(321, 376);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(170, 53);
            this.btnEliminarCliente.TabIndex = 6;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnRecolonizarClientes
            // 
            this.btnRecolonizarClientes.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRecolonizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecolonizarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecolonizarClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecolonizarClientes.Location = new System.Drawing.Point(510, 377);
            this.btnRecolonizarClientes.Name = "btnRecolonizarClientes";
            this.btnRecolonizarClientes.Size = new System.Drawing.Size(167, 52);
            this.btnRecolonizarClientes.TabIndex = 7;
            this.btnRecolonizarClientes.Text = "Recolonizar Clientes";
            this.btnRecolonizarClientes.UseVisualStyleBackColor = false;
            this.btnRecolonizarClientes.Click += new System.EventHandler(this.btnRecolonizarClientes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecolonizarClientes);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAtualizarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "Form2";
            this.Text = "Aplicação Gestão de Débitos e Créditos ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarcador;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAtualizarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnRecolonizarClientes;
        private System.Windows.Forms.Label label1;
    }
}