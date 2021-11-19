using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Home_Assistant
{
    public partial class ActivityF : Form
    {
        public ActivityF()
        {
            InitializeComponent();
        }
        public System.Timers.Timer t;
        int h, m, s;
        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void ActivityF_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s = s + 1;
                if (s == 60)
                {
                    s = 0;
                    m = m + 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h = h + 1;
                }
                if (h == 1)
                {
                    s = s + 0;
                    t.Stop();
                    MessageBox.Show("Time to do some activity!!");
                    this.Close();
                }
                textBox1.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
