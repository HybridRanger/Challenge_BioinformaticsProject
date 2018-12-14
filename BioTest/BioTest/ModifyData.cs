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
using System.IO;

namespace BioTest
{
    public partial class ModifyData : Form
    {
        private string connectionString = "server=localhost;user=root;database=challenge;";
        public ModifyData()
        {
            InitializeComponent();
        }

        private void ModifyData_Load(object sender, EventArgs e)
        {

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
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    CreateTable(text, openFileDialog1.SafeFileName.Split('.')[0].Replace(" ", string.Empty));
                }
                catch (IOException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
               
            }
            
        }

        private void Modify_Data_Click(object sender, EventArgs e)
        {

        }

        private void TableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTable(string text, string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "CREATE TABLE IF NOT EXISTS " + name + " (" +
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

            string[] lines = text.Split('\n');

        }
    }
}
