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
            this.Info_Inquire = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffid = new System.Windows.Forms.Label();
            this.Sell_Inquire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Info_Manage)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_Info_Manage
            // 
            this.Staff_Info_Manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_Info_Manage.Location = new System.Drawing.Point(26, 118);
            this.Staff_Info_Manage.Name = "Staff_Info_Manage";
            this.Staff_Info_Manage.RowTemplate.Height = 23;
            this.Staff_Info_Manage.Size = new System.Drawing.Size(534, 271);
            this.Staff_Info_Manage.TabIndex = 0;
            this.Staff_Info_Manage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_Info_Manage_CellContentClick);
            // 
            // Info_Inquire
            // 
            this.Info_Inquire.Location = new System.Drawing.Point(255, 21);
            this.Info_Inquire.Name = "Info_Inquire";
            this.Info_Inquire.Size = new System.Drawing.Size(75, 23);
            this.Info_Inquire.TabIndex = 1;
            this.Info_Inquire.Text = "信息查询";
            this.Info_Inquire.UseVisualStyleBackColor = true;
            this.Info_Inquire.Click += new System.EventHandler(this.Info_Inquire_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(255, 72);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删 除";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(390, 72);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "修 改";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 21);
            this.textBox1.TabIndex = 4;
            // 
            // staffid
            // 
            this.staffid.AutoSize = true;
            this.staffid.Location = new System.Drawing.Point(27, 55);
            this.staffid.Name = "staffid";
            this.staffid.Size = new System.Drawing.Size(53, 12);
            this.staffid.TabIndex = 5;
            this.staffid.Text = "员工编号";
            // 
            // Sell_Inquire
            // 
            this.Sell_Inquire.Location = new System.Drawing.Point(390, 21);
            this.Sell_Inquire.Name = "Sell_Inquire";
            this.Sell_Inquire.Size = new System.Drawing.Size(75, 23);
            this.Sell_Inquire.TabIndex = 6;
            this.Sell_Inquire.Text = "业绩查询";
            this.Sell_Inquire.UseVisualStyleBackColor = true;
            this.Sell_Inquire.Click += new System.EventHandler(this.Sell_Inquire_Click);
            // 
            // Staff_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 408);
            this.Controls.Add(this.Sell_Inquire);
            this.Controls.Add(this.staffid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Info_Inquire);
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
        private System.Windows.Forms.Button Info_Inquire;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label staffid;
        private System.Windows.Forms.Button Sell_Inquire;

    }
}