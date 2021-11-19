using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assistant
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + Login.fname;
            label3.Text = DateTime.Now.ToString("D");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.MdiParent.Close();
            Login form = new Login();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            general form = new general();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finance form = new Finance();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Health form = new Health();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            education form = new education();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fitness form = new Fitness();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
