using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Home_Assistant
{
    public partial class HandWash : Form
    {
        public HandWash()
        {
            InitializeComponent();
        }
        public System.Timers.Timer timer;
        int s, m, h;
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void HandWash_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s = s + 1;
                if(s == 60)
                {
                    s = 0;
                    m = m + 1;
                }
                if(m==60)
                {
                    m = 0;
                    h = h + 1;
                }
                if(h == 1)
                {
                    s = s + 0;
                    timer.Stop();
                    MessageBox.Show("Time to wash your hands.");
                    this.Close();
                }
                textBox1.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
