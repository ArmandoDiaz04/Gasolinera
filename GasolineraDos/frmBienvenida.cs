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

namespace Gasolinera {
    public partial class frmBienvenida : Form {
        string cargoR;
        public frmBienvenida(string usuario) {
            InitializeComponent();
            cargoR = usuario;
        }


        private void timer1_Tick(object sender, EventArgs e) {
            if (this.Opacity<1) this.Opacity+=0.05;
            this.progressBar1.Value+=1;
            if (progressBar1.Value == 100) {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void frmBienvenida_Load(object sender, EventArgs e)
        {

            timer1.Start();
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            if (screenWidth < 1920 || screenHeight<1080)
            {
                var scaleFactor = Math.Min((double)screenWidth / 1920, (double)screenHeight / 1080);
                this.Size = new Size((int)(1920 * scaleFactor), (int)(1080 * scaleFactor));

                this.TopMost = true; // El formulario se muestra siempre en primer plano
                this.Font = new Font(this.Font.FontFamily, (float)(this.Font.Size * scaleFactor));
                ///configura la posicion segun tamaño
               
            }
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

        }
        private void pictureBox1_Click(object sender, EventArgs e) {

        }

       

        private void label2_Click(object sender, EventArgs e) {

        }

        private void timer2_Tick(object sender, EventArgs e) {
            this.Opacity -= 0.01;
            if (this.Opacity==0) {
                timer2.Stop();
                if (cargoR.Equals("Administrador"))
                {
                    this.Hide();
                    new frmMenuAdmin().ShowDialog();
                }
                else if (cargoR.Equals("Vendedor"))
                {
                    this.Hide();
                    new Form1().ShowDialog();
                }            
                
            }
        }
    }
}
