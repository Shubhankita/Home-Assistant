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
    public partial class Covid : Form
    {
        public Covid()
        {
            InitializeComponent();
        }

        private void Covid_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=covid+19+india&rlz=1C1CHBD_enIN960IN960&oq=covid&aqs=chrome.1.69i57j35i39l2j0i433i457i512j0i402l2j0i67i131i433j0i67j0i67i433j0i433i512.2641j0j15&sourceid=chrome&ie=UTF-8");
            textBox1.Text = "COVID India";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
