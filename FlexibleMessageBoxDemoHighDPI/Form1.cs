using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ambiesoft;
using JR.Utils.GUI.Forms;

namespace FlexibleMessageBoxDemoHighDPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aaa = Properties.Resources.STR_RANDOM;
            FlexibleMessageBox.FONT = Font;
            FlexibleMessageBox.Show(aaa,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
