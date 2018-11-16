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
            this.SuspendLayout();
            // 
            // Return_To_Menu
            // 
            this.Return_To_Menu.Location = new System.Drawing.Point(105, 119);
            this.Return_To_Menu.Name = "Return_To_Menu";
            this.Return_To_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return_To_Menu.Size = new System.Drawing.Size(75, 23);
            this.Return_To_Menu.TabIndex = 1;
            this.Return_To_Menu.Text = "Back";
            this.Return_To_Menu.UseVisualStyleBackColor = true;
            this.Return_To_Menu.Click += new System.EventHandler(this.Return_To_Menu_Click);
            // 
            // ModifyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Return_To_Menu);
            this.Name = "ModifyData";
            this.Text = "ModifyData";
            this.Load += new System.EventHandler(this.ModifyData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return_To_Menu;
    }
}