﻿namespace lab7
{
    partial class GoodsList
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
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.goods_dataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GoodsInsertBtn = new System.Windows.Forms.Button();
            this.GoodsDeleteBtn = new System.Windows.Forms.Button();
            this.GoodsEditBtn = new System.Windows.Forms.Button();
            this.GoodsSelectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsname_key = new System.Windows.Forms.TextBox();
            this.row_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportBtn
            // 
            this.ExportBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExportBtn.Location = new System.Drawing.Point(8, 73);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(109, 25);
            this.ExportBtn.TabIndex = 8;
            this.ExportBtn.Text = "Export GoodsList";
            this.ExportBtn.UseVisualStyleBackColor = true;
            // 
            // ImportBtn
            // 
            this.ImportBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportBtn.Location = new System.Drawing.Point(8, 22);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(109, 25);
            this.ImportBtn.TabIndex = 10;
            this.ImportBtn.Text = "Import GoodsList";
            this.ImportBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.goods_dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(123, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 376);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // goods_dataGridView
            // 
            this.goods_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_dataGridView.Location = new System.Drawing.Point(7, 15);
            this.goods_dataGridView.Name = "goods_dataGridView";
            this.goods_dataGridView.RowTemplate.Height = 23;
            this.goods_dataGridView.Size = new System.Drawing.Size(544, 355);
            this.goods_dataGridView.TabIndex = 0;
            this.goods_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_dataGridView_CellContentClick);
            this.goods_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_dataGridView_CellContentClick);
            this.goods_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.goods_dataGridView_RowHeaderMouseClick);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserName.Location = new System.Drawing.Point(6, 301);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(104, 18);
            this.UserName.TabIndex = 13;
            this.UserName.Text = "商品图片预览";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoodsInsertBtn);
            this.groupBox1.Controls.Add(this.GoodsDeleteBtn);
            this.groupBox1.Controls.Add(this.GoodsEditBtn);
            this.groupBox1.Controls.Add(this.GoodsSelectBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goodsname_key);
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // GoodsInsertBtn
            // 
            this.GoodsInsertBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsInsertBtn.Location = new System.Drawing.Point(317, 20);
            this.GoodsInsertBtn.Name = "GoodsInsertBtn";
            this.GoodsInsertBtn.Size = new System.Drawing.Size(56, 25);
            this.GoodsInsertBtn.TabIndex = 18;
            this.GoodsInsertBtn.Text = "新增";
            this.GoodsInsertBtn.UseVisualStyleBackColor = true;
            this.GoodsInsertBtn.Click += new System.EventHandler(this.GoodsInsertBtn_Click);
            // 
            // GoodsDeleteBtn
            // 
            this.GoodsDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsDeleteBtn.Location = new System.Drawing.Point(483, 20);
            this.GoodsDeleteBtn.Name = "GoodsDeleteBtn";
            this.GoodsDeleteBtn.Size = new System.Drawing.Size(57, 25);
            this.GoodsDeleteBtn.TabIndex = 17;
            this.GoodsDeleteBtn.Text = "删除";
            this.GoodsDeleteBtn.UseVisualStyleBackColor = true;
            this.GoodsDeleteBtn.Click += new System.EventHandler(this.GoodsDeleteBtn_Click);
            // 
            // GoodsEditBtn
            // 
            this.GoodsEditBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsEditBtn.Location = new System.Drawing.Point(398, 20);
            this.GoodsEditBtn.Name = "GoodsEditBtn";
            this.GoodsEditBtn.Size = new System.Drawing.Size(57, 25);
            this.GoodsEditBtn.TabIndex = 16;
            this.GoodsEditBtn.Text = "编辑";
            this.GoodsEditBtn.UseVisualStyleBackColor = true;
            this.GoodsEditBtn.Click += new System.EventHandler(this.GoodsEditBtn_Click);
            // 
            // GoodsSelectBtn
            // 
            this.GoodsSelectBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodsSelectBtn.Location = new System.Drawing.Point(215, 21);
            this.GoodsSelectBtn.Name = "GoodsSelectBtn";
            this.GoodsSelectBtn.Size = new System.Drawing.Size(43, 25);
            this.GoodsSelectBtn.TabIndex = 15;
            this.GoodsSelectBtn.Text = "查询";
            this.GoodsSelectBtn.UseVisualStyleBackColor = true;
            this.GoodsSelectBtn.Click += new System.EventHandler(this.GoodsSelectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // goodsname_key
            // 
            this.goodsname_key.Location = new System.Drawing.Point(62, 22);
            this.goodsname_key.Name = "goodsname_key";
            this.goodsname_key.Size = new System.Drawing.Size(133, 21);
            this.goodsname_key.TabIndex = 4;
            // 
            // row_text
            // 
            this.row_text.Location = new System.Drawing.Point(68, 119);
            this.row_text.Name = "row_text";
            this.row_text.Size = new System.Drawing.Size(49, 21);
            this.row_text.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "选中行";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // refreshBtn
            // 
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.refreshBtn.Location = new System.Drawing.Point(74, 160);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(43, 25);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 106);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // GoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.row_text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ImportBtn);
            this.Name = "GoodsList";
            this.Text = "商品清单";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goods_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.DataGridView goods_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goodsname_key;
        private System.Windows.Forms.Button GoodsInsertBtn;
        private System.Windows.Forms.Button GoodsDeleteBtn;
        private System.Windows.Forms.Button GoodsEditBtn;
        private System.Windows.Forms.Button GoodsSelectBtn;
        private System.Windows.Forms.TextBox row_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}