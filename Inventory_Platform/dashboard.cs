﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Platform
{
    public partial class dashboard : Form
    {
        vendorfrm1 vf1 = new vendorfrm1();
        dashform1 df1 = new dashform1();
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dashboard_Load(object sender, PaintEventArgs e)
        {
            vf1.Hide();
            df1.Hide();
        }

        private void manage_inv_Click(object sender, EventArgs e)
        {

            this.panel6.Controls.Clear();

            this.panel6.Controls.Add(vf1);
            vf1.Show();


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.panel6.Controls.Clear();

            this.panel6.Controls.Add(df1);
            df1.Show();



        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
