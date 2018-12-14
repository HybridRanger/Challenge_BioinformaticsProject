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
        private string connectionString = "server=localhost;user=root;database=mice_cancer;";
        public ModifyData()
        {
            InitializeComponent();
        }

        private void ModifyData_Load(object sender, EventArgs e)
        {
         
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            { 
                con.Open();

                string sql = "SHOW TABLES";

                MySqlCommand cmd = new MySqlCommand(sql, con);
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
                    MessageBox.Show(text);
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
         Dev
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string drop = "DROP TABLE IF EXISTS " + name + ";";
                string sql = "CREATE TABLE IF NOT EXISTS " + name + " (" +
                    "Id INT UNSIGNED NOT NULL AUTO_INCREMENT," +
                    "ProbeName VARCHAR(30) NOT NULL DEFAULT ''," +
                    "LogRatio DECIMAL(6, 5) NOT NULL DEFAULT 0.00000," +
                    "PRIMARY KEY (ID));";

                MySqlCommand dropTable = new MySqlCommand(drop, conn);
                dropTable.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string[] lines = text.Split('\n');
                string sqlInsert = "INSERT INTO " + name;

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    //sqlInsert += "(" + values[0] + "," + float.Parse(values[1]) + "),";
                    MessageBox.Show("text: " + text);
                }

                sqlInsert += "( , );";

                //MessageBox.Show(sqlInsert);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }
    }
}
