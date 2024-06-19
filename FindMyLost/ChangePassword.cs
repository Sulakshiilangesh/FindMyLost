using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace FindMyLost
{
    public partial class ChangePassword : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ChangePassword()
        {
            InitializeComponent();
        }

        string empID = Login.empId;

        private static Regex PasswordValidation()
        {
            string pattern = "^.*(?=.{7,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex vaildate_password = PasswordValidation();

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblCorrect.Hide();
            lblWrong.Hide();
            lblCorrect2.Hide();
            lblWrong2.Hide();
            lblCorrect0.Hide();
            lblWrong0.Hide();
        }   

        private void txtNP_TextChanged(object sender, EventArgs e)
        {

            // new password has atleast 7 characters
            if (txtNP.TextLength < 7)
            {
                lbl7Char.Text = "❌";
                lbl7Char.ForeColor = Color.Red;
            }
            else
            {
                lbl7Char.Text = "✔";
                lbl7Char.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 number
            if (txtNP.Text.Any(char.IsDigit) == false)
            {
                lbl1num.Text = "❌";
                lbl1num.ForeColor = Color.Red;
            }
            else
            {
                lbl1num.Text = "✔";
                lbl1num.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 uppercase letter
            if (txtNP.Text.Any(char.IsUpper) == false)
            {
                lbl1uppercase.Text = "❌";
                lbl1uppercase.ForeColor = Color.Red;
            }
            else
            {
                lbl1uppercase.Text = "✔";
                lbl1uppercase.ForeColor = Color.LawnGreen;
            }

            // new password has atleast 1 special character

            string newPwd = txtNP.Text;
            Match match = Regex.Match(newPwd, "[^a-z0-9]", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                lbl1splchar.Text = "✔";
                lbl1splchar.ForeColor = Color.LawnGreen;
            }
            else
            {
                lbl1splchar.Text = "❌";
                lbl1splchar.ForeColor = Color.Red;
            }

            // new password is not the same as old
            if (txtOldPassword.Text == txtNP.Text)
            {
                lblNew.Text = "❌";
                lblNew.ForeColor = Color.Red;
            }
            else
            {
                lblNew.Text = "✔";
                lblNew.ForeColor = Color.LawnGreen;
            }


            if (vaildate_password.IsMatch(txtNP.Text) != true)
            {
                lblWrong.Show();
                txtNP.Focus();
                return;
            }

            else
            {
                lblWrong.Hide();
                lblCorrect.Show();
            }
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            if (txtCNP.Text == txtNP.Text)
            {
                lblCorrect2.Show();
                lblWrong2.Hide();

            }
            else
            {
                lblWrong2.Show();
                lblCorrect2.Hide();
            }
        }

        private void btnViewOP_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.PasswordChar == '⁕')
            {
                txtOldPassword.PasswordChar = '\0';
                txtNP.PasswordChar = '⁕';
                txtCNP.PasswordChar = '⁕';
            }
            else
            {
                txtOldPassword.PasswordChar = '⁕';
            }
        }

        private void btnViewNP_Click(object sender, EventArgs e)
        {
            if (txtNP.PasswordChar == '⁕')
            {
                txtNP.PasswordChar = '\0';
                txtOldPassword.PasswordChar = '⁕';
                txtCNP.PasswordChar = '⁕';
            }
            else
            {
                txtNP.PasswordChar = '⁕';
            }
        }

        private void btnViewCNP_Click(object sender, EventArgs e)
        {
            if (txtCNP.PasswordChar == '⁕')
            {
                txtCNP.PasswordChar = '\0';
                txtNP.PasswordChar = '⁕';
                txtOldPassword.PasswordChar = '⁕';
            }
            else
            {
                txtCNP.PasswordChar = '⁕';
            }
        }
        string OldPassword;
        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT password FROM Employee WHERE employee_id = '" + empID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    OldPassword = dr["password"].ToString();
                    if (OldPassword == txtOldPassword.Text)
                    {
                        lblCorrect0.Show();
                        lblWrong0.Hide();
                    }
                    else
                    {
                        lblWrong0.Show();
                        lblCorrect0.Hide();
                    }
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((vaildate_password.IsMatch(txtNP.Text) != true))
            {
                MessageBox.Show("New password does not match criteria", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (OldPassword != txtOldPassword.Text)
            {
                MessageBox.Show("Incorrect Old Password", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNP.Text != txtCNP.Text)
            {
                MessageBox.Show("Passwords do not match", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string sql = "UPDATE Employee SET password = '" + txtNP.Text + "' WHERE employee_id = '" + empID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your password has been changed successfully", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Dashboard.DisplayHome();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Cancel Change Password?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
                Dashboard.DisplayHome();
            }
           
        }

    }
}
