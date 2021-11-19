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
    public partial class education : Form
    {
        public education()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tasks form = new Tasks();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotePad form = new NotePad();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
