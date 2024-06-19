using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Configuration;
using System.Data.SqlClient;

namespace FindMyLost
{
    public partial class EmployeeList : Form //MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public EmployeeList()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green700, Primary.Green700, Accent.LightBlue100, TextShade.WHITE);
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            lvEmployeeList.FullRowSelect = true;

            try
            {
                string sql = "SELECT employee_id, first_name, last_name, mobile_number, position FROM Employee";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr.GetInt32(0).ToString());
                    item.SubItems.Add(dr.GetString(1));
                    item.SubItems.Add(dr.GetString(2));
                    item.SubItems.Add(dr.GetString(3));
                    item.SubItems.Add(dr.GetString(4));

                    lvEmployeeList.Items.Add(item);
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

        public static string SelectedEmployeeID;
        public static string initialForm;

        private void lvEmployeeList_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvEmployeeList.SelectedItems[0];
            SelectedEmployeeID = item.SubItems[0].Text;
            initialForm = "EmployeeList";
            Dashboard.ShowEmployeeProfile();
        }

    }
}
