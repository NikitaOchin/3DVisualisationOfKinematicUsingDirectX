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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {
                    Form1.omega = Convert.ToDouble(maskedTextBox1.Text.Substring(0, 4))*10;
                }
                catch (FormatException) {e.Cancel = true;}
            }
        }
    }
}
