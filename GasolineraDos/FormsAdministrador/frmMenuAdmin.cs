using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera.FormsAdministrador {
    public partial class frmMenuAdmin : Form {
        public frmMenuAdmin() {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, EventArgs e) {

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth < 1920 || screenHeight < 1080)
            {
                var scaleFactor = Math.Min((double)screenWidth / 1920, (double)screenHeight / 1080);
                this.Size = new Size((int)(1920 * scaleFactor), (int)(1080 * scaleFactor));

                this.TopMost = true; // El formulario se muestra siempre en primer plano
                this.Font = new Font(this.Font.FontFamily, (float)(this.Font.Size * scaleFactor * 1.1));


            }
            ///configura la posicion segun tamaño
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }
        private void personalizarDiseño() {
            panelGesionEmpleado.Visible = false;
            PanelAdmin.Visible = false;
            PanelReportes.Visible = false;
        }

        private void ocultarSubMenus() {
            if (panelGesionEmpleado.Visible == true)
                panelGesionEmpleado.Visible = false;
            if (PanelAdmin.Visible == true)
                PanelAdmin.Visible = false;
            if (PanelReportes.Visible == true)
                PanelReportes.Visible = false;
        }

        private void mostrarSubMenus(Panel subMenu) {
            if (subMenu.Visible == false) {
                ocultarSubMenus();
                subMenu.Visible = true;
            } else {
                subMenu.Visible = false;
            }


        }
        private Form? formActivo = null;
        private void abrirFormularios(Form formHijo) {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

       

        private void btnGestionarFactura_Click(object sender, EventArgs e) {
            mostrarSubMenus(panelGesionEmpleado);
        }
        private void btnAñadirEmpleado_Click(object sender, EventArgs e) {
            abrirFormularios(new frmAgregarEmpleado());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }
   
        //
        private void btnFrecuentes_Click(object sender, EventArgs e) {
            mostrarSubMenus(PanelAdmin);
        }
        private void btnCargarBombas_Click(object sender, EventArgs e) {
            //dejar hasta abajo por que este cierra los submenu :P
            abrirFormularios(new frmAdministracionInventarios());
            ocultarSubMenus();
        }

        //
        private void btnGenerarReportes_Click(object sender, EventArgs e) {
            mostrarSubMenus(PanelReportes);
        }

       
    }
}
