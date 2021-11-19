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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string connectionString, sql;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql="insert into tasksdb values('"+textBox2.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+Login.fname+"')";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            MessageBox.Show("Task added.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            string connectionString, sql;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "select * from tasksdb where name='" + Login.fname + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                listBox1.Items.Add(dataReader.GetValue(0) + "                " + dataReader.GetValue(1) + "                " + dataReader.GetValue(2));   
            }
            command.Dispose();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string connectionString, sql;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "delete from tasksdb where id='" + textBox2.Text + "'";
            command = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }
    }
}
