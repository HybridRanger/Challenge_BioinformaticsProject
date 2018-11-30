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
    public partial class Form1 : Form
    {
        private string probeName;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =  QueryDB();
        }

        string QueryDB()
        {
            string output = null;

            string connStr = "server=localhost;user=root;database=micecancer;port=3306";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT SystematicName FROM iwanttodie WHERE ProbeName = '" + probeName + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    output += rdr[0];

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                output = ex.ToString();
            }

            conn.Close();

            return output;
        }

        private void Menu_Import_Click(object sender, EventArgs e)
        {
            SwitchForm(new ImportData());
        }

        private void Menu_Modify_Click(object sender, EventArgs e)
        {
            SwitchForm(new ModifyData());
        }

        private void Menu_Analyse_Click(object sender, EventArgs e)
        {
            SwitchForm(new AnalyseData());
        }

        void SwitchForm(Form newForm)
        {
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
