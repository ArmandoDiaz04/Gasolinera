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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
            this.placeHolder(); 
        }

        public void placeHolder() {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Tag.ToString();             
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox2.Tag.ToString();
            }
        }


        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == textBox1.Tag.ToString())
            {
                textBox1.Text = "";

            }
           
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == textBox2.Tag.ToString())
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == textBox1.Tag.ToString())
            {
                textBox1.Text = "";

            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == textBox2.Tag.ToString())
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBienvenida().ShowDialog();
         
        }
    }
}
