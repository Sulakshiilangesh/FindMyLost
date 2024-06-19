namespace FindMyLost
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panelEmployeeDetails = new System.Windows.Forms.Panel();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnChangePassword = new FontAwesome.Sharp.IconButton();
            this.btnEditProfile = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblFindMyLost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.panelTaskBar = new System.Windows.Forms.Panel();
            this.iconCurrentPage = new FontAwesome.Sharp.IconPictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnListItem = new FontAwesome.Sharp.IconButton();
            this.btnClaimList = new FontAwesome.Sharp.IconButton();
            this.btnEmployeeList = new FontAwesome.Sharp.IconButton();
            this.btnItemList = new FontAwesome.Sharp.IconButton();
            this.btnClaimItem = new FontAwesome.Sharp.IconButton();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblFML = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panelEmployeeDetails.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(124, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "[Email]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(124, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "[Name]";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(20, 21);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(100, 110);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // panelEmployeeDetails
            // 
            this.panelEmployeeDetails.Controls.Add(this.lblEmail);
            this.panelEmployeeDetails.Controls.Add(this.lblName);
            this.panelEmployeeDetails.Controls.Add(this.lblEmployeeID);
            this.panelEmployeeDetails.Controls.Add(this.pbUser);
            this.panelEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeDetails.Name = "panelEmployeeDetails";
            this.panelEmployeeDetails.Size = new System.Drawing.Size(333, 152);
            this.panelEmployeeDetails.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeID.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeID.Location = new System.Drawing.Point(124, 63);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(101, 18);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "[Employee ID]";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 302);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(333, 75);
            this.btnLogout.TabIndex = 161;
            this.btnLogout.Text = "     Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnChangePassword.IconColor = System.Drawing.Color.White;
            this.btnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePassword.IconSize = 32;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 227);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(333, 75);
            this.btnChangePassword.TabIndex = 160;
            this.btnChangePassword.Text = "     Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditProfile.IconColor = System.Drawing.Color.White;
            this.btnEditProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProfile.IconSize = 32;
            this.btnEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfile.Location = new System.Drawing.Point(0, 152);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditProfile.Size = new System.Drawing.Size(333, 75);
            this.btnEditProfile.TabIndex = 159;
            this.btnEditProfile.Text = "     Edit Profile";
            this.btnEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnChangePassword);
            this.panelMenu.Controls.Add(this.btnEditProfile);
            this.panelMenu.Controls.Add(this.panelEmployeeDetails);
            this.panelMenu.Location = new System.Drawing.Point(1273, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(333, 389);
            this.panelMenu.TabIndex = 11;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelForm.Controls.Add(this.panelMenu);
            this.panelForm.Controls.Add(this.tlpList);
            this.panelForm.Controls.Add(this.panelFront);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(293, 95);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1607, 903);
            this.panelForm.TabIndex = 7;
            this.panelForm.Click += new System.EventHandler(this.panelForm_Click);
            // 
            // tlpList
            // 
            this.tlpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tlpList.ColumnCount = 2;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlpList.Location = new System.Drawing.Point(0, 0);
            this.tlpList.Name = "tlpList";
            this.tlpList.RowCount = 1;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpList.Size = new System.Drawing.Size(1607, 903);
            this.tlpList.TabIndex = 12;
            // 
            // panelFront
            // 
            this.panelFront.Controls.Add(this.lblTagline);
            this.panelFront.Controls.Add(this.lblFindMyLost);
            this.panelFront.Controls.Add(this.pictureBox1);
            this.panelFront.Location = new System.Drawing.Point(504, 91);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(551, 622);
            this.panelFront.TabIndex = 14;
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTagline.ForeColor = System.Drawing.Color.White;
            this.lblTagline.Location = new System.Drawing.Point(148, 552);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(243, 20);
            this.lblTagline.TabIndex = 207;
            this.lblTagline.Text = "LOST IT? LIST IT! FIND IT!";
            // 
            // lblFindMyLost
            // 
            this.lblFindMyLost.AutoSize = true;
            this.lblFindMyLost.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFindMyLost.ForeColor = System.Drawing.Color.White;
            this.lblFindMyLost.Location = new System.Drawing.Point(153, 483);
            this.lblFindMyLost.Name = "lblFindMyLost";
            this.lblFindMyLost.Size = new System.Drawing.Size(239, 52);
            this.lblFindMyLost.TabIndex = 206;
            this.lblFindMyLost.Text = "FindMyLost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindMyLost.Properties.Resources.logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(43, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(293, 88);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1607, 7);
            this.panelShadow.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 45;
            this.btnMenu.Location = new System.Drawing.Point(1525, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(82, 88);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Exo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPage.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPage.Location = new System.Drawing.Point(100, 36);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(69, 24);
            this.lblCurrentPage.TabIndex = 2;
            this.lblCurrentPage.Text = "HOME";
            // 
            // panelTaskBar
            // 
            this.panelTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelTaskBar.Controls.Add(this.btnMenu);
            this.panelTaskBar.Controls.Add(this.lblCurrentPage);
            this.panelTaskBar.Controls.Add(this.iconCurrentPage);
            this.panelTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskBar.Location = new System.Drawing.Point(293, 0);
            this.panelTaskBar.Name = "panelTaskBar";
            this.panelTaskBar.Size = new System.Drawing.Size(1607, 88);
            this.panelTaskBar.TabIndex = 5;
            this.panelTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseDown);
            // 
            // iconCurrentPage
            // 
            this.iconCurrentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.iconCurrentPage.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentPage.IconColor = System.Drawing.Color.White;
            this.iconCurrentPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentPage.IconSize = 40;
            this.iconCurrentPage.Location = new System.Drawing.Point(39, 27);
            this.iconCurrentPage.Name = "iconCurrentPage";
            this.iconCurrentPage.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentPage.TabIndex = 2;
            this.iconCurrentPage.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::FindMyLost.Properties.Resources.logo_white;
            this.pbLogo.Location = new System.Drawing.Point(12, 35);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(115, 117);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnListItem
            // 
            this.btnListItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListItem.FlatAppearance.BorderSize = 0;
            this.btnListItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListItem.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btnListItem.IconColor = System.Drawing.Color.White;
            this.btnListItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListItem.IconSize = 32;
            this.btnListItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListItem.Location = new System.Drawing.Point(0, 535);
            this.btnListItem.Name = "btnListItem";
            this.btnListItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnListItem.Size = new System.Drawing.Size(293, 75);
            this.btnListItem.TabIndex = 6;
            this.btnListItem.Text = "      List an item";
            this.btnListItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListItem.UseVisualStyleBackColor = true;
            this.btnListItem.Click += new System.EventHandler(this.btnListItem_Click);
            // 
            // btnClaimList
            // 
            this.btnClaimList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClaimList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClaimList.FlatAppearance.BorderSize = 0;
            this.btnClaimList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaimList.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClaimList.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnClaimList.IconColor = System.Drawing.Color.White;
            this.btnClaimList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClaimList.IconSize = 32;
            this.btnClaimList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimList.Location = new System.Drawing.Point(0, 460);
            this.btnClaimList.Name = "btnClaimList";
            this.btnClaimList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClaimList.Size = new System.Drawing.Size(293, 75);
            this.btnClaimList.TabIndex = 5;
            this.btnClaimList.Text = "      Claim List";
            this.btnClaimList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaimList.UseVisualStyleBackColor = true;
            this.btnClaimList.Click += new System.EventHandler(this.btnClaimList_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeList.FlatAppearance.BorderSize = 0;
            this.btnEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeList.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeList.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmployeeList.IconColor = System.Drawing.Color.White;
            this.btnEmployeeList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployeeList.IconSize = 32;
            this.btnEmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeList.Location = new System.Drawing.Point(0, 385);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmployeeList.Size = new System.Drawing.Size(293, 75);
            this.btnEmployeeList.TabIndex = 4;
            this.btnEmployeeList.Text = "     Employee List";
            this.btnEmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeList.UseVisualStyleBackColor = true;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // btnItemList
            // 
            this.btnItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemList.FlatAppearance.BorderSize = 0;
            this.btnItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemList.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItemList.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnItemList.IconColor = System.Drawing.Color.White;
            this.btnItemList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItemList.IconSize = 32;
            this.btnItemList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemList.Location = new System.Drawing.Point(0, 310);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnItemList.Size = new System.Drawing.Size(293, 75);
            this.btnItemList.TabIndex = 3;
            this.btnItemList.Text = "     Item List";
            this.btnItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemList.UseVisualStyleBackColor = true;
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // btnClaimItem
            // 
            this.btnClaimItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClaimItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClaimItem.FlatAppearance.BorderSize = 0;
            this.btnClaimItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaimItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClaimItem.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnClaimItem.IconColor = System.Drawing.Color.White;
            this.btnClaimItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClaimItem.IconSize = 32;
            this.btnClaimItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimItem.Location = new System.Drawing.Point(0, 235);
            this.btnClaimItem.Name = "btnClaimItem";
            this.btnClaimItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClaimItem.Size = new System.Drawing.Size(293, 75);
            this.btnClaimItem.TabIndex = 2;
            this.btnClaimItem.Text = "     Claim an item";
            this.btnClaimItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaimItem.UseVisualStyleBackColor = true;
            this.btnClaimItem.Click += new System.EventHandler(this.btnClaimItem_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnRegister.IconColor = System.Drawing.Color.White;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.IconSize = 32;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 160);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegister.Size = new System.Drawing.Size(293, 75);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "     Register Employees";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lbl);
            this.panelLogo.Controls.Add(this.lblFML);
            this.panelLogo.Controls.Add(this.lblTag);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 160);
            this.panelLogo.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(119, 103);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(155, 12);
            this.lbl.TabIndex = 209;
            this.lbl.Text = "LOST IT? LIST IT! FIND IT!";
            // 
            // lblFML
            // 
            this.lblFML.AutoSize = true;
            this.lblFML.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFML.ForeColor = System.Drawing.Color.White;
            this.lblFML.Location = new System.Drawing.Point(125, 72);
            this.lblFML.Name = "lblFML";
            this.lblFML.Size = new System.Drawing.Size(139, 29);
            this.lblFML.TabIndex = 206;
            this.lblFML.Text = "FindMyLost";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTag.ForeColor = System.Drawing.Color.White;
            this.lblTag.Location = new System.Drawing.Point(660, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(187, 16);
            this.lblTag.TabIndex = 208;
            this.lblTag.Text = "LOST IT? LIST IT! FIND IT!";
            this.lblTag.Visible = false;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SideMenu.Controls.Add(this.btnListItem);
            this.SideMenu.Controls.Add(this.btnClaimList);
            this.SideMenu.Controls.Add(this.btnEmployeeList);
            this.SideMenu.Controls.Add(this.btnItemList);
            this.SideMenu.Controls.Add(this.btnClaimItem);
            this.SideMenu.Controls.Add(this.btnRegister);
            this.SideMenu.Controls.Add(this.panelLogo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SideMenu.ForeColor = System.Drawing.Color.White;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(293, 998);
            this.SideMenu.TabIndex = 4;
            this.SideMenu.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1900, 998);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTaskBar);
            this.Controls.Add(this.SideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panelEmployeeDetails.ResumeLayout(false);
            this.panelEmployeeDetails.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTaskBar.ResumeLayout(false);
            this.panelTaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panelEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeID;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnChangePassword;
        private FontAwesome.Sharp.IconButton btnEditProfile;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Panel panelTaskBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentPage;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnListItem;
        private FontAwesome.Sharp.IconButton btnClaimList;
        private FontAwesome.Sharp.IconButton btnEmployeeList;
        private FontAwesome.Sharp.IconButton btnItemList;
        private FontAwesome.Sharp.IconButton btnClaimItem;
        private FontAwesome.Sharp.IconButton btnRegister;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel SideMenu;
        public System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblFindMyLost;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblFML;
        private System.Windows.Forms.Label lbl;
    }
}