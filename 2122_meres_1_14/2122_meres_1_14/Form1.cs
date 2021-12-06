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

namespace _2122_meres_1_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string connectionString =
                @"Server=(localdb)\MSSQLLocalDB;" +
                "Database=palyazatok;";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var sqlCommand = new SqlCommand("SELECT palyazat.id, sum(palyazat.keretossz + palyazat.szamossz)", connection);
            var sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                
            }

            sqlDataReader.Close();
            InitializeComponent();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
