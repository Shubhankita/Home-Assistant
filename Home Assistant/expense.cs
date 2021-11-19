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
    public partial class expense : Form
    {
        public expense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float budget = float.Parse(textBox1.Text);
            float expenditure = float.Parse(textBox2.Text);
            if(expenditure > budget)
            {
                textBox3.Text = "You have spent more than your allocated budget and should think of cutting costs.";
            }
            else if(expenditure == budget)
            {
                textBox3.Text = "You are at your limit.";
            }
            else
            {
                float diff = budget - expenditure;
                textBox3.Text = diff.ToString() + " is your current balance left. Spend Wisley.";
            }
        }
    }
}
