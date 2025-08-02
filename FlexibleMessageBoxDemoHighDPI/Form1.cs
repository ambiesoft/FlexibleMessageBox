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

        private void button2_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show(this,
                @"The version of Craving Explorer2 stored on 'C:\local\Craving Explorer 2\Application\CravingExplorer.exe' is not desired one. Current installed version v128.0.6613.170 is not equal to v128.0.6613.186
'C:\Users\Kiaen\Documents\SceneExplorer\default.scexd' is old
----------------------------
Download folder path of 'C:\Users\waSudv\AppData\Local\Google\Chrome\Google' is set to 'C:\USERS\WASUDV\DESKTOP' from ''
'C:\Users\waSudv\Documents\SceneExplorer\default.scexd' is old
---------------------------",
                "This might not be shown properly",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show(this,
                           @"'C:\Linkout\checkinstall\FlexibleMessageBox.dll' v1.4.7",
                           "This might not be shown properly",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }
    }
}
