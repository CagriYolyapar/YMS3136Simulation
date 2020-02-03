using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAGitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnCagri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Cagri");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1kg Elma 3TL");
            comboBox1.Items.Add("1kg Artmut 5TL");
        }
    }
}
