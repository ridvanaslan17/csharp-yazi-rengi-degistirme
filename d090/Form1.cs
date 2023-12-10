using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d090
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.ForeColor = System.Drawing.Color.Black;
            else if (radioButton2.Checked)
                label1.ForeColor = System.Drawing.Color.Red;
            else if (radioButton3.Checked)
                label1.ForeColor = System.Drawing.Color.Blue;
            else if (radioButton4.Checked)
                label1.ForeColor = System.Drawing.ColorTranslator.FromHtml(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            label1.ForeColor = System.Drawing.Color.Black;
            textBox1.Text = "#";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1 .Enabled = radioButton4.Checked;
        }
    }
}
