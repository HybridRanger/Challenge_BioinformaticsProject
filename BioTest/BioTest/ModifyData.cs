using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BioTest
{
    public partial class ModifyData : Form
    {
        private string connectionString = "server=localhost;user=root;database=mice_cancer;";
        public ModifyData()
        {
            InitializeComponent();
        }

        private void ModifyData_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "SHOW TABLES";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListView.Items.Add(Convert.ToString(rdr[0]), 3);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /*
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "CREATE TABLE IF NOT EXISTS test (" +
                    "Id INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                    "ProbeName VARCHAR(30) NOT NULL DEFAULT ''," +
                    "LogRatio DECIMAL(6, 5) NOT NULL DEFAULT 0.00000," +
                    "PRIMARY KEY (ID));";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MessageBox.Show(Convert.ToString(rdr[0]));
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }
        private void Return_To_Menu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void NewData_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
            MessageBox.Show(Convert.ToString(result));
        }

        private void Modify_Data_Click(object sender, EventArgs e)
        {

        }

        private void TableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
