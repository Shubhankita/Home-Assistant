using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home_Assistant
{
    public partial class charts : Form
    {
        public charts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select commodity,price from monthly where month='" + textBox1.Text + "' and year='" + textBox2.Text + "'", cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["finance"].XValueMember = "commodity";
            chart1.Series["finance"].YValueMembers = "price";
            chart1.Titles.Add(textBox1.Text + " month, " + textBox2.Text);
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
