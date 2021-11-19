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
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser form = new Browser();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foodDel form = new foodDel();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Video form = new Video();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            News form = new News();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gmail form = new Gmail();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator form = new calculator();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NotePad form = new NotePad();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void general_Load(object sender, EventArgs e)
        {

        }
    }
}
