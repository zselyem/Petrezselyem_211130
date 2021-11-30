using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//16:30

namespace Petrezselyem_211130
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; }

        public Form1()
        {
            // (SQL Server 13.0.4001 - VEREBELY/diak)
            ConnectionString = @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = palyazatok;";


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //  Adatbetolt();
        }

        private void Adatbetolt()
        {
            dgv.Rows.Clear();
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand(
                "SELECT szamla.id, palyazat.tervezetA, szamla.ertek, palyazat.tervezetB" +
                "FROM szamla, palyazat;"
            );
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(
                        reader.GetInt32(0),
                        reader["keretosszeg"],
                        reader["szamlak_szama"],
                        reader["szamlak_osszege"]
                    );
            }
            connection.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUjPalyazat_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }
    }
}
