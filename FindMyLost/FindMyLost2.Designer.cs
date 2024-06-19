namespace FindMyLost
{
    partial class FindMyLost2
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
            this.lblFindMyLost = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFindMyLost
            // 
            this.lblFindMyLost.AutoSize = true;
            this.lblFindMyLost.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFindMyLost.ForeColor = System.Drawing.Color.White;
            this.lblFindMyLost.Location = new System.Drawing.Point(308, 557);
            this.lblFindMyLost.Name = "lblFindMyLost";
            this.lblFindMyLost.Size = new System.Drawing.Size(222, 49);
            this.lblFindMyLost.TabIndex = 205;
            this.lblFindMyLost.Text = "FindMyLost";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(253, 624);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(277, 25);
            this.lblDetails.TabIndex = 204;
            this.lblDetails.Text = "Click on a row to view Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(50, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 790);
            this.panel1.TabIndex = 203;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindMyLost.Properties.Resources.logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(235, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FindMyLost2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(802, 903);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFindMyLost);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.panel1);
            this.Name = "FindMyLost2";
            this.Text = "FindMyLost2";
            this.Load += new System.EventHandler(this.FindMyLost2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFindMyLost;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}