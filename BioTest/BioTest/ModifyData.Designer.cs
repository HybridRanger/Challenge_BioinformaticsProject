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
            this.TableList = new System.Windows.Forms.ListView();
            this.NewDataButton = new System.Windows.Forms.Button();
            this.ModifyDataButton = new System.Windows.Forms.Button();
            this.DataList = new System.Windows.Forms.ListView();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.Temp = new System.Windows.Forms.Label();
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
            this.Return_To_Menu.Click += new System.EventHandler(this.Return_To_Menu_Click);
            // 
            // TableList
            // 
            this.TableList.Location = new System.Drawing.Point(12, 50);
            this.TableList.Name = "TableList";
            this.TableList.Size = new System.Drawing.Size(235, 247);
            this.TableList.TabIndex = 2;
            this.TableList.UseCompatibleStateImageBehavior = false;
            this.TableList.SelectedIndexChanged += new System.EventHandler(this.TableList_SelectedIndexChanged);
            // 
            // NewDataButton
            // 
            this.NewDataButton.Location = new System.Drawing.Point(10, 316);
            this.NewDataButton.Name = "NewDataButton";
            this.NewDataButton.Size = new System.Drawing.Size(75, 23);
            this.NewDataButton.TabIndex = 4;
            this.NewDataButton.Text = "New";
            this.NewDataButton.UseVisualStyleBackColor = true;
            this.NewDataButton.Click += new System.EventHandler(this.NewData_Click);
            // 
            // ModifyDataButton
            // 
            this.ModifyDataButton.Location = new System.Drawing.Point(91, 316);
            this.ModifyDataButton.Name = "ModifyDataButton";
            this.ModifyDataButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyDataButton.TabIndex = 5;
            this.ModifyDataButton.Text = "Modify";
            this.ModifyDataButton.UseVisualStyleBackColor = true;
            this.ModifyDataButton.Click += new System.EventHandler(this.Modify_Data_Click);
            // 
            // DataList
            // 
            this.DataList.Location = new System.Drawing.Point(346, 50);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(235, 159);
            this.DataList.TabIndex = 6;
            this.DataList.UseCompatibleStateImageBehavior = false;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(172, 316);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDataButton.TabIndex = 7;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(343, 284);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(35, 13);
            this.Temp.TabIndex = 8;
            this.Temp.Text = "label1";
            // 
            // ModifyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 556);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.ModifyDataButton);
            this.Controls.Add(this.NewDataButton);
            this.Controls.Add(this.TableList);
            this.Controls.Add(this.Return_To_Menu);
            this.Name = "ModifyData";
            this.Text = "ModifyData";
            this.Load += new System.EventHandler(this.ModifyData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return_To_Menu;
        private System.Windows.Forms.ListView TableList;
        private System.Windows.Forms.Button NewDataButton;
        private System.Windows.Forms.Button ModifyDataButton;
        private System.Windows.Forms.ListView DataList;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Label Temp;
    }
}