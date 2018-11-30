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
        private int numberOfColumns = 10, numberOfRows = 10;
        private StreamReader sr = new StreamReader(@"H:\Documents\GitHub\Challenge_BioinformaticsProject_Repo\BioTest\Data.csv");
        private Dictionary<int, Color> colourDictionary = new Dictionary<int, Color>();

        public AnalyseData()
        {
            InitializeComponent();
        }

        private void AnalyseData_Load(object sender, EventArgs e)
        {
            gridHeight = Grid.Height;
            gridWidth = Grid.Width;

            colourDictionary.Add(0, Color.FromArgb(107, 1, 24));
            colourDictionary.Add(1, Color.FromArgb(182, 22, 37));
            colourDictionary.Add(2, Color.FromArgb(224, 94, 72));
            colourDictionary.Add(3, Color.FromArgb(255, 171, 134));
            colourDictionary.Add(4, Color.FromArgb(254, 221, 204));
            colourDictionary.Add(5, Color.FromArgb(255, 255, 255));
            colourDictionary.Add(6, Color.FromArgb(216, 241, 251));
            colourDictionary.Add(7, Color.FromArgb(153, 205, 232));
            colourDictionary.Add(8, Color.FromArgb(67, 152, 206));
            colourDictionary.Add(9, Color.FromArgb(30, 103, 167));
            colourDictionary.Add(10, Color.FromArgb(16, 47, 91));

            numberOfColours = colourDictionary.Count;
        }

        private void Refresh_Grid_Click(object sender, EventArgs e)
        {
            Grid.ColumnCount = numberOfColumns;

            using (sr)
            {
                DataGridViewRow gridRow = (DataGridViewRow)Grid.Rows[0].Clone();

                string file = sr.ReadToEnd();

                string[] lines = file.Split('\n');

                cellHeight = gridHeight / numberOfRows;
                cellWidth = gridWidth / numberOfColumns;

                for (int i = 0; i < numberOfRows; i++)
                {
                    string line = lines[i];
                    gridRow = (DataGridViewRow)Grid.Rows[i].Clone();

                    string[] lineElements = line.Split(',');

                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        string element = lineElements[j];

                        if (i == 0 && j == 0)
                        {
                            Grid.TopLeftHeaderCell.Value = element;
                        }
                        else if (j == 0 && i != 0)
                        {
                            Grid.Rows[i].HeaderCell.Value = element;
                            Grid.Rows[i].Height = cellHeight;
                        }
                        else if (i == 0 && j != 0)
                        {
                            Grid.Columns[j].Width = cellWidth;
                        }
                        else
                        {
                            Grid.Columns[j].Width = cellWidth;
                            gridRow.Cells[j].Style.BackColor = ValueToColour(element);
                        }

                    }
                    Grid.Rows.Add(gridRow);
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
