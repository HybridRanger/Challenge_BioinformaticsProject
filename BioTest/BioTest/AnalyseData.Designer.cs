namespace BioTest
{
    partial class AnalyseData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Return_To_Menu = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Refresh_Grid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Return_To_Menu
            // 
            this.Return_To_Menu.Location = new System.Drawing.Point(12, 12);
            this.Return_To_Menu.Name = "Return_To_Menu";
            this.Return_To_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return_To_Menu.Size = new System.Drawing.Size(75, 23);
            this.Return_To_Menu.TabIndex = 1;
            this.Return_To_Menu.Text = "Back";
            this.Return_To_Menu.UseVisualStyleBackColor = true;
            this.Return_To_Menu.Click += new System.EventHandler(this.Return_To_Menu_Click_1);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(213, 12);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 10;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid.Size = new System.Drawing.Size(800, 600);
            this.Grid.TabIndex = 2;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Refresh_Grid
            // 
            this.Refresh_Grid.Location = new System.Drawing.Point(12, 68);
            this.Refresh_Grid.Name = "Refresh_Grid";
            this.Refresh_Grid.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Grid.TabIndex = 3;
            this.Refresh_Grid.Text = "Refresh";
            this.Refresh_Grid.UseVisualStyleBackColor = true;
            this.Refresh_Grid.Click += new System.EventHandler(this.Refresh_Grid_Click);
            // 
            // AnalyseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 662);
            this.Controls.Add(this.Refresh_Grid);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Return_To_Menu);
            this.Name = "AnalyseData";
            this.Text = "AnalyseData";
            this.Load += new System.EventHandler(this.AnalyseData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return_To_Menu;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button Refresh_Grid;
    }
}