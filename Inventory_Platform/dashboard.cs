using System;
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

        private void dashboard_Load(object sender, EventArgs e)
        {

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


            if (this.vf1.Visible == false)
            {
                this.vf1.Visible = true;
            }
            else if (this.vf1.Visible == true)
            {
                this.vf1.Visible = false;
            }


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (this.df1.Visible == false)
            {
                this.df1.Visible = true;
            }
            else if (this.df1.Visible == true)
            {
                this.df1.Visible = false;
            }



        }

        private void vendorfrm14_Load(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
