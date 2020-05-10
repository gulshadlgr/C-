using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temelkullanimlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vatan!Millet!Sakarya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "TÜRKİYE";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "40********0";
            label7.Text = "sevimdulger58@gmail.com";
                label8.Text = "********";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "YAZILIM";
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
        }
    }
}
