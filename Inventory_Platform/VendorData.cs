using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Inventory_Platform
{
    class VendorData
    {
        public int ID { get; set; }//0
        public string Vendor_ID { get; set; }//1
        public string Product_Name { get; set; }//2
        public string Product_Details { get; set; }//3
        public string Software_Type { get; set; }//4
        public string Company_Name { get; set; }//5
        public string Company_Website { get; set; }//6
        public string Company_Details { get; set; }//7
        public string Company_Address { get; set; }//8




        SqlConnection ConnectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amalr\Source\Repos\Inventory_Platform\Inventory_Platform\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public List<VendorData> vendorListData()
        {
            List<VendorData> listdata = new List<VendorData>();
            if (ConnectionString.State != ConnectionState.Open)
            {
                try
                {
                    ConnectionString.Open();

                    string SelectData = "SELECT * FROM VendorInv WHERE DeleteDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(SelectData, ConnectionString))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            VendorData vd = new VendorData();
                            vd.ID = (int)reader["id"];
                            vd.Vendor_ID = reader["VendorID"].ToString();
                            vd.Product_Name = reader["ProductName"].ToString();
                            vd.Product_Details = reader["ProductDetails"].ToString();
                            vd.Software_Type = reader["TypeOfSoftware"].ToString();
                            vd.Company_Name = reader["CompanyName"].ToString();
                            vd.Company_Website = reader["CompanyWebsite"].ToString();
                            vd.Company_Details = reader["CompanyDetails"].ToString();
                            vd.Company_Address = reader["CompanyAddress"].ToString();
                            listdata.Add(vd);
                        }


                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    ConnectionString.Close();
                }
            }
            return listdata;
        }

    }
}
