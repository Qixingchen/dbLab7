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
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Staff_Age,
            this.delete,
            this.Update});
            this.Staff_Info_Manage.Location = new System.Drawing.Point(28, 44);
            this.Staff_Info_Manage.Name = "Staff_Info_Manage";
            this.Staff_Info_Manage.RowTemplate.Height = 23;
            this.Staff_Info_Manage.Size = new System.Drawing.Size(684, 330);
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
            // delete
            // 
            this.delete.DataPropertyName = "删除";
            this.delete.FillWeight = 80F;
            this.delete.HeaderText = "操作";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "编辑";
            this.Update.Name = "Update";
            this.Update.Text = "编辑";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Staff_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 386);
            this.Controls.Add(this.Staff_Info_Manage);
            this.Name = "Staff_Manage";
            this.Text = "Staff_Manage";
            this.Load += new System.EventHandler(this.Staff_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Info_Manage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Staff_Info_Manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Age;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;

    }
}