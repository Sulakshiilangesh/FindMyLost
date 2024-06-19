using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyLost
{
    public partial class FindMyLost2 : Form
    {
        public FindMyLost2()
        {
            InitializeComponent();
        }

        private void FindMyLost2_Load(object sender, EventArgs e)
        {
            string list = Dashboard.list;
            if (list == "item")
            {
                lblDetails.Text = "Click on a row to view Item Profile";
            }
            else if (list == "employee")
            {
                lblDetails.Text = "Click on a row to view Employee Profile";
            }
            else if (list == "claim")
            {
                lblDetails.Text = "Click on a row to view Claim Profile";
            }
        }
    }
}
