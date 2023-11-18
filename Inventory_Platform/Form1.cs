using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Drawing;

namespace Inventory_Platform
{
    public partial class frmRegister : Form
    {

        public frmRegister()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-L9RF21BK;Initial Catalog=UserID;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);
            if (txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtComPassword.Text)
            {


                con.Open();
                string EmailID = txtUsername.Text;
                string password = txtpassword.Text;
                string Register = "INSERT INTO Emails (EmailID , Passwd) VALUES ('" + EmailID + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(Register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Succesfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

    }
}