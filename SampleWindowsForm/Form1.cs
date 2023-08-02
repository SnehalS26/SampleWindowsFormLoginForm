using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textUsername.Text== "admin" && textPassword.Text== "admin123")
            {
                MessageBox.Show("Login");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
        }
    }
}
