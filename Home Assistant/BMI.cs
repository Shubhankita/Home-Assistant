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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(textBox1.Text);
            float height = float.Parse(textBox2.Text);
            float BMI = weight / (height * height);
            if (BMI < 18.5)
            {
                MessageBox.Show("Underweight");
            }
            else if(BMI>18.5 && BMI < 24.9)
            {
                MessageBox.Show("Normal Weight");
            }
            else if(BMI>25.0 && BMI < 29.9)
            {
                MessageBox.Show("Overweight");
            }
            else
            {
                MessageBox.Show("Obese");
            }
        }
    }
}
