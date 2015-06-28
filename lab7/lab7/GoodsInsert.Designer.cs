namespace lab7
{
    partial class GoodsInsert
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
            this.id_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commitBtn = new System.Windows.Forms.Button();
            this.photoid_comboBox = new System.Windows.Forms.ComboBox();
            this.addPhotoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(68, 17);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(82, 21);
            this.id_text.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(212, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "名称：";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(268, 17);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(82, 21);
            this.name_text.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "单价：";
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(68, 70);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(82, 21);
            this.price_text.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(212, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "图片ID：";
            // 
            // commitBtn
            // 
            this.commitBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commitBtn.Location = new System.Drawing.Point(103, 132);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(74, 25);
            this.commitBtn.TabIndex = 27;
            this.commitBtn.Text = "提交";
            this.commitBtn.UseVisualStyleBackColor = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // photoid_comboBox
            // 
            this.photoid_comboBox.FormattingEnabled = true;
            this.photoid_comboBox.Location = new System.Drawing.Point(268, 67);
            this.photoid_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.photoid_comboBox.Name = "photoid_comboBox";
            this.photoid_comboBox.Size = new System.Drawing.Size(82, 20);
            this.photoid_comboBox.TabIndex = 28;
            // 
            // addPhotoBtn
            // 
            this.addPhotoBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPhotoBtn.Location = new System.Drawing.Point(215, 132);
            this.addPhotoBtn.Name = "addPhotoBtn";
            this.addPhotoBtn.Size = new System.Drawing.Size(74, 25);
            this.addPhotoBtn.TabIndex = 29;
            this.addPhotoBtn.Text = "新增图片";
            this.addPhotoBtn.UseVisualStyleBackColor = true;
            this.addPhotoBtn.Click += new System.EventHandler(this.addPhotoBtn_Click);
            // 
            // GoodsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 176);
            this.Controls.Add(this.addPhotoBtn);
            this.Controls.Add(this.photoid_comboBox);
            this.Controls.Add(this.commitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_text);
            this.Name = "GoodsInsert";
            this.Text = "商品信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button commitBtn;
        private System.Windows.Forms.ComboBox photoid_comboBox;
        private System.Windows.Forms.Button addPhotoBtn;
    }
}