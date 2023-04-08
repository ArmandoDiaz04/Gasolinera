using Gasolinera.FormsAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            personalizarDiseño();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }


        private void personalizarDiseño() {
            panelVenta.Visible = false;
            PanelFrecuente.Visible = false;
            PanelCRUD.Visible = false;
        }

        private void ocultarSubMenus() {
            if (panelVenta.Visible == true)
                panelVenta.Visible = false;
            if (PanelFrecuente.Visible == true)
                PanelFrecuente.Visible = false;
            if (PanelCRUD.Visible == true)
                PanelCRUD.Visible = false;
        }

        private void mostrarSubMenus(Panel subMenu) {
            if (subMenu.Visible == false) {
                ocultarSubMenus();
                subMenu.Visible = true;
            } else {
                subMenu.Visible = false;
            }


        }

        #region Venta
        private void button1_Click(object sender, EventArgs e) {
            mostrarSubMenus(panelVenta);
        }

        private void btnFactura_Click(object sender, EventArgs e) {
            //abrir formulario
            abrirFormularios(new frmVenta());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }
        #endregion

        #region ClientesFrecuentes  
        private void btnFrecuentes_Click(object sender, EventArgs e) {
            mostrarSubMenus(PanelFrecuente);
        }



        private void btnAcumular_Click(object sender, EventArgs e) {
            abrirFormularios(new frmAcumularPuntos());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }

        private void btnCanjear_Click(object sender, EventArgs e) {
            abrirFormularios(new frmCanjearPuntos());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }
        #endregion
        private void btnGestionar_Click(object sender, EventArgs e) {
            mostrarSubMenus(PanelCRUD);
        }

        #region GestionarClientes  
        private void btnClientes_Click(object sender, EventArgs e) {
            abrirFormularios(new frmGestionarUsuario());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }
        private void button1_Click_1(object sender, EventArgs e) {
            abrirFormularios(new frmEditarCliente());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }

        private void button2_Click(object sender, EventArgs e) {
            abrirFormularios(new frmEliminarCliente());
            //dejar hasta abajo por que este cierra los submenu :P
            ocultarSubMenus();
        }

       
        #endregion

        private Form? formActivo = null;
        private void abrirFormularios(Form formHijo) {
            if (formActivo!=null) 
                formActivo.Close();
            formActivo= formHijo;
            formHijo.TopLevel= false;
            formHijo.FormBorderStyle= FormBorderStyle.None;
            formHijo.Dock= DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag= formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e) {

        }

       
    }
}
