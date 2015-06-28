namespace lab7
{
    partial class Staff_Manage
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
            this.Staff_Info_Manage = new System.Windows.Forms.DataGridView();
            this.Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inquire = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Info_Manage)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_Info_Manage
            // 
            this.Staff_Info_Manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_Info_Manage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staff_ID,
            this.Staff_Name,
            this.Staff_Sex,
            this.Staff_Age});
            this.Staff_Info_Manage.Location = new System.Drawing.Point(29, 106);
            this.Staff_Info_Manage.Name = "Staff_Info_Manage";
            this.Staff_Info_Manage.RowTemplate.Height = 23;
            this.Staff_Info_Manage.Size = new System.Drawing.Size(501, 259);
            this.Staff_Info_Manage.TabIndex = 0;
            this.Staff_Info_Manage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_Info_Manage_CellContentClick);
            // 
            // Staff_ID
            // 
            this.Staff_ID.HeaderText = "ID";
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Staff_Name
            // 
            this.Staff_Name.HeaderText = "员工姓名";
            this.Staff_Name.Name = "Staff_Name";
            // 
            // Staff_Sex
            // 
            this.Staff_Sex.HeaderText = "员工性别";
            this.Staff_Sex.Name = "Staff_Sex";
            // 
            // Staff_Age
            // 
            this.Staff_Age.HeaderText = "员工年龄";
            this.Staff_Age.Name = "Staff_Age";
            // 
            // Inquire
            // 
            this.Inquire.Location = new System.Drawing.Point(225, 50);
            this.Inquire.Name = "Inquire";
            this.Inquire.Size = new System.Drawing.Size(75, 23);
            this.Inquire.TabIndex = 1;
            this.Inquire.Text = "查 询";
            this.Inquire.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(327, 50);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删 除";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(427, 50);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "修 改";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 4;
            // 
            // Staff_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Inquire);
            this.Controls.Add(this.Staff_Info_Manage);
            this.Name = "Staff_Manage";
            this.Text = "Staff_Manage";
            this.Load += new System.EventHandler(this.Staff_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Info_Manage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Staff_Info_Manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Age;
        private System.Windows.Forms.Button Inquire;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;

    }
}