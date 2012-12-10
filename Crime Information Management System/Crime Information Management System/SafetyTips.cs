using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SafetyTips : Form
    {
        public SafetyTips()
        {
            InitializeComponent();
           // this.Visible = true;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
