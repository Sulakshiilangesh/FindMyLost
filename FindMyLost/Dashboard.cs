using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace FindMyLost
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Dashboard()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 75);
            SideMenu.Controls.Add(leftBorder);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            tlp = tlpList;
            formPanel = panelForm;
            menuPanel = panelMenu;
            title = lblCurrentPage;
            icon = iconCurrentPage;
            frontPanel = panelFront;
        }

        bool isITAdmin = Login.isITAdmin;
        string employeeID = Login.empId;
        private IconButton currentbtn;
        private Panel leftBorder;
        string currentPage;
        public static TableLayoutPanel tlp;
        public static Panel formPanel;
        public static Panel menuPanel;
        public static Panel frontPanel;
        public static Label title;
        public static IconPictureBox icon;
        public static string darkOrLight;

        private void BtnSelect(object btn)
        {
            if (btn != null)
            {
                BtnUnselect();
                currentbtn = (IconButton)btn;
                currentbtn.BackColor = Color.FromArgb(20, 20, 20);
                leftBorder.BackColor = Color.FromArgb(50, 128, 45);
                leftBorder.Location = new Point(0, currentbtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                iconCurrentPage.IconChar = currentbtn.IconChar;
                lblCurrentPage.Text = currentPage;
            }
        }

        private void BtnUnselect()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(15, 15, 15);
            }
        }

        private void CloseMenu()
        {
            panelMenu.Visible = false;
            btnMenu.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void Reset()
        {
            BtnUnselect();
            leftBorder.Visible = false;
            iconCurrentPage.IconChar = IconChar.Home;
            lblCurrentPage.Text = "HOME";
            CloseMenu();
            panelForm.Controls.Clear();
            formPanel.Controls.Add(tlp);
            tlp.Visible = false;
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(panelFront);
            panelFront.Visible = true;
        }

        public static void DisplayHome()
        {
            formPanel.Controls.Clear();
            formPanel.Controls.Add(menuPanel);
            formPanel.Controls.Add(tlp);
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = true;
            tlp.Visible = false;
            title.Text = "HOME";
            icon.IconChar = IconChar.Home;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            tlpList.Visible = false;
            try
            {
                panelMenu.Visible = false;
                if (isITAdmin == true)
                {
                    btnListItem.Visible = false;
                }
                else
                {
                    btnRegister.Visible = false;
                    btnEmployeeList.Visible = false;
                }

                byte[] imageBytes;

                string sql = "SELECT * FROM Employee WHERE employee_id = '" + employeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblEmployeeID.Text = employeeID;
                    lblName.Text = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                    lblEmail.Text = dr["email"].ToString();

                    imageBytes = (byte[])dr["picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbUser.Image = img;
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

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            panelMenu.Location = new Point((btnMenu.Location.X - 252), 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            currentPage = "REGISTER EMPLOYEES";
            BtnSelect(sender);
            CloseMenu();

            RegisterEmployees register = new RegisterEmployees() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(tlpList);
            tlpList.Visible = false;
            panelForm.Controls.Add(panelFront);
            frontPanel.Visible = false;
            register.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(register);
            register.Show();
        }

        private void btnClaimItem_Click(object sender, EventArgs e)
        {
            currentPage = "CLAIM AN ITEM";
            BtnSelect(sender);
            CloseMenu();

            ClaimItem claimItem = new ClaimItem() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(tlpList);
            tlpList.Visible = false;
            panelForm.Controls.Add(panelFront);
            frontPanel.Visible = false;
            claimItem.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(claimItem);
            claimItem.Show();
        }

        public static string list;

        //display FindMyLost2 in tlpList column 2
        public static void ShowDefault()
        {
            if (tlp.GetControlFromPosition(1, 0) != null)
            {
                tlp.GetControlFromPosition(1, 0).Dispose();
            }
            FindMyLost2 f2 = new FindMyLost2() { TopLevel = false, TopMost = true };
            f2.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(f2, 1, 0);
            f2.Show();
        }

        //display ItemList in tlpList column 1
        public static void ShowItemList()
        {
            if (tlp.GetControlFromPosition(0, 0) != null)
            {
                tlp.GetControlFromPosition(0, 0).Dispose();
            }
            ItemList itemList = new ItemList() { TopLevel = false, TopMost = true };
            itemList.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(itemList, 0, 0);
            itemList.Show();
            title.Text = "ITEM LIST";
            icon.IconChar = IconChar.Images;
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            currentPage = "ITEM LIST";
            BtnSelect(sender);
            CloseMenu();
            tlpList.Visible = true;
            list = "item";
            initialForm = "DB-I";

            tlpList.Controls.Clear();
            ShowItemList();
            ShowDefault();
            initialForm = "Dash";
        }

        //display ItemProfile in tlpList column 2
        public static void ShowItemProfile()
        {
            if (tlp.GetControlFromPosition(1, 0) != null)
            {
                tlp.GetControlFromPosition(1, 0).Dispose();
            }
            ItemProfile itemProfile = new ItemProfile() { TopLevel = false, TopMost = true };
            itemProfile.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(itemProfile, 1, 0);
            itemProfile.Show();
        }

        //display EditLostItem in panelForm
        public static void DisplayEditItem()
        {
            EditLostItem editLostItem = new EditLostItem() { TopLevel = false, TopMost = true };
            formPanel.Controls.Clear();
            formPanel.Controls.Add(menuPanel);
            formPanel.Controls.Add(tlp);
            tlp.Visible = false;
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = false;
            editLostItem.FormBorderStyle = FormBorderStyle.None;
            formPanel.Controls.Add(editLostItem);
            editLostItem.Show();
            title.Text = "EDIT LOST ITEM";
            icon.IconChar = IconChar.PenSquare;
        }

        //display EmployeeList in tlpList column 1
        public static void ShowEmployeeList()
        {
            if (tlp.GetControlFromPosition(0, 0) != null)
            {
                tlp.GetControlFromPosition(0, 0).Dispose();
            }
            EmployeeList empList = new EmployeeList() { TopLevel = false, TopMost = true };
            empList.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(empList, 0, 0);
            empList.Show();
            title.Text = "EMPLOYEE LIST";
            icon.IconChar = IconChar.Users;
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            currentPage = "EMPLOYEE LIST";
            BtnSelect(sender);
            CloseMenu();
            tlpList.Visible = true;
            list = "employee";

            tlpList.Controls.Clear();
            ShowEmployeeList();
            ShowDefault();
        }

        //display EmployeeProfile in tlpList column 2
        public static void ShowEmployeeProfile()
        {
            if (tlp.GetControlFromPosition(1, 0) != null)
            {
                tlp.GetControlFromPosition(1, 0).Dispose();
            }
            EmployeeProfile employeeProfile = new EmployeeProfile() { TopLevel = false, TopMost = true };
            employeeProfile.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(employeeProfile, 1, 0);
            employeeProfile.Show();
        }

        //display EditProfile in panelForm
        public static void DisplayEditProfile()
        {
            EditProfile editProfile = new EditProfile() { TopLevel = false, TopMost = true };
            formPanel.Controls.Clear();
            formPanel.Controls.Add(menuPanel);
            formPanel.Controls.Add(tlp);
            tlp.Visible = false;
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = false;
            editProfile.FormBorderStyle = FormBorderStyle.None;
            formPanel.Controls.Add(editProfile);
            editProfile.Show();
            title.Text = "EDIT EMPLOYEE PROFILE";
            icon.IconChar = IconChar.UserEdit;
        }
        
        //display ClaimList in tlpList column 1
        public static void ShowClaimList()
        {
            if (tlp.GetControlFromPosition(0, 0) != null)
            {
                tlp.GetControlFromPosition(0, 0).Dispose();
            }
            ClaimList claimList = new ClaimList() { TopLevel = false, TopMost = true };
            claimList.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(claimList, 0, 0);
            claimList.Show();
            title.Text = "CLAIM LIST";
            icon.IconChar = IconChar.ListUl;
        }

        private void btnClaimList_Click(object sender, EventArgs e)
        {
            currentPage = "CLAIM LIST";
            BtnSelect(sender);
            CloseMenu();
            tlpList.Visible = true;
            list = "claim";
            initialForm = "dash";
            ClaimList.ToMatch = false;

            tlpList.Controls.Clear();
            ShowClaimList();
            ShowDefault();
            initialForm = "DB";
        }

        //display ClaimProfile in tlpList column 2
        public static void ShowClaimProfile()
        {
            if (tlp.GetControlFromPosition(1, 0) != null)
            {
                tlp.GetControlFromPosition(1, 0).Dispose();
            }
            Claim claimProfile = new Claim() { TopLevel = false, TopMost = true };
            claimProfile.FormBorderStyle = FormBorderStyle.None;
            tlp.Controls.Add(claimProfile, 1, 0);
            claimProfile.Show();
        }

        private void btnListItem_Click(object sender, EventArgs e)
        {
            currentPage = "LIST A LOST ITEM";
            BtnSelect(sender);
            CloseMenu();

            ListItem listItem = new ListItem() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(tlpList);
            tlpList.Visible = false;
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = false;
            listItem.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(listItem);
            listItem.Show();
        }

        public static string initialForm;

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            currentPage = "EDIT PROFILE";
            BtnSelect(sender);
            leftBorder.Visible = false;
            CloseMenu();
            initialForm = "Dashboard";

            EditProfile editProfile = new EditProfile() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(tlpList);
            tlpList.Visible = false;
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = false;
            editProfile.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(editProfile);
            editProfile.Show();
            initialForm = "DB";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            currentPage = "CHANGE PASSWORD";
            BtnSelect(sender);
            leftBorder.Visible = false;
            CloseMenu();

            ChangePassword changePassword = new ChangePassword() { TopLevel = false, TopMost = true };
            panelForm.Controls.Clear();
            panelForm.Controls.Add(panelMenu);
            panelForm.Controls.Add(tlpList);
            tlpList.Visible = false;
            formPanel.Controls.Add(frontPanel);
            frontPanel.Visible = false;
            changePassword.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Logout?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void panelForm_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Location = new Point((btnMenu.Location.X - 252), 0);
                panelMenu.Visible = true;
                btnMenu.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                CloseMenu();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}