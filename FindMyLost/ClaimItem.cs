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
    public partial class ClaimItem : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public static PictureBox Colour;
        public static string form;

        public ClaimItem()
        {
            InitializeComponent();
            Colour = pbColor;
        }


        private void btnEditItemPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbItemPic.Image = new Bitmap(opnfd.FileName);
            }
        }

        string category;

        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            category = radioClothing.Text;
        }

        private void radioElec_CheckedChanged(object sender, EventArgs e)
        {
            category = radioElec.Text;
        }

        private void radioBag_CheckedChanged(object sender, EventArgs e)
        {
            category = radioBag.Text;
        }

        private void radioAccessories_CheckedChanged(object sender, EventArgs e)
        {
            category = radioAccessories.Text;
        }

        private void radioAnimal_CheckedChanged(object sender, EventArgs e)
        {
            category = radioAnimal.Text;
        }

        private void radioDocuments_CheckedChanged(object sender, EventArgs e)
        {
            category = radioDocuments.Text;
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            category = radioOther.Text;
        }

        public static string claimID;
        public static string claimCategory;
        public static string claimColour;


        private void btnPublishClaim_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtPhoneNum.Text == "" || category == "" || cbColor.Text == "")
            {
                MessageBox.Show("Please fill in all the employee details!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var item_image = pbItemPic.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    item_image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();

                    string sql = "INSERT INTO Claim (claimer_name, claimer_address, claimer_phone_number, item_category, item_colour, item_picture, last_seen_location, item_brand, additional_info) VALUES ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtPhoneNum.Text + "', '" + category + "', '" + cbColor.Text + "', @image, '" + txtLocation.Text + "', '" + txtBrand.Text + "', '" + txtAddInfo.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();

                    DialogResult result = MessageBox.Show("Do you want to view lost items that match this claim?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string sql = "SELECT * FROM Claim WHERE claim_id = (select max(claim_id) from Claim);";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                claimID = dr["claim_id"].ToString();
                                claimCategory = dr["item_category"].ToString();
                                claimColour = dr["item_colour"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                            Dashboard.tlp.Visible = true;
                            Dashboard.ShowItemList();
                            Dashboard.ShowDefault();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Claim Published Successfully!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPhoneNum.Clear();
                        txtAddress.Clear();
                        txtBrand.Clear();
                        txtAddInfo.Clear();
                        txtLocation.Clear();
                        cbColor.SelectedIndex = -1;
                        pbItemPic.Image = Properties.Resources.item_placeholder;
                        pbColor.BackColor = Color.Empty;
                        radioClothing.Checked = false;
                        radioElec.Checked = false;
                        radioBag.Checked = false;
                        radioAnimal.Checked = false;
                        radioDocuments.Checked = false;
                        radioAccessories.Checked = false;
                        radioOther.Checked = false;
                    }
                }
            }
        }

        private void btnEditItemPic_MouseEnter(object sender, EventArgs e)
        {
            btnEditItemPic.ForeColor = Color.Black;
        }

        private void btnEditItemPic_MouseLeave(object sender, EventArgs e)
        {
            btnEditItemPic.ForeColor = Color.White;
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_color = cbColor.Text;
            if (item_color == "Red")
            {
                pbColor.BackColor = Color.FromArgb(80, 0, 0);
            }
            else if (item_color == "Orange")
            {
                pbColor.BackColor = Color.FromArgb(203, 92, 12);
            }
            else if (item_color == "Yellow")
            {
                pbColor.BackColor = Color.FromArgb(217, 181, 30);
            }
            else if (item_color == "Green")
            {
                pbColor.BackColor = Color.FromArgb(73, 94, 53);
            }
            else if (item_color == "Blue")
            {
                pbColor.BackColor = Color.FromArgb(0, 51, 102);
            }
            else if (item_color == "Purple")
            {
                pbColor.BackColor = Color.FromArgb(52, 32, 72);
            }
            else if (item_color == "Pink")
            {
                pbColor.BackColor = Color.FromArgb(241, 145, 155);
            }
            else if (item_color == "Beige")
            {
                pbColor.BackColor = Color.FromArgb(145, 121, 77);
            }
            else if (item_color == "Brown")
            {
                pbColor.BackColor = Color.FromArgb(68, 33, 18);
            }
            else if (item_color == "Gray")
            {
                pbColor.BackColor = Color.FromArgb(50, 50, 50);
            }
            else if (item_color == "Black")
            {
                pbColor.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (item_color == "White")
            {
                pbColor.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Claim?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dashboard.DisplayHome();
            }
        }
    }
}
