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
    public partial class UserDashboard : Form
    {
        UserHome uh1 = new UserHome();
        Uservendor uv1 = new Uservendor();
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UserDashboard_Load(object sender, PaintEventArgs e)
        {
            uh1.Hide();
            uv1.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            this.panel6.Controls.Clear();
            uh1.TopLevel = false;
            this.panel6.Controls.Add(uh1);
            uh1.Show();
        }

        private void vendor_btn_Click(object sender, EventArgs e)
        {
            this.panel6.Controls.Clear();
            uv1.TopLevel = false;
            this.panel6.Controls.Add(uv1);
            uv1.Show();
        }
    }
}
