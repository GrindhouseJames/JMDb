using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JMDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestButton(object sender, EventArgs e) //This is for connecting to the SQL server
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-IEGK5H0;Initial Catalog=JMDB;User ID=james;Password=1234";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        }

        private void TitleTextbox(object sender, EventArgs e)
        {

        }

        private void GenreTextbox(object sender, EventArgs e)
        {

        }

        private void YearTextbox(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e) //This is the submit button
        {
            MessageBox.Show("Film: " + textBox1.Text + "\n" + "Genre: " + textBox2.Text + "\n" + "Year: " + textBox3.Text);
        }

    }
}