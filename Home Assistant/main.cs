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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Linen;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            Home form = new Home();
            form.Show();
            form.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testForm form = new testForm();
            form.Show();
            form.MdiParent = this;
        }

        private void homeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.MdiParent = this;
            form.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotePad notePad = new NotePad();
            notePad.MdiParent = this;
            notePad.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator form = new calculator();
            form.MdiParent = this;
            form.Show();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calender form = new Calender();
            form.MdiParent = this;
            form.Show();
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser form = new Browser();
            form.MdiParent = this;
            form.Show();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            News form = new News();
            form.MdiParent = this;
            form.Show();
        }

        private void foodOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodDel form = new foodDel();
            form.MdiParent = this;
            form.Show();
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video form = new Video();
            form.MdiParent = this;
            form.Show();
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gmail form = new Gmail();
            form.MdiParent = this;
            form.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            general form = new general();
            form.MdiParent = this;
            form.Show();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance form = new Finance();
            form.MdiParent = this;
            form.Show();
        }

        private void healthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Health form = new Health();
            form.MdiParent = this;
            form.Show();
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            education form = new education();
            form.MdiParent = this;
            form.Show();
        }

        private void fitnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fitness form = new Fitness();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WaterTracker form = new WaterTracker();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ActivityF form = new ActivityF();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HandWash form = new HandWash();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            calculator form = new calculator();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            NotePad form = new NotePad();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Browser form = new Browser();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
