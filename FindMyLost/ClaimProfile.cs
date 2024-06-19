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
using Microsoft.VisualBasic;

namespace FindMyLost
{
    public partial class Claim : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Claim()
        {
            InitializeComponent();
        }

        string SelectedClaimID = ClaimList.SelectedClaimID;

        private void ClaimProfile_Load(object sender, EventArgs e)
        {
            try
            {
                if (ClaimList.ToMatch == true)
                {
                    btnDelete.Visible = false;
                }

                byte[] imageBytes;

                string sql = "SELECT * FROM Claim WHERE claim_id = '" + SelectedClaimID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblID.Text = dr["claim_id"].ToString();
                    lblCategory.Text = dr["item_category"].ToString();
                    lblLastSeen.Text = dr["last_seen_location"].ToString();
                    lblBrand.Text = dr["item_brand"].ToString();
                    lblAddInfo.Text = dr["additional_info"].ToString();
                    lblName.Text = dr["claimer_name"].ToString();
                    lblPhoneNum.Text = dr["claimer_phone_number"].ToString();
                    lblAddress.Text = dr["claimer_address"].ToString();

                    string item_color = dr["item_colour"].ToString();

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

                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbItemPic.Image = img;
                }
                else
                {
                    MessageBox.Show("Invalid Claim ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        string itemID;
        private void btnMatch_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you Sure?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (ClaimList.ToMatch == true)
                {
                    itemID = ListItem.itemID;
                }
                else
                {
                    itemID = Interaction.InputBox("Enter ID of the item claimed. ", "FindMyLost");
                    if (itemID == "")
                    {
                        MessageBox.Show("Invalid ID!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string sql = "SELECT * FROM Lost_Item WHERE item_id = '" + itemID + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (!dr.Read())
                        {
                            MessageBox.Show("Invalid ID!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            itemID = "";
                        }
                        conn.Close();
                    }
                }

                if (itemID != "")
                {
                    try
                    {
                        string sql = "INSERT INTO Found (claimer_name, claimer_address, claimer_phone_number, item_category, item_colour, item_picture, last_seen_location, item_brand, additional_info) SELECT claimer_name, claimer_address, claimer_phone_number, item_category, item_colour, item_picture, last_seen_location, item_brand, additional_info FROM Claim WHERE claim_id = '" + SelectedClaimID + "'; DELETE FROM Claim WHERE claim_id = '" + SelectedClaimID + "'; DELETE FROM Lost_Item WHERE item_id = '" + itemID + "';";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ureka! Another lost item found.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        this.Hide();
                        ListItem.itemID = "";
                        Dashboard.ShowDefault();
                        Dashboard.ShowClaimList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Delete Claim?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Claim WHERE claim_id = '" + SelectedClaimID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Claim deleted!", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    this.Hide();
                    ListItem.itemID = "";
                    Dashboard.ShowDefault();
                    Dashboard.ShowClaimList();
                }
            }
        }

    }
}
