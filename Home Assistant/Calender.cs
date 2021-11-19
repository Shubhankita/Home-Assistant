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
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calender_Load(object sender, EventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            textBox1.Text = start.ToString();


            textBox2.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
