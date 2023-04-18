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
                    // builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                    builder.AppendFormat(Properties.Resources.TASK_N_OPERATION_COMPLETED_SUCESSFULLY, i);
                    builder.AppendLine();
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
            FlexibleMessageBox.FONT = Font;
            FlexibleMessageBox.Show(aaa,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.FONT = Font;
            var result = FlexibleMessageBox.Show(
                                            //"Some text with a link: www.google.com\nA second line that contains a very very very very very very very very very very very very very very long text.",
                                            Properties.Resources.SOME_TEXT_WITH_A_LINK,
                                            "I am a FlexibleMessageBox",
                                            MessageBoxButtons.AbortRetryIgnore,
                                            MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button2);
            FlexibleMessageBox.Show("You have clicked: " + result.ToString(), "DialogResult");
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show(this,
                "MyApp v1.0.1\r\n\r\nhttp://example.com",
                "MyApp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnOneLine_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show(this,
                "MyApp v1.0.1",
                "MyApp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonLongLine_Click(object sender, EventArgs e)
        {
            double MAX_WIDTH_FACTOR_start = FlexibleMessageBox.MAX_WIDTH_FACTOR;
            FlexibleMessageBox.MAX_WIDTH_FACTOR = 0.3f;
            FlexibleMessageBox.Show(this,
                "MyApp v1.0.1 this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - this is a long line message - ",
                "MyApp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FlexibleMessageBox.MAX_WIDTH_FACTOR = MAX_WIDTH_FACTOR_start;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
