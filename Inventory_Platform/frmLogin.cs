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
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Anufathima\Inventory_Platform\Inventory_Platform\Database1.mdf;Integrated Security=True";

            var con = new SqlConnection(ConnectionString);


            con.Open();
            string login = "SELECT * FROM LOGIN WHERE USERNAME='" + txtUsername.Text + "' and PASSWORD ='" + txtpassword.Text + "'";
            var cmd = new SqlCommand(login, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                new dashboard().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("The Username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
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

       

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}