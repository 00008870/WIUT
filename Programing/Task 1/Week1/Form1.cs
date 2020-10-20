using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Week1 : Form
    {
        public Week1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + tbxName.Text + ". How are you?");

        }

        private void Week1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to My First Application");
        }

        private void Week1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye, Cruel World");
            e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close();
            Application.Exit();
        }
    }
}
