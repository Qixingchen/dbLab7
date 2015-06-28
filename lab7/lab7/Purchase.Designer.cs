namespace lab7
{
    partial class Purchase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parchase_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parchase_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inquire = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parchase_ID,
            this.Parchase_Time,
            this.Item_count,
            this.Goods_ID,
            this.Staff_ID});
            this.dataGridView1.Location = new System.Drawing.Point(28, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(608, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // Parchase_ID
            // 
            this.Parchase_ID.HeaderText = "进货编号";
            this.Parchase_ID.Name = "Parchase_ID";
            // 
            // Parchase_Time
            // 
            this.Parchase_Time.HeaderText = "进货时间";
            this.Parchase_Time.Name = "Parchase_Time";
            // 
            // Item_count
            // 
            this.Item_count.HeaderText = "商品数量";
            this.Item_count.Name = "Item_count";
            // 
            // Goods_ID
            // 
            this.Goods_ID.HeaderText = "商品编号";
            this.Goods_ID.Name = "Goods_ID";
            // 
            // Staff_ID
            // 
            this.Staff_ID.HeaderText = "员工编号";
            this.Staff_ID.Name = "Staff_ID";
            // 
            // Inquire
            // 
            this.Inquire.Location = new System.Drawing.Point(269, 69);
            this.Inquire.Name = "Inquire";
            this.Inquire.Size = new System.Drawing.Size(75, 25);
            this.Inquire.TabIndex = 1;
            this.Inquire.Text = "查 询";
            this.Inquire.UseVisualStyleBackColor = true;
            this.Inquire.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(394, 69);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 25);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "删 除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(518, 69);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 25);
            this.Update.TabIndex = 3;
            this.Update.Text = "修 改";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 21);
            this.textBox1.TabIndex = 4;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Inquire);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parchase_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parchase_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
        private System.Windows.Forms.Button Inquire;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;
    }
}