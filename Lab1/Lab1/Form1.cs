using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearOnClick(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAge.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void submitOnClick(object sender, EventArgs e)
        {
            String data=" ";
            data += txtName.Text;
            data += txtAge.Text;
            data += txtAddress.Text;
            data += txtPhone.Text;
            MessageBox.Show(data);
        }
    }
}
