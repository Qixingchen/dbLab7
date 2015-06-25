namespace lab7
{
    partial class Inventory
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
            this.selectName = new System.Windows.Forms.TextBox();
            this.inquire = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectName
            // 
            this.selectName.Location = new System.Drawing.Point(47, 12);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(100, 21);
            this.selectName.TabIndex = 0;
            // 
            // inquire
            // 
            this.inquire.Location = new System.Drawing.Point(169, 10);
            this.inquire.Name = "inquire";
            this.inquire.Size = new System.Drawing.Size(75, 23);
            this.inquire.TabIndex = 1;
            this.inquire.Text = "查询";
            this.inquire.UseVisualStyleBackColor = true;
            this.inquire.Click += new System.EventHandler(this.inquire_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(654, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inquire);
            this.Controls.Add(this.selectName);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectName;
        private System.Windows.Forms.Button inquire;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}