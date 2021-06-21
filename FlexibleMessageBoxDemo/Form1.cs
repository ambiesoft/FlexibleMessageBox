using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace FlexibleMessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static String GetBatchOperationResults()
        {
            var builder = new StringBuilder("Batch operation report:\n\n");
            var random = new Random();
            var result = 0;

            for (int i = 0; i < 200; i++)
            {
                result = random.Next(1000);

                if (result < 950)
                {
                    builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                }
                else
                {
                    builder.AppendFormat(" - Task {0}: Operation failed! A very very very very very very very very very very very very serious error has occured during this sub-operation. The errorcode is: {1}).\n", i, result);
                }
            }

            return builder.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string aaa = GetBatchOperationResults();
            FlexibleMessageBox.Show(aaa,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = FlexibleMessageBox.Show("Some text with a link: www.google.com\nA second line that contains a very very very very very very very very very very very very very very long text.",
                                            "I am a FlexibleMessageBox",
                                            MessageBoxButtons.AbortRetryIgnore,
                                            MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button2);
            FlexibleMessageBox.Show("You have clicked: " + result.ToString(), "DialogResult");
        }
    }
}
