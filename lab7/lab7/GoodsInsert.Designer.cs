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
            this.photoid_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.count_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.photourl_text = new System.Windows.Forms.TextBox();
            this.commitBtn = new System.Windows.Forms.Button();
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
            // photoid_text
            // 
            this.photoid_text.Location = new System.Drawing.Point(268, 67);
            this.photoid_text.Name = "photoid_text";
            this.photoid_text.Size = new System.Drawing.Size(82, 21);
            this.photoid_text.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "数量：";
            // 
            // count_text
            // 
            this.count_text.Location = new System.Drawing.Point(68, 170);
            this.count_text.Name = "count_text";
            this.count_text.Size = new System.Drawing.Size(82, 21);
            this.count_text.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "图片url：";
            // 
            // photourl_text
            // 
            this.photourl_text.Location = new System.Drawing.Point(68, 125);
            this.photourl_text.Name = "photourl_text";
            this.photourl_text.Size = new System.Drawing.Size(201, 21);
            this.photourl_text.TabIndex = 25;
            // 
            // commitBtn
            // 
            this.commitBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commitBtn.Location = new System.Drawing.Point(159, 215);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(74, 25);
            this.commitBtn.TabIndex = 27;
            this.commitBtn.Text = "提交";
            this.commitBtn.UseVisualStyleBackColor = true;
            // 
            // GoodsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 252);
            this.Controls.Add(this.commitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.photourl_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.count_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.photoid_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_text);
            this.Name = "GoodsInsert";
            this.Text = "商品信息";
            this.Load += new System.EventHandler(this.GoodsInsert_Load);
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
        private System.Windows.Forms.TextBox photoid_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox count_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox photourl_text;
        private System.Windows.Forms.Button commitBtn;
    }
}