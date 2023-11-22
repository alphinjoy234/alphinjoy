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
using MySql.Data.MySqlClient;

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
            string ConnectionString = @"server=localhost;uid=root;pwd=1234;database=CITISOFT";

            var con = new MySqlConnection(ConnectionString);


            con.Open();
            string login = "SELECT * FROM LOGIN WHERE USERNAME='" + txtUsername.Text + "' and PASSWORD ='" + txtpassword.Text + "'";
            var cmd = new MySqlCommand(login, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                new dashboard().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("The Username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "username";
                txtpassword.Text = "password";
                txtUsername.Focus();
            }


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
        }


    }
}