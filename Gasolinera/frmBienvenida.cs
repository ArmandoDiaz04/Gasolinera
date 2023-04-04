﻿using System;
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
        public frmBienvenida() {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e) {
            if (this.Opacity<1) this.Opacity+=0.05;
            this.progressBar1.Value+=1;
            if (progressBar1.Value == 100) {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void frmBienvenida_Load(object sender, EventArgs e) {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void timer2_Tick(object sender, EventArgs e) {
            this.Opacity -= 0.01;
            if (this.Opacity==0) {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
