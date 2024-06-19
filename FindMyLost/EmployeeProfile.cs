using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace FindMyLost
{
    public partial class EmployeeProfile : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public EmployeeProfile()
        {
            InitializeComponent();
        }

        public static string EmployeeID = "";
        string SelectedEmployeeID = EmployeeList.SelectedEmployeeID;


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE from Employee WHERE employee_id = '" + SelectedEmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Account Deleted.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                Dashboard.ShowDefault();
                Dashboard.ShowEmployeeList();
            }
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Employee WHERE employee_id = '" + SelectedEmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    string firstName = dr["first_name"].ToString();
                    string lastName = dr["last_name"].ToString();
                    lblName.Text = firstName + " " + lastName;
                    lblPosition.Text = dr["position"].ToString();
                    lblID.Text = dr["employee_id"].ToString();
                    lblEmail.Text = dr["email"].ToString();
                    lblAddress.Text = dr["address"].ToString();
                    lblMobileNumber.Text = dr["mobile_number"].ToString();
                    lblTelNumber.Text = dr["telephone_number"].ToString();

                    imageBytes = (byte[])dr["picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbUserImage.Image = img;

                    EmployeeID = SelectedEmployeeID;

                }
                else
                {
                    MessageBox.Show("Invalid Employee ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dashboard.DisplayEditProfile();
        }
    }
}
