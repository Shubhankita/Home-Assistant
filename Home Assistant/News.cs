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
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();
        }

        private void News_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.indiatoday.in/");
            textBox1.Text = "https://www.indiatoday.in/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
