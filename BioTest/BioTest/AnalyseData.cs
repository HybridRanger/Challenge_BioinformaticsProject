using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioTest
{
    public partial class AnalyseData : Form
    {
        public AnalyseData()
        {
            InitializeComponent();
        }

        private void AnalyseData_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)Grid.Rows[0].Clone();
            for (int i = 0; i < 4; i++)
            {
                row.Cells[0].Style.BackColor = Color.Red;
                row.Cells[1].Value = 50.2;
            }
            Grid.Rows.Add(row);
        }

        private void Return_To_Menu_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
