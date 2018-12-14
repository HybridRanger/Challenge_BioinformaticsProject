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
        private string connectionString = "server=localhost;database=challenge;";
        public ModifyData()
        {
            InitializeComponent();
        }

        private void ModifyData_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
        }
        private void Return_To_Menu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void NewData_Click(object sender, EventArgs e)
        {

        }

        private void Modify_Data_Click(object sender, EventArgs e)
        {

        }

        private void TableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
