using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Form1.rad[0] = (float)(numericUpDown1.Value) / 10;
                Form1.rad[1] = (float)(numericUpDown2.Value) / 10;
                Form1.rad[2] = (float)(numericUpDown3.Value) / 10;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToDecimal(Form1.rad[0]) * 10;
            numericUpDown2.Value = Convert.ToDecimal(Form1.rad[1]) * 10;
            numericUpDown3.Value = Convert.ToDecimal(Form1.rad[2]) * 10;
        }
    }
}
