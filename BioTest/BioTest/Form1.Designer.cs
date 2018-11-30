namespace BioTest
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.Menu_Analyse = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Menu_Modify = new System.Windows.Forms.Button();
            this.Menu_Import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"Title\"";
            // 
            // Menu_Analyse
            // 
            this.Menu_Analyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Analyse.Location = new System.Drawing.Point(16, 159);
            this.Menu_Analyse.Name = "Menu_Analyse";
            this.Menu_Analyse.Size = new System.Drawing.Size(365, 30);
            this.Menu_Analyse.TabIndex = 8;
            this.Menu_Analyse.Text = "Analyse Data";
            this.Menu_Analyse.UseVisualStyleBackColor = true;
            this.Menu_Analyse.Click += new System.EventHandler(this.Menu_Analyse_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(16, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(295, 253);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 30);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu_Modify
            // 
            this.Menu_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Modify.Location = new System.Drawing.Point(16, 123);
            this.Menu_Modify.Name = "Menu_Modify";
            this.Menu_Modify.Size = new System.Drawing.Size(365, 30);
            this.Menu_Modify.TabIndex = 3;
            this.Menu_Modify.Text = "Modify Data";
            this.Menu_Modify.UseVisualStyleBackColor = true;
            this.Menu_Modify.Click += new System.EventHandler(this.Menu_Modify_Click);
            // 
            // Menu_Import
            // 
            this.Menu_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Import.Location = new System.Drawing.Point(16, 87);
            this.Menu_Import.Name = "Menu_Import";
            this.Menu_Import.Size = new System.Drawing.Size(365, 30);
            this.Menu_Import.TabIndex = 12;
            this.Menu_Import.Text = "Import Data";
            this.Menu_Import.UseVisualStyleBackColor = true;
            this.Menu_Import.Click += new System.EventHandler(this.Menu_Import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "\"Logo\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_Import);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Menu_Analyse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menu_Modify);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Menu_Analyse;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Menu_Modify;
        private System.Windows.Forms.Button Menu_Import;
        private System.Windows.Forms.Label label1;
    }
}

