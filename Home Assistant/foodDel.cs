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
    public partial class foodDel : Form
    {
        public foodDel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void foodDel_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.swiggy.com/?utm_source=Google-Sok&utm_medium=CPC&utm_campaign=google_search_sok_food_na_narm_order_web_m_web_clubbedcities_neev_brand_newuser_scale_down_brand_em&gclid=CjwKCAjwtfqKBhBoEiwAZuesiGIofAMfXb7LnFzaQc73b6K_FZl3rLLTtCkVoSWpzzBeNXbiGLdIkRoCrisQAvD_BwE");
            textBox1.Text = "https://www.swiggy.com/";
        }
    }
}
