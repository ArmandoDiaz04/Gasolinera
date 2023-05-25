using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera {
    public partial class frmVenta : Form {
        private TextBox textField;
        private ContextBd contexto;
        public frmVenta() {
            InitializeComponent();
            llenarCombo();
        }
        public void llenarCombo()
        {
            string[] elementos = { "---Seleccione una opción--", "SUPER", "REGULAR","DIESEL" };
            this.comboBox1.Items.AddRange(elementos);
            comboBox1.SelectedIndex = 0;
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {
          
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textField.Text += button.Text;
        }


       

        private void lblPrecio_Click(object sender, EventArgs e) {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
            int idep = int.Parse(emple);

            double calcu = double.Parse(txtPrecio.Text) ;
            double pre = calcu * 3.24;                                  
            double tt = pre*1.13;

            Venta venta = new Venta
            {
                
                IdEmpleado = idep,
                IdCliente = 1,
                Precio =pre ,
                ImpuestoF = 2.0,
                IVA = 0.13,
                Total = 13.5
            };


        // detalle insert 
        DetalleVentas detalleVentas = new DetalleVentas(); 
            
            int bomba =0;

            if (this.comboBox1.Text.Trim() == "SUPER")
            {   
                bomba = 1;

            }else if (this.comboBox1.Text.Trim() == "REGULAR")
            {
                bomba=2;
            }else if (this.comboBox1.Text.Trim() == "DIESEL")
            {
                bomba = 3;
            }


            DetalleVenta dv = new DetalleVenta
            {
                ID_BOMBA = bomba,
                Cantidad = calcu,
                Descuento = 0,
                Precio = tt

            };

            ven.CrearVenta(venta,dv);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtPrecio.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button10.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGalones_Click(object sender, EventArgs e)
        {

        }
    }
}
