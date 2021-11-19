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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string fname="";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand command;
            string connectionString, sql;
            SqlDataReader dataReader;
            connectionString = @"Data Source=LAPTOP-CDLSE9E5\SQLEXPRESS;Initial Catalog=home_ass;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "select * from family where name='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               if(dataReader.GetValue(1).ToString() == textBox2.Text)
                {
                    fname = textBox1.Text;
                    main form = new main();
                    form.Show();
                    this.Close();
                }
            }
            command.Dispose();
            cnn.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
