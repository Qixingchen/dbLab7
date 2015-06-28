namespace lab7
{
    partial class Update_Staff
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
            this.staffid = new System.Windows.Forms.Label();
            this.staffname = new System.Windows.Forms.Label();
            this.staffgender = new System.Windows.Forms.Label();
            this.staffage = new System.Windows.Forms.Label();
            this.stafftype = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staffid
            // 
            this.staffid.AutoSize = true;
            this.staffid.Location = new System.Drawing.Point(41, 51);
            this.staffid.Name = "staffid";
            this.staffid.Size = new System.Drawing.Size(53, 12);
            this.staffid.TabIndex = 0;
            this.staffid.Text = "员工编号";
            // 
            // staffname
            // 
            this.staffname.AutoSize = true;
            this.staffname.Location = new System.Drawing.Point(284, 51);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(53, 12);
            this.staffname.TabIndex = 1;
            this.staffname.Text = "员工姓名";
            // 
            // staffgender
            // 
            this.staffgender.AutoSize = true;
            this.staffgender.Location = new System.Drawing.Point(41, 134);
            this.staffgender.Name = "staffgender";
            this.staffgender.Size = new System.Drawing.Size(53, 12);
            this.staffgender.TabIndex = 2;
            this.staffgender.Text = "员工性别";
            // 
            // staffage
            // 
            this.staffage.AutoSize = true;
            this.staffage.Location = new System.Drawing.Point(284, 134);
            this.staffage.Name = "staffage";
            this.staffage.Size = new System.Drawing.Size(53, 12);
            this.staffage.TabIndex = 3;
            this.staffage.Text = "员工年龄";
            // 
            // stafftype
            // 
            this.stafftype.AutoSize = true;
            this.stafftype.Location = new System.Drawing.Point(41, 235);
            this.stafftype.Name = "stafftype";
            this.stafftype.Size = new System.Drawing.Size(53, 12);
            this.stafftype.TabIndex = 4;
            this.stafftype.Text = "员工类型";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(342, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(342, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 9;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(192, 292);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 32);
            this.update.TabIndex = 10;
            this.update.Text = "确 认 更 新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Update_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 349);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stafftype);
            this.Controls.Add(this.staffage);
            this.Controls.Add(this.staffgender);
            this.Controls.Add(this.staffname);
            this.Controls.Add(this.staffid);
            this.Name = "Update_Staff";
            this.Text = "Update_Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffid;
        private System.Windows.Forms.Label staffname;
        private System.Windows.Forms.Label staffgender;
        private System.Windows.Forms.Label staffage;
        private System.Windows.Forms.Label stafftype;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button update;
    }
}