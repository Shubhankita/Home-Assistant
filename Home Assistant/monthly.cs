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
    public partial class monthly : Form
    {
        public monthly()
        {
            InitializeComponent();
        }
        float sum;

        private void button1_Click(object sender, EventArgs e)
        {
            sum = sum + float.Parse(textBox2.Text);
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string connectionString, sql;
            listBox1.Items.Add(textBox1.Text + "                    " + textBox2.Text + "                    " + textBox3.Text + "                    " + textBox4.Text);
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "insert into monthly values('"+Login.fname+"','" + textBox1.Text + "','" + textBox3.Text.ToLower() + "','" + textBox2.Text + "','"+textBox4.Text+"')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total sum in the list is " + sum);
        }

        private void monthly_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float month=0;
            SqlConnection cnn;
            SqlCommand command;
            string connectionString, sql;
            SqlDataReader dataReader;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "select price from monthly where name='" + Login.fname + "' and month='" + textBox3.Text + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string num = dataReader.GetValue(0).ToString();
                month += float.Parse(num);
            }
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Expenditure for the month " + textBox3.Text + " is " + month);
        }
    }
}
