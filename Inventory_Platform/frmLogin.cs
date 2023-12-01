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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Inventory_Platform
{
    public partial class frmLogin : Form
    {
        static SqlConnection con = null!;
        static SqlCommand cmd = null!;
        static SqlDataReader reader = null!;
        public frmLogin()
        {
            InitializeComponent();
            Database_Connection();
        }

        private void Database_Connection()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Anufathima\Inventory_Platform\Inventory_Platform\Database1.mdf;Integrated Security=True";

            con = new SqlConnection(ConnectionString);


        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            
            if (txtUsername.Text.Equals("admin") && txtpassword.Text.Equals("admin@2331"))
            {
                new dashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text.Equals("user") && txtpassword.Text.Equals("user@2331"))
            {

            
            new UserDashboard().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("The Username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }
            //string login = "SELECT * FROM CompanyInv WHERE USERNAME='" + txtUsername.Text + "' and PASSWORD ='" + txtpassword.Text + "'";
            //cmd = new SqlCommand(login, con);


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}