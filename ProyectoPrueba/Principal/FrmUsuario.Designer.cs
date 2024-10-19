namespace ProyectoPrueba.Principal
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ChkEstado = new System.Windows.Forms.CheckBox();
            this.BtnAgrgar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblIdUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsuarios.Location = new System.Drawing.Point(110, 298);
            this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersWidth = 62;
            this.DgvUsuarios.Size = new System.Drawing.Size(1084, 289);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.Width = 150;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(68, 78);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(168, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(266, 78);
            this.TxtApellido1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(218, 26);
            this.TxtApellido1.TabIndex = 2;
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(518, 78);
            this.TxtApellido2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(190, 26);
            this.TxtApellido2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido2";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(68, 135);
            this.DtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(298, 26);
            this.DtpFechaNacimiento.TabIndex = 7;
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Location = new System.Drawing.Point(900, 214);
            this.ChkEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Size = new System.Drawing.Size(86, 24);
            this.ChkEstado.TabIndex = 8;
            this.ChkEstado.Text = "Estado";
            this.ChkEstado.UseVisualStyleBackColor = true;
            // 
            // BtnAgrgar
            // 
            this.BtnAgrgar.Location = new System.Drawing.Point(124, 208);
            this.BtnAgrgar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgrgar.Name = "BtnAgrgar";
            this.BtnAgrgar.Size = new System.Drawing.Size(112, 35);
            this.BtnAgrgar.TabIndex = 9;
            this.BtnAgrgar.Text = "Agregar";
            this.BtnAgrgar.UseVisualStyleBackColor = true;
            this.BtnAgrgar.Click += new System.EventHandler(this.BtnAgrgar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(344, 214);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(112, 35);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(578, 214);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 35);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.AutoSize = true;
            this.LblIdUsuario.Location = new System.Drawing.Point(88, 190);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(51, 20);
            this.LblIdUsuario.TabIndex = 13;
            this.LblIdUsuario.Text = "label5";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 706);
            this.Controls.Add(this.LblIdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgrgar);
            this.Controls.Add(this.ChkEstado);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido2);
            this.Controls.Add(this.TxtApellido1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.DgvUsuarios);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ChkEstado;
        private System.Windows.Forms.Button BtnAgrgar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblIdUsuario;
    }
}