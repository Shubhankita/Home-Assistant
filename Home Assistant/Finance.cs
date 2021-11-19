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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expense form = new expense();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthly form = new monthly();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            charts form = new charts();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
