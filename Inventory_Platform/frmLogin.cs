using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Inventory_Platform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-L9RF21BK;Initial Catalog=UserID;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string login = "SELECT * FROM UserID WHERE EmailID='" + txtUsername.Text + "' and Passwd='" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {

            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';


            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
