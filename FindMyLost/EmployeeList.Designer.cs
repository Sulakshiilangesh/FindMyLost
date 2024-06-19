namespace FindMyLost
{
    partial class EmployeeList
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
            this.lvEmployeeList = new MaterialSkin.Controls.MaterialListView();
            this.employeeID = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.MobileNum = new System.Windows.Forms.ColumnHeader();
            this.Position = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvEmployeeList
            // 
            this.lvEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeID,
            this.FirstName,
            this.LastName,
            this.MobileNum,
            this.Position});
            this.lvEmployeeList.Depth = 0;
            this.lvEmployeeList.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvEmployeeList.FullRowSelect = true;
            this.lvEmployeeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployeeList.HideSelection = false;
            this.lvEmployeeList.Location = new System.Drawing.Point(24, 45);
            this.lvEmployeeList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvEmployeeList.MouseState = MaterialSkin.MouseState.OUT;
            this.lvEmployeeList.Name = "lvEmployeeList";
            this.lvEmployeeList.OwnerDraw = true;
            this.lvEmployeeList.Size = new System.Drawing.Size(750, 857);
            this.lvEmployeeList.TabIndex = 0;
            this.lvEmployeeList.UseCompatibleStateImageBehavior = false;
            this.lvEmployeeList.View = System.Windows.Forms.View.Details;
            this.lvEmployeeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvEmployeeList_MouseClick);
            // 
            // employeeID
            // 
            this.employeeID.Text = "Employee ID";
            this.employeeID.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 160;
            // 
            // MobileNum
            // 
            this.MobileNum.Text = "Mobile Number";
            this.MobileNum.Width = 170;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 120;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 950);
            this.Controls.Add(this.lvEmployeeList);
            this.Name = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvEmployeeList;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader MobileNum;
        private System.Windows.Forms.ColumnHeader Position;
    }
}