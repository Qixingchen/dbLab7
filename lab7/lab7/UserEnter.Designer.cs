﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    partial class UserEnter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.comboBox1 = new ComboBox();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            this.label1.Click += new EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new Point(266, 145);
            this.label4.Name = "label4";
            this.label4.Size = new Size(63, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工年龄";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new Point(105, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(100, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(105, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(341, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(341, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(100, 21);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new Point(200, 211);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // UserEnter
            // 
            this.AutoScaleDimensions = new SizeF(6F, 12F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(499, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserEnter";
            this.Text = "UserEnter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;

    }
}

