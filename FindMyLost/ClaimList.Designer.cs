namespace FindMyLost
{
    partial class ClaimList
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
            this.lvClaimList = new MaterialSkin.Controls.MaterialListView();
            this.claimID = new System.Windows.Forms.ColumnHeader();
            this.ItemCategory = new System.Windows.Forms.ColumnHeader();
            this.ItemColour = new System.Windows.Forms.ColumnHeader();
            this.ItemBrand = new System.Windows.Forms.ColumnHeader();
            this.LastSeen = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvClaimList
            // 
            this.lvClaimList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lvClaimList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvClaimList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.claimID,
            this.ItemCategory,
            this.ItemColour,
            this.ItemBrand,
            this.LastSeen});
            this.lvClaimList.Depth = 0;
            this.lvClaimList.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvClaimList.FullRowSelect = true;
            this.lvClaimList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClaimList.HideSelection = false;
            this.lvClaimList.Location = new System.Drawing.Point(28, 38);
            this.lvClaimList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvClaimList.MouseState = MaterialSkin.MouseState.OUT;
            this.lvClaimList.Name = "lvClaimList";
            this.lvClaimList.OwnerDraw = true;
            this.lvClaimList.Size = new System.Drawing.Size(750, 855);
            this.lvClaimList.TabIndex = 0;
            this.lvClaimList.UseCompatibleStateImageBehavior = false;
            this.lvClaimList.View = System.Windows.Forms.View.Details;
            this.lvClaimList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvClaimList_MouseClick);
            // 
            // claimID
            // 
            this.claimID.Text = "Claim ID";
            this.claimID.Width = 120;
            // 
            // ItemCategory
            // 
            this.ItemCategory.Text = "Category";
            this.ItemCategory.Width = 150;
            // 
            // ItemColour
            // 
            this.ItemColour.Text = "Colour";
            this.ItemColour.Width = 120;
            // 
            // ItemBrand
            // 
            this.ItemBrand.Text = "Brand";
            this.ItemBrand.Width = 150;
            // 
            // LastSeen
            // 
            this.LastSeen.Text = "Last Seen Location";
            this.LastSeen.Width = 210;
            // 
            // ClaimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 950);
            this.Controls.Add(this.lvClaimList);
            this.Name = "ClaimList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLAIM LIST";
            this.Load += new System.EventHandler(this.ClaimList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvClaimList;
        private System.Windows.Forms.ColumnHeader claimID;
        private System.Windows.Forms.ColumnHeader ItemCategory;
        private System.Windows.Forms.ColumnHeader ItemColour;
        private System.Windows.Forms.ColumnHeader ItemBrand;
        private System.Windows.Forms.ColumnHeader LastSeen;
    }
}