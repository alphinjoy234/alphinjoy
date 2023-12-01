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
using Org.BouncyCastle.Cmp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Inventory_Platform
{
    public partial class vendorfrm1 : UserControl
    {
        SqlConnection ConnectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amalr\Source\Repos\Inventory_Platform\Inventory_Platform\Database1.mdf;Integrated Security=True;Connect Timeout=30");

        public vendorfrm1()
        {
            InitializeComponent();
            //To display the data from database to your datagrid view
            displayVendorData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void displayVendorData()
        {
            VendorData vd = new VendorData();
            List<VendorData> listData = vd.vendorListData();
            dataGridView1.DataSource = listData;
        }


        public void clearFields()
        {
            addVendorID.Text = "";
            addproductname.Text = "";
            addproductdetails.Text = "";
            addsoftwaretype.Text = "";
            addcompanyname.Text = "";
            addcompanyweb.Text = "";
            addcompanydetails.Text = "";
            addcompanyadrs.Text = "";

        }







        private void add_btn_Click(object sender, EventArgs e)
        {
            if (addVendorID.Text == ""
               || addproductname.Text == ""
               || addproductdetails.Text == ""
               || addsoftwaretype.Text == ""
               || addcompanyname.Text == ""
               || addcompanydetails.Text == ""
               || addcompanyweb.Text == ""
               || addcompanyadrs.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ConnectionString.State == ConnectionState.Closed)
                {
                    try
                    {

                        ConnectionString.Open();
                        string checkVID = "SELECT COUNT(*) FROM VendorInv WHERE VendorID = @vendorid";
                        using (SqlCommand checkid = new SqlCommand(checkVID, ConnectionString))
                        {
                            checkid.Parameters.AddWithValue("@vendorid", addVendorID.Text.Trim());
                            int count = (int)checkid.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addVendorID.Text.Trim() + "is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO VendorInv " +
                                "(VendorID,ProductName,ProductDetails,TypeOfSoftware,CompanyName,CompanyWebsite,CompanyDetails,CompanyAddress,InsertDate)" +
                                "VALUES(@vendorid,@productname,@productdetails,@typeofsoftware,@companyname,@companywebsite,@companydetails,@companyaddress,@insertdate)";
                                using (SqlCommand cmd = new SqlCommand(insertData, ConnectionString))
                                {
                                    cmd.Parameters.AddWithValue("@vendorid", addVendorID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@productname", addproductname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@productdetails", addproductdetails.Text.Trim());
                                    cmd.Parameters.AddWithValue("@typeofsoftware", addsoftwaretype.Text.Trim());
                                    cmd.Parameters.AddWithValue("@companyname", addcompanyname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@companywebsite", addcompanyweb.Text.Trim());
                                    cmd.Parameters.AddWithValue("@companydetails", addcompanydetails.Text.Trim());
                                    cmd.Parameters.AddWithValue("@companyaddress", addcompanyadrs.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertdate", today);
                                    cmd.ExecuteNonQuery();
                                    displayVendorData();
                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                    }
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (addVendorID.Text == "" || addproductname.Text == "" || addproductdetails.Text == "" || addsoftwaretype.Text == "" || addcompanyname.Text == "" || addcompanydetails.Text == "" || addcompanyweb.Text == "" || addcompanyadrs.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE" + "Vendor ID:" + addVendorID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        ConnectionString.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE VendorInv SET ProductName=@productname,ProductDetails=@productdetails,TypeOfSoftware=@typeofsoftware,CompanyName=@companyname,CompanyWebsite=@companywebsite,CompanyDetails=@companydetails,CompanyAddress=@companyaddress,UpdateDate=@updatedate WHERE VendorID=@vendorid";

                        using (SqlCommand cmd = new SqlCommand(updateData, ConnectionString))
                        {
                            cmd.Parameters.AddWithValue("@vendorid", addVendorID.Text.Trim());
                            cmd.Parameters.AddWithValue("@productname", addproductname.Text.Trim());
                            cmd.Parameters.AddWithValue("@productdetails", addproductdetails.Text.Trim());
                            cmd.Parameters.AddWithValue("@typeofsoftware", addsoftwaretype.Text.Trim());
                            cmd.Parameters.AddWithValue("@companyname", addcompanyname.Text.Trim());
                            cmd.Parameters.AddWithValue("@companywebsite", addcompanyweb.Text.Trim());
                            cmd.Parameters.AddWithValue("@companydetails", addcompanydetails.Text.Trim());
                            cmd.Parameters.AddWithValue("@companyaddress", addcompanyadrs.Text.Trim());
                            cmd.Parameters.AddWithValue("@updatedate", today);
                            cmd.ExecuteNonQuery();
                            displayVendorData();
                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ConnectionString.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addVendorID.Text = row.Cells[1].Value.ToString();
                addproductname.Text = row.Cells[2].Value.ToString();
                addproductdetails.Text = row.Cells[3].Value.ToString();
                addsoftwaretype.Text = row.Cells[4].Value.ToString();
                addcompanyname.Text = row.Cells[5].Value.ToString();
                addcompanyweb.Text = row.Cells[6].Value.ToString();
                addcompanydetails.Text = row.Cells[7].Value.ToString();
                addcompanyadrs.Text = row.Cells[8].Value.ToString();


            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (addVendorID.Text == "" || addproductname.Text == "" || addproductdetails.Text == "" || addsoftwaretype.Text == "" || addcompanyname.Text == "" || addcompanydetails.Text == "" || addcompanyweb.Text == "" || addcompanyadrs.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE" + "Vendor ID:" + addVendorID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        ConnectionString.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE VendorInv SET DeleteDate=@deletedate WHERE VendorID=@vendorid";

                        using (SqlCommand cmd = new SqlCommand(updateData, ConnectionString))
                        {
                            cmd.Parameters.AddWithValue("@deletedate", today);
                            cmd.Parameters.AddWithValue("@vendorid", addVendorID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayVendorData();
                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        ConnectionString.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearFields(); 
        }
    }
}
