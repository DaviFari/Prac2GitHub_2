using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.btn2.BackColor = System.Drawing.Color.Aqua;
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.BackColor = System.Drawing.Color.Maroon;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.btn_1.BackColor = System.Drawing.Color.Aqua;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.BackColor = System.Drawing.Color.Maroon;
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
        }
    }
}
