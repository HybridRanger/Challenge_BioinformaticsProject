namespace BioTest
{
    partial class ModifyData
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
            this.NewDataButton = new System.Windows.Forms.Button();
            this.ModifyDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.Temp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Return_To_Menu
            // 
            this.Return_To_Menu.Location = new System.Drawing.Point(16, 15);
            this.Return_To_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_To_Menu.Name = "Return_To_Menu";
            this.Return_To_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return_To_Menu.Size = new System.Drawing.Size(100, 28);
            this.Return_To_Menu.TabIndex = 1;
            this.Return_To_Menu.Text = "Back";
            this.Return_To_Menu.UseVisualStyleBackColor = true;
            this.Return_To_Menu.Click += new System.EventHandler(this.Return_To_Menu_Click);
            // 
            // NewDataButton
            // 
            this.NewDataButton.Location = new System.Drawing.Point(309, 15);
            this.NewDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewDataButton.Name = "NewDataButton";
            this.NewDataButton.Size = new System.Drawing.Size(100, 28);
            this.NewDataButton.TabIndex = 4;
            this.NewDataButton.Text = "New";
            this.NewDataButton.UseVisualStyleBackColor = true;
            this.NewDataButton.Click += new System.EventHandler(this.NewData_Click);
            // 
            // ModifyDataButton
            // 
            this.ModifyDataButton.Location = new System.Drawing.Point(417, 15);
            this.ModifyDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyDataButton.Name = "ModifyDataButton";
            this.ModifyDataButton.Size = new System.Drawing.Size(100, 28);
            this.ModifyDataButton.TabIndex = 5;
            this.ModifyDataButton.Text = "Modify";
            this.ModifyDataButton.UseVisualStyleBackColor = true;
            this.ModifyDataButton.Click += new System.EventHandler(this.Modify_Data_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(525, 15);
            this.DeleteDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteDataButton.TabIndex = 7;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(869, 21);
            this.Temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(46, 17);
            this.Temp.TabIndex = 8;
            this.Temp.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListView
            // 
            this.ListView.Location = new System.Drawing.Point(206, 107);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(84, 352);
            this.ListView.TabIndex = 9;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // ModifyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 684);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.ModifyDataButton);
            this.Controls.Add(this.NewDataButton);
            this.Controls.Add(this.Return_To_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifyData";
            this.Text = "ModifyData";
            this.Load += new System.EventHandler(this.ModifyData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return_To_Menu;
        private System.Windows.Forms.Button NewDataButton;
        private System.Windows.Forms.Button ModifyDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView ListView;
    }
}