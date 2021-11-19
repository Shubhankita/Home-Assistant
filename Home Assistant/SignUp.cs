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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string connectionString,sql;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            if(textBox2.Text == textBox3.Text)
            {
                sql = "Insert into family values('" + textBox1.Text + "','" + textBox2.Text + "')";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Both the passwords do not match.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                cnn.Close();
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
