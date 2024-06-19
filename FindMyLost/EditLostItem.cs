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
    public partial class EditLostItem : Form
    {
        public static PictureBox pb1;
        public static string form;
        string ItemID = ItemList.SelectedItemID;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public EditLostItem()
        {
            InitializeComponent();
            pb1 = pbColor;
        }

        private void EditLostItemDescription_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Lost_Item WHERE item_id = '" + ItemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    var myColor = dr["item_colour"].ToString();
                    cmbColor.Text = myColor;
                    pbColor.BackColor = Color.FromName(myColor);

                    txtLocation.Text = dr["last_seen_location"].ToString();
                    txtBrand.Text = dr["item_brand"].ToString();
                    txtAdditional.Text = dr["additional_info"].ToString();

                    string txtcategory = dr["item_category"].ToString();

                    if (txtcategory == radioClothing.Text)
                    {
                        radioClothing.Checked = true;
                    }
                    else if (txtcategory == radioElec.Text)
                    {
                        radioElec.Checked = true;
                    }
                    else if (txtcategory == radioBag.Text)
                    {
                        radioBag.Checked = true;
                    }
                    else if (txtcategory == radioAccessories.Text)
                    {
                        radioAccessories.Checked = true;
                    }
                    else if (txtcategory == radioAnimal.Text)
                    {
                        radioAnimal.Checked = true;
                    }
                    else if (txtcategory == radioDocuments.Text)
                    {
                        radioDocuments.Checked = true;
                    }
                    else if (txtcategory == radioOther.Text)
                    {
                        radioOther.Checked = true;
                    }

                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    imgItem.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Item ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnBrowse_MouseEnter(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.Black;
            btnBrowse.BackColor = Color.White;
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.White;
            btnBrowse.BackColor = Color.FromArgb(23, 23, 23);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageLocation = ofd.FileName;
                imgItem.ImageLocation = ImageLocation;
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((category != "") && (txtBrand.Text != "") && (cmbColor.Text != ""))
            {
                try
                {

                    string sql = "UPDATE Lost_Item SET item_category = '" + category + "', item_colour = '" + cmbColor.Text + "', item_picture =  @image , last_seen_location = '" + txtLocation.Text + "', item_brand = '" + txtBrand.Text + "', additional_info = '" + txtAdditional.Text + "' WHERE item_id = '" + ItemID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    var img = imgItem.Image;
                    byte[] imageBytes;
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();

                    cmd.Parameters.AddWithValue("@image", imageBytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item details updated successfully!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    ClaimItem.claimID = "";
                    Dashboard.tlp.Visible = true;
                    Dashboard.ShowItemList();
                    Dashboard.ShowDefault();
                }

            }
            else
            {
                MessageBox.Show("Please fill all in fields marked with a * ", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_color = cmbColor.Text;
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
            DialogResult result = MessageBox.Show("Cancel editting?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
                Dashboard.tlp.Visible = true;
                Dashboard.ShowItemList();
                Dashboard.ShowDefault();
            }
        }
    }
}

