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
    public partial class Fitness : Form
    {
        public Fitness()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WaterTracker form = new WaterTracker();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weightTracker form = new weightTracker();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityF form = new ActivityF();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
