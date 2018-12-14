using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BioTest
{
    public partial class AnalyseData : Form
    {
        private float min = 0, max = 13;
        private int numberOfColours;
        private int cellHeight, cellWidth;
        private int gridHeight, gridWidth;
        private int headerHeight = 50, headerWidth = 80;
        private int numberOfColumns = 50, numberOfRows = 50;
        private StreamReader sr;
        private string colourDictPath, dataPath;
        private Dictionary<int, Color> colourDictionary = new Dictionary<int, Color>();

        public AnalyseData()
        {
            InitializeComponent();
        }

        private void AnalyseData_Load(object sender, EventArgs e)
        {
            gridHeight = Grid.Height;
            gridWidth = Grid.Width;

            colourDictPath = @"H:\Documents\GitHub\Challenge_BioinformaticsProject\BioTest\ColourDict.csv";
            dataPath = @"H:\Documents\GitHub\Challenge_BioinformaticsProject\BioTest\Data.csv";

            using (sr = new StreamReader(colourDictPath))
            {
                string[] colours = sr.ReadToEnd().Split('\n');
                int i = 0;
                foreach (string colour in colours)
                {
                    string[] values = colour.Split(',');
                    colourDictionary.Add(i, Color.FromArgb(255, Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), Convert.ToInt16(values[2])));
                    i++;
                }
            }

            numberOfColours = colourDictionary.Count;
        }

        private void Refresh_Grid_Click(object sender, EventArgs e)
        {
            Grid.ColumnCount = numberOfColumns;
            Grid.RowCount = numberOfRows;

            using (sr = new StreamReader(dataPath))
            {
                DataGridViewRow gridRow = (DataGridViewRow)Grid.Rows[0].Clone();

                string file = sr.ReadToEnd();

                string[] lines = file.Split('\n');

                cellHeight = (gridHeight - headerHeight) / numberOfRows;
                cellWidth = (gridWidth - headerWidth) / numberOfColumns;

                string[] header = lines[0].Split(',');

                Grid.TopLeftHeaderCell.Value = header[0];
                Grid.RowHeadersWidth = headerWidth;
                Grid.ColumnHeadersHeight = headerHeight;

                for (int j = 0; j < numberOfRows; j++)
                {
                    string[] elements = lines[j+1].Split(',');
                    Grid.Rows[j].HeaderCell.Value = elements[0];

                    for (int i = 0; i < numberOfColumns; i++)
                    {                
                        Grid.Rows[j].Height = cellHeight;
                        Grid.Columns[i].Width = cellWidth;
                        Grid.Rows[j].Cells[i].Style.BackColor = ValueToColour(elements[i + 1]);
                    }
                }
            }
        }

        private void Return_To_Menu_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Color ValueToColour(string stringValue)
        {
            float floatValue = float.Parse(stringValue, System.Globalization.CultureInfo.InvariantCulture);
            float step = (max-min)/numberOfColours;

            for (float lower = min, count = 0; lower+step <= max; lower += step, count++)
            {
                float upper = lower + step;
                if (floatValue > lower && floatValue < upper)
                {
                    return colourDictionary[Convert.ToInt32(count)];
                }
            }
            return Color.Lime;
        }
    }
}
