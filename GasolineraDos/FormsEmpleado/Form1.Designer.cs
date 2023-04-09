namespace Gasolinera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.PanelCRUD = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.PanelFrecuente = new System.Windows.Forms.Panel();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.btnAcumular = new System.Windows.Forms.Button();
            this.btnFrecuentes = new System.Windows.Forms.Button();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.PanelCRUD.SuspendLayout();
            this.PanelFrecuente.SuspendLayout();
            this.panelVenta.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.PanelCRUD);
            this.panelSideMenu.Controls.Add(this.btnGestionar);
            this.panelSideMenu.Controls.Add(this.PanelFrecuente);
            this.panelSideMenu.Controls.Add(this.btnFrecuentes);
            this.panelSideMenu.Controls.Add(this.panelVenta);
            this.panelSideMenu.Controls.Add(this.btnVenta);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(304, 749);
            this.panelSideMenu.TabIndex = 0;
            // 
            // PanelCRUD
            // 
            this.PanelCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.PanelCRUD.Controls.Add(this.button2);
            this.PanelCRUD.Controls.Add(this.button1);
            this.PanelCRUD.Controls.Add(this.btnClientes);
            this.PanelCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCRUD.Location = new System.Drawing.Point(0, 511);
            this.PanelCRUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelCRUD.Name = "PanelCRUD";
            this.PanelCRUD.Size = new System.Drawing.Size(304, 140);
            this.PanelCRUD.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(304, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar Cliente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(304, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Editar Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.LightGray;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(304, 46);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Añadir Cliente";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGestionar
            // 
            this.btnGestionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionar.FlatAppearance.BorderSize = 0;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionar.Location = new System.Drawing.Point(0, 464);
            this.btnGestionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGestionar.Size = new System.Drawing.Size(304, 47);
            this.btnGestionar.TabIndex = 6;
            this.btnGestionar.Text = "Gestionar Clientes";
            this.btnGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // PanelFrecuente
            // 
            this.PanelFrecuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.PanelFrecuente.Controls.Add(this.btnCanjear);
            this.PanelFrecuente.Controls.Add(this.btnAcumular);
            this.PanelFrecuente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFrecuente.Location = new System.Drawing.Point(0, 361);
            this.PanelFrecuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelFrecuente.Name = "PanelFrecuente";
            this.PanelFrecuente.Size = new System.Drawing.Size(304, 103);
            this.PanelFrecuente.TabIndex = 5;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanjear.FlatAppearance.BorderSize = 0;
            this.btnCanjear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCanjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanjear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCanjear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCanjear.Location = new System.Drawing.Point(0, 46);
            this.btnCanjear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.btnCanjear.Size = new System.Drawing.Size(304, 46);
            this.btnCanjear.TabIndex = 1;
            this.btnCanjear.Text = "Canjear Puntos";
            this.btnCanjear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // btnAcumular
            // 
            this.btnAcumular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcumular.FlatAppearance.BorderSize = 0;
            this.btnAcumular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAcumular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcumular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcumular.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcumular.Location = new System.Drawing.Point(0, 0);
            this.btnAcumular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAcumular.Name = "btnAcumular";
            this.btnAcumular.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.btnAcumular.Size = new System.Drawing.Size(304, 46);
            this.btnAcumular.TabIndex = 0;
            this.btnAcumular.Text = "Acumular Puntos";
            this.btnAcumular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcumular.UseVisualStyleBackColor = true;
            this.btnAcumular.Click += new System.EventHandler(this.btnAcumular_Click);
            // 
            // btnFrecuentes
            // 
            this.btnFrecuentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrecuentes.FlatAppearance.BorderSize = 0;
            this.btnFrecuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrecuentes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFrecuentes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFrecuentes.Location = new System.Drawing.Point(0, 314);
            this.btnFrecuentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrecuentes.Name = "btnFrecuentes";
            this.btnFrecuentes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFrecuentes.Size = new System.Drawing.Size(304, 47);
            this.btnFrecuentes.TabIndex = 4;
            this.btnFrecuentes.Text = "Cliente Frecuente";
            this.btnFrecuentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrecuentes.UseVisualStyleBackColor = true;
            this.btnFrecuentes.Click += new System.EventHandler(this.btnFrecuentes_Click);
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.panelVenta.Controls.Add(this.btnFactura);
            this.panelVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVenta.Location = new System.Drawing.Point(0, 252);
            this.panelVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(304, 62);
            this.panelVenta.TabIndex = 3;
            this.panelVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFactura.ForeColor = System.Drawing.Color.LightGray;
            this.btnFactura.Location = new System.Drawing.Point(0, 0);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.btnFactura.Size = new System.Drawing.Size(304, 46);
            this.btnFactura.TabIndex = 0;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVenta.Location = new System.Drawing.Point(0, 205);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVenta.Size = new System.Drawing.Size(304, 47);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(304, 205);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(304, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1066, 749);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1010, 790);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.PanelCRUD.ResumeLayout(false);
            this.PanelFrecuente.ResumeLayout(false);
            this.panelVenta.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel PanelCRUD;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Panel PanelFrecuente;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Button btnAcumular;
        private System.Windows.Forms.Button btnFrecuentes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

