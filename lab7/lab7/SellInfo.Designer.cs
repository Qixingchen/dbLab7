using System.ComponentModel;
using System.Windows.Forms;

namespace lab7
{
    partial class SellInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.Textbox1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(503, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售信息管理";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(394, 27);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 24);
            this.delete.TabIndex = 4;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(280, 27);
            this.update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(84, 24);
            this.update.TabIndex = 3;
            this.update.Text = "编辑";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(168, 27);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(83, 24);
            this.Search.TabIndex = 2;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(9, 27);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(139, 21);
            this.Textbox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.销售ID,
            this.日期,
            this.Column1,
            this.Column2,
            this.商品ID,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(28, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Location = new System.Drawing.Point(57, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(503, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 6.375F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入销售信息ID";
            // 
            // SellInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellInfo";
            this.Text = "SellInfo";
            this.Load += new System.EventHandler(this.SellInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Label label1;
        private GroupBox groupBox1;
        private Button delete;
        private Button update;
        private Button Search;
        private TextBox Textbox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn 销售ID;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn 商品ID;
        private DataGridViewTextBoxColumn Column3;
    }
}