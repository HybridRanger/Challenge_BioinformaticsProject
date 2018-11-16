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

        }

        private void Return_To_Menu_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
