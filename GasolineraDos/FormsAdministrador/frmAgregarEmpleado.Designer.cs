﻿namespace Gasolinera.FormsAdministrador {
    partial class frmAgregarEmpleado {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGalones = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboxCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(404, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(656, 260);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(345, 23);
            this.txtContraseña.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(404, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(656, 207);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(345, 23);
            this.txtTelefono.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(65)))), ((int)(((byte)(134)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(526, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 46);
            this.button1.TabIndex = 42;
            this.button1.Text = "AÑADIR  EMPLEADO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblGalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGalones.ForeColor = System.Drawing.Color.Thistle;
            this.lblGalones.Location = new System.Drawing.Point(404, 152);
            this.lblGalones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(84, 24);
            this.lblGalones.TabIndex = 41;
            this.lblGalones.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.Thistle;
            this.lblPrecio.Location = new System.Drawing.Point(404, 92);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 24);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "DUI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(656, 152);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 23);
            this.txtNombre.TabIndex = 39;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(656, 97);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(345, 23);
            this.txtDUI.TabIndex = 38;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1478, 811);
            this.dataGridView3.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(404, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cargo:";
            // 
            // cmboxCargo
            // 
            this.cmboxCargo.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Vendedor"});
            this.cmboxCargo.FormattingEnabled = true;
            this.cmboxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cmboxCargo.Location = new System.Drawing.Point(656, 318);
            this.cmboxCargo.Name = "cmboxCargo";
            this.cmboxCargo.Size = new System.Drawing.Size(345, 23);
            this.cmboxCargo.TabIndex = 49;
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.cmboxCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGalones);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAgregarEmpleado";
            this.Text = "frmAgregarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGalones;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Label label3;
        private ComboBox cmboxCargo;
    }
}