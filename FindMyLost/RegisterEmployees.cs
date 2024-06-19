using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace FindMyLost
{
    public partial class RegisterEmployees : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public RegisterEmployees()
        {
            InitializeComponent();
        }

        private void btnEditUserPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnEditUserPic_MouseEnter(object sender, EventArgs e)
        {
            btnEditUserPic.ForeColor = Color.Black;
        }

        private void btnEditUserPic_MouseLeave(object sender, EventArgs e)
        {
            btnEditUserPic.ForeColor = Color.White;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtMobileNum.Text == "" || txtTelNumber.Text == "" || pbUserImage.Image == null || cbPosition.Text == "" || cbGender.Text == "")
            {
                MessageBox.Show("Please fill in all the employee details!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var employee_image = pbUserImage.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    employee_image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();

                    string sql = "INSERT INTO Employee (first_name, last_name, email, address, mobile_number, telephone_number, password, picture, position, gender, DOB) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + txtMobileNum.Text + "', '" + txtTelNumber.Text + "', 'aaAA12!@', @image, '" + cbPosition.Text + "', '" + cbGender.Text + "', '" + dtpDOB.Value + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Registration Successful!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    dtpDOB.Value = Convert.ToDateTime("01 - Jan - 05");
                    cbGender.SelectedIndex = -1;
                    txtEmail.Clear();
                    txtMobileNum.Clear();
                    txtTelNumber.Clear();
                    txtAddress.Clear();
                    cbPosition.SelectedIndex = -1;
                    pbUserImage.Image = Properties.Resources.user_avatar;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Registering?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dashboard.DisplayHome();
            }
        }
    }
}
